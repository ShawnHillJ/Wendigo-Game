using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootModel
{
    //Subclasses of Root. model added here so that they can be accessed by Root.model.subclass
    // Start is called before the first frame update
    public EntityModel entities = new EntityModel();
    public WendigoModel wendigo = new WendigoModel();

}
