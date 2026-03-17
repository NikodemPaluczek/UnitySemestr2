using UnityEngine;
using UnityEngine.AI;
public class PlayerController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform followTarget;

    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        _navMeshAgent.SetDestination(followTarget.position);
    }
}
