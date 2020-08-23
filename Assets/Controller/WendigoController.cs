using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WendigoController
{
    // Start is called before the first frame update
    private float angle = 0.0f;    //Current angle attempting to spawn at 
    private float last_spawn_attempt = Time.time;  //Last time that a new angle was attempted
    private float distance = 4.0f;
    private bool first_chase_call = true;
    private float chase_start = Time.time;
    private float chase_wait_time = 1.0f;
    private float chase_stop_time = Time.time;
    public int attempt_spawn()
    {
        if (Time.time - last_spawn_attempt > .10f)
        {
            Root.model.entities.wendigo.transform.SetPositionAndRotation(get_wendigo_spawn_position(), Root.model.entities.wendigo.transform.rotation);
            angle += 0.01745329f * Root.model.wendigo.left;
            last_spawn_attempt = Time.time;
        }
        return -1;
    }

    private Vector3 get_wendigo_spawn_position()
    {
        Vector3 backward = Root.model.entities.player.transform.forward * -1;
        backward.Normalize();
        Vector3 w_pos = new Vector3(Mathf.Cos(angle) * backward.x - Mathf.Sin(angle) * backward.z, 0, Mathf.Sin(angle) * backward.x + Mathf.Cos(angle) * backward.z);
        w_pos *= 10.0f;
        return Root.model.entities.player.transform.position + w_pos;
    }

    //Handles the chase AI, wait time changes based on aggression level. Initial aggression level is set by an outside script
    //At the end of chase 
    public void chase(Vector3 player_pos,NavMeshAgent agent)
    {
        if (first_chase_call)
        {
            first_chase_call = false;
            chase_start = Time.time;
            switch(Root.model.wendigo.agg_lvl)
            {
                case 0:
                    agent.speed = 3.5f;
                    chase_wait_time = 1.5f;
                    chase_stop_time = chase_start + 7.0f;
                    break;
                case 1:
                    agent.speed = 4.5f;
                    chase_wait_time = 1.0f;
                    chase_stop_time = chase_start + 10.0f;
                    break;
                case 2:
                    agent.speed = 5.0f;
                    chase_wait_time = 0.0f;
                    chase_stop_time = chase_start + 15.0f;
                    break;
                
            }
        }
        if (Time.time > chase_stop_time)
        {
            Root.model.wendigo.state = 0;
            first_chase_call = true;
            Root.model.entities.wendigo.transform.SetPositionAndRotation(new Vector3(0, -1000, 0), Root.model.entities.wendigo.transform.rotation);
            return;
        }
        if (Time.time - chase_start > chase_wait_time)
        {
            agent.destination = player_pos;
        }
    }
}
