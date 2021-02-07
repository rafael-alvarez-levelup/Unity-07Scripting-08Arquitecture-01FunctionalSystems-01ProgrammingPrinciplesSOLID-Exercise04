using System;

public class PlayerHealthBehaviour : HealthBehaviour, IHealable
{
    private SpawnDamageEffectParticlesBehaviour spawnDamageEffectParticlesBehaviour;

    protected override void Awake()
    {
        spawnDamageEffectParticlesBehaviour = GetComponent<SpawnDamageEffectParticlesBehaviour>();

        base.Awake();
    }

    public override void TakeDamage(int amount)
    {
        spawnDamageEffectParticlesBehaviour.SpawnDamageEffectParticles();

        base.TakeDamage(amount);
    }

    public void Heal(int amount)
    {
        currentHealth = Math.Min(currentHealth + amount, healthData.Health);
    }
}