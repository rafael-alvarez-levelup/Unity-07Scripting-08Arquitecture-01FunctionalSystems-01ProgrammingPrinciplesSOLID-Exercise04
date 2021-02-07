using System;
using UnityEngine;

[RequireComponent(typeof(DieBehaviour))]
public class HealthBehaviour : MonoBehaviour
{
    [SerializeField] protected HealthData healthData;

    protected int currentHealth;

    private DieBehaviour dieBehaviour;

    protected virtual void Awake()
    {
        dieBehaviour = GetComponent<DieBehaviour>();

        currentHealth = healthData.Health;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth = Math.Max(0, currentHealth - amount);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        dieBehaviour.Die();
    }
}