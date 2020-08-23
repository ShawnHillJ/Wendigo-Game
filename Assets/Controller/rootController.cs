using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootController
{
    //Subclasses of root controller added here so that they can be accessed by Root.controller.subclass;
    public PlayerController player = new PlayerController();
    public InteractableController interactable = new InteractableController();
    public WendigoController wendigo = new WendigoController();

}