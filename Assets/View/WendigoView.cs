using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class WendigoView : MonoBehaviour
{
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        Root.model.entities.wendigo = gameObject;
        agent = GetComponent<NavMeshAgent>();
        Root.model.entities.wendigo.transform.SetPositionAndRotation(new Vector3 (0, -1000, 0), Root.model.entities.wendigo.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        switch (Root.model.wendigo.state)
        { 
            case 0: //Wendigo is deactivated
                if (Root.model.wendigo.spawnF > Root.model.wendigo.spawn_threshold)
                {
                    Root.model.wendigo.state = 1;
                }
                break;
            case 1://Wendigo is trying to spawn
                if (Root.model.entities.player.GetComponent<PlayerView>().OnScreen(Root.model.entities.wendigo))
                {
                    Root.model.wendigo.state = 2;
                    break;
                }
                Root.controller.wendigo.attempt_spawn();
                break;
            default://Wendigo is chasing the palyer
                agent.destination = Root.model.entities.player.transform.position;
                break;
        }
    }

}
