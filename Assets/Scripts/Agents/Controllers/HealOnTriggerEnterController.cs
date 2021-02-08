using UnityEngine;

[RequireComponent(typeof(HealBehaviour))]
public class HealOnTriggerEnterController : MonoBehaviour
{
    [SerializeField] private LayerMask triggerMask;

    private HealBehaviour healBehaviour;

    private void Awake()
    {
        healBehaviour = GetComponent<HealBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        IHealable target = other.GetComponent<IHealable>();

        if (target != null)
        {
            healBehaviour.Heal(target);
        }
    }
}