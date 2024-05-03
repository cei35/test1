using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostMove : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    private NavMeshAgent agent;

    private void Start()
    {
        OnGameStart();
    }

    void OnGameStart()
    {
        agent = GetComponent<NavMeshAgent>();
        Debug.Log("agent : " + agent);
    }

    void Update()
    {
        agent.SetDestination(player.position);
    }
}
