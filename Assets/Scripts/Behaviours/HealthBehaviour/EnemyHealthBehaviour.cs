using UnityEngine;

public class EnemyHealthBehaviour : HealthBehaviour
{
    [SerializeField] private float damageMultiplier;

    public override void TakeDamage(int amount)
    {
        base.TakeDamage(Mathf.RoundToInt(amount * damageMultiplier));
    }
}