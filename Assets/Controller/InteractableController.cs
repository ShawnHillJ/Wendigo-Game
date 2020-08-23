using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController
{

    //interact function. Intend for InteractableController to serve as a base class for interactable objects.
    //Objects that inherit from this class can overload the function to server their needs.
    public void interact(GameObject obj)
    {
        Debug.Log("Interacted");
        Root.view.interactable.kill(obj);
    }
}
