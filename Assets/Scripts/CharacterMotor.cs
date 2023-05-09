using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Pathfinding;

public class CharacterMotor : MonoBehaviour
{
    [SerializeField] MotorType motorType;
    [SerializeField] float destinationTreshold = 0.1f;

    Vector3 destination;
    Character character;
    NavMeshAgent agent;
    AIPath aiPath;
    Seeker seeker;
    bool isAtDestination;

    void Start()
    {
        character = GetComponent<Character>();
        switch(motorType)
        {
            case MotorType.NavMesh:
                Destroy(GetComponent<SimpleSmoothModifier>());
                Destroy(GetComponent<AIPath>());
                Destroy(GetComponent<Seeker>());
                agent = GetComponent<NavMeshAgent>();
                break;
            case MotorType.AStar:
                Destroy(GetComponent<NavMeshAgent>());
                aiPath = GetComponent<AIPath>();
                seeker = GetComponent<Seeker>();
                break;
        }
        ReachedDestination();
    }

    public void SetDestination(Vector3 _point)
    {
        isAtDestination = false;
        destination = _point;
        switch(motorType)
        {
            case MotorType.NavMesh:
                agent.enabled = true;
                agent.SetDestination(destination);
                break;
            case MotorType.AStar:
                seeker.StartPath(transform.position, destination);
                break;
        }
    }

    public void ReachedDestination()
    {
        isAtDestination = true;
        switch(motorType)
        {
            case MotorType.NavMesh:
                agent.nextPosition = transform.position;
                agent.enabled = false;
                break;
            case MotorType.AStar:

                break;
        }
        character.ReachedDestination();
    }

    private void Update()
    {
        if (isAtDestination) return;

        float _distance = (destination - transform.position).sqrMagnitude;

        if (_distance * _distance < destinationTreshold * destinationTreshold)
            ReachedDestination();
    }

    public bool IsAtDestination { get { return isAtDestination; } }

    public enum MotorType
    {
        NavMesh,
        AStar
    }
}
