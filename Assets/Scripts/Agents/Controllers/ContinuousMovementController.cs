using UnityEngine;

[RequireComponent(typeof(MovementBehaviour), typeof(EngineBehaviour))]
public class ContinuousMovementController : MonoBehaviour
{
    private MovementBehaviour movementBehaviour;
    private EngineBehaviour engineBehaviour;

    private void Awake()
    {
        movementBehaviour = GetComponent<MovementBehaviour>();
        engineBehaviour = GetComponent<EngineBehaviour>();
    }

    private void Start()
    {
        engineBehaviour.Toggle(true);
    }

    private void FixedUpdate()
    {
        movementBehaviour.Move(transform.up * -1);
    }
}