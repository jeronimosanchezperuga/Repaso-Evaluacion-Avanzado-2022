using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentScript : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] Transform destinationTransform;
    public float remainingDistance;
    public bool isStopped;

    [SerializeField] Transform[] targets;
    [SerializeField] int currentTarget = 0;
    [SerializeField] float arrivingDistance;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = targets[currentTarget].position;
        Patrullaje();
    }

    void Patrullaje()
    {
        if (Vector3.Distance(transform.position,targets[currentTarget].position) < arrivingDistance)
        {
            if (currentTarget<targets.Length-1)
            {
                currentTarget++;
            }
            else
            {
                currentTarget = 0;
            }
        }
    }
}
