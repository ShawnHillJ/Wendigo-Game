﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerView : rootElement
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        get_root.controller.player.Movement(gameObject,vertical, horizontal);
    }

}