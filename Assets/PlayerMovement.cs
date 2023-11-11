using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    public void SetDestination(Vector3 DestinationPoss)
    {
        
            agent.isStopped = false;
            agent.SetDestination(DestinationPoss);
        
    }

    internal void Stop()
    {
        agent.isStopped = true;
    }
}
