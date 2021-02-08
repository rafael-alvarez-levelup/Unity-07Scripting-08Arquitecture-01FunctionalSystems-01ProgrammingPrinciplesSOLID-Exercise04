using UnityEngine;

// TODO: OnTriggerEnter event handler (game object parameter).
// Subscribe to that event and destroy / deal damage / heal?

[RequireComponent(typeof(DestroyBehaviour))]
public class DestroyOnTriggerEnterController : MonoBehaviour
{
    [SerializeField] private LayerMask triggerMask;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Utilities.ContainsLayer(triggerMask, other.gameObject.layer))
        {
            destroyBehaviour.Destroy();
        }
    }
}