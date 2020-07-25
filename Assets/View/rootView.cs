﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootView : Root
{
    //Subclasses of root added here so they can be accessed by Root.view.subclass
    public PlayerView player;
    public InteractableView interactable = new InteractableView();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
