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
    }

    // Update is called once per frame
    void Update()
    {
        if (Root.model.entities.player.GetComponent<PlayerView>().OnScreen(gameObject))
        {
            agent.destination = Root.model.entities.player.transform.position;
        }
        else
        {
            agent.destination = gameObject.transform.position;

        }
    }

}
