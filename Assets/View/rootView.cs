using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootView
{
    //Subclasses of root added here so they can be accessed by Root.view.subclass
    public PlayerView player;
    public WendigoView wendigo;
    public InteractableView interactable = new InteractableView();
    // Start is called before the first frame update


}
