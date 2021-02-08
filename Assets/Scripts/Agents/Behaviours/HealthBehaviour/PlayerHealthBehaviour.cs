using System;
using UnityEngine;

public class PlayerHealthBehaviour : HealthBehaviour, IHealable
{
    [SerializeField] private GameObject healEffectPrefab;

    public void Heal(int amount)
    {
        if( currentHealth < healthData.Health)
        {
            currentHealth = Math.Min(currentHealth + amount, healthData.Health);

            spawnBehaviour.Spawn(healEffectPrefab, transform.position, transform.rotation);
        }
    }
}