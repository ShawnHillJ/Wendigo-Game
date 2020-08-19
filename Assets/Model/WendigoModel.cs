using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WendigoModel 
{
    public float spawnF = 0.0f;
    public float spawn_threshold = 1.0f;
    public int state = 0;       //0: inactive
                                //1: attempting spawn
                                //2: chase
    public int agg_lvl = 0;//0,1,2
    public float left = -1.0f; //determines rotations -1.0f == left, 1.0f == right              
}
