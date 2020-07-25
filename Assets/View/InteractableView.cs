using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Destroys the game object
    public void kill(GameObject obj)
    {
        Destroy(obj);
    }
}
