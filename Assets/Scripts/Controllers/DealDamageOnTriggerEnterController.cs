using UnityEngine;

[RequireComponent(typeof(DealDamageBehaviour))]
public class DealDamageOnTriggerEnterController : MonoBehaviour
{
    [SerializeField] private LayerMask triggerMask;

    private DealDamageBehaviour dealDamageBehaviour;

    private void Awake()
    {
        dealDamageBehaviour = GetComponent<DealDamageBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Utilities.ContainsLayer(triggerMask, other.gameObject.layer))
        {
            IDamageable target = other.GetComponent<IDamageable>();

            if (target != null)
            {
                dealDamageBehaviour.DealDamage(target);
            }
        }
    }
}