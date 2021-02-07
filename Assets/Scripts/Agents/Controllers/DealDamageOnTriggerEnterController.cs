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
            HealthBehaviour healthBehaviour = other.GetComponent<HealthBehaviour>();

            if (healthBehaviour != null)
            {
                dealDamageBehaviour.DealDamage(healthBehaviour);
            }
        }
    }
}