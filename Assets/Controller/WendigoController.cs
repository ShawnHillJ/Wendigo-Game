using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WendigoController
{
    // Start is called before the first frame update
    private float angle = 0.0f;    //Current angle attempting to spawn at 
    private float last_attempt = Time.time;  //Last time that a new angle was attempted
    private float distance = 4.0f;
    public int attempt_spawn()
    {
        if (Time.time - last_attempt > .10f)
        {
            Root.model.entities.wendigo.transform.SetPositionAndRotation(get_wendigo_spawn_position(), Root.model.entities.wendigo.transform.rotation);
            angle += 0.01745329f * Root.model.wendigo.left;
            last_attempt = Time.time;
        }
        return -1;
    }

    private Vector3 get_wendigo_spawn_position()
    {
        Vector3 backward = Root.model.entities.player.transform.forward * -1;
        backward.Normalize();
        Vector3 w_pos = new Vector3(Mathf.Cos(angle) * backward.x - Mathf.Sin(angle) * backward.z, 0, Mathf.Sin(angle) * backward.x + Mathf.Cos(angle) * backward.z);
        w_pos *= 10.0f;
        return Root.model.entities.player.transform.position + w_pos;
    }
}
