using System;
using UnityEngine;

[RequireComponent(typeof(SpawnBehaviour), typeof(DestroyBehaviour))]
public class HealthBehaviour : MonoBehaviour, IDamageable
{
    [SerializeField] protected HealthData healthData;
    [SerializeField] private GameObject damageEffectPrefab;
    [SerializeField] private GameObject explosionPrefab;

    protected int currentHealth;
    protected SpawnBehaviour spawnBehaviour;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        spawnBehaviour = GetComponent<SpawnBehaviour>();
        destroyBehaviour = GetComponent<DestroyBehaviour>();

        currentHealth = healthData.Health;
    }

    public virtual void TakeDamage(int amount)
    {
        currentHealth = Math.Max(0, currentHealth - amount);

        spawnBehaviour.Spawn(damageEffectPrefab, transform.position, transform.rotation);

        if (currentHealth == 0)
        {
            Die();
        }
    }

    private void Die()
    {
        spawnBehaviour.Spawn(explosionPrefab, transform.position, transform.rotation);

        destroyBehaviour.Destroy();
    }
}