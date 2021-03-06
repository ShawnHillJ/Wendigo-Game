﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    //private root r;
    // Start is called before the first frame update
    void Start()
    {
        //r = get_root;
    }

    // Update is called once per frame
    void Update()
    {
        //Watches for then updates the player controller about player movements.
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = Input.GetAxis("Mouse Y");
        Root.controller.player.Movement(gameObject,vertical, horizontal,mouse_x,mouse_y);
    }

    private void FixedUpdate()
    {
        // Watches for the player to interact with an object. For now it defaults to destroy but at some point it will either call an interactable object instance function or a 
        // function in the player controller.
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 5.0f))
        {
            if (hit.collider.tag == "Interactable" && Input.GetKeyDown("e"))
            {
                Root.controller.interactable.interact(hit.collider.gameObject);
            }
        }
      
    }

}
