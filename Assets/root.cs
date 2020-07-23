using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootElement : MonoBehaviour
{

    public root get_root
    {
        get
        {
            return FindObjectOfType<root>(); 
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class root : MonoBehaviour
{
    public rootModel model;
    public rootView view;
    public rootController controller;
}
