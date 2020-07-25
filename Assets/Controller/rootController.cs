using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootController : Root
{
    //Subclasses of root controller added here so that they can be accessed by Root.controller.subclass;
    public PlayerController player = new PlayerController();
    public InteractableController interactable = new InteractableController();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
