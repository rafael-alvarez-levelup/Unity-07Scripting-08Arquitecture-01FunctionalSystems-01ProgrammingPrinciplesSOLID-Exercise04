using UnityEngine;

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