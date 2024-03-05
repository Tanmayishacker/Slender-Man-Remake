using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SlenderManNavMesh : MonoBehaviour
{
    public Transform followPlayer;
    private NavMeshAgent slenderManAgent;

    private void Awake()
    {
        slenderManAgent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        slenderManAgent.SetDestination(followPlayer.position);
    }

}