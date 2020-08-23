using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableView : MonoBehaviour
{
    //Destroys the game object
    public void kill(GameObject obj)
    {
        Destroy(obj);
    }
}
