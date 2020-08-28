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
        Debug.Log(Root.model.entities.wendigo.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Root.model.entities.wendigo.transform.position);

        switch (Root.model.wendigo.state)
        { 
            case 0: //Wendigo is deactivated
                Debug.Log("0");
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
                Debug.Log("1");
                Root.controller.wendigo.attempt_spawn();
                break;
            case 2://Wendigo is chasing the player
                Debug.Log("2");
                // agent.destination = Root.model.entities.player.transform.position;
                Root.controller.wendigo.chase(Root.model.entities.player.transform.position,agent);
                break;
        }
    }

}
