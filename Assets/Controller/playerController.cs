using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController 
{
    public void Movement(GameObject obj, float vertical, float horizontal, float mouse_x,float mouse_y)
    {
        float movement_const = 0.025f;
        float mouse_const = -2.0f;

        //Rotates the player in tandem with mouse movements
        Vector3 current_euler = obj.transform.eulerAngles;
        obj.transform.eulerAngles += new Vector3(mouse_y * mouse_const, -mouse_x * mouse_const, 0);

        //Moves the player according to axis input with respect to the orientation of the player
        Vector3 forward = obj.transform.forward;
        forward.y = 0;
        forward.Normalize();
        Vector3 rightward = obj.transform.right;
        rightward.y = 0;
        rightward.Normalize();
        obj.transform.position += movement_const * (forward*vertical + rightward*horizontal); 

    }
}
