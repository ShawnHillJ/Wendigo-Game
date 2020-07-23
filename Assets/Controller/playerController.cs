using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : rootElement
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Movement(GameObject obj, float vertical, float horizontal)
    {
        obj.transform.SetPositionAndRotation(new Vector3(obj.transform.position.x+(0.1f*horizontal), obj.transform.position.y, obj.transform.position.z+(0.1f*vertical)), obj.transform.rotation);
    }
}
