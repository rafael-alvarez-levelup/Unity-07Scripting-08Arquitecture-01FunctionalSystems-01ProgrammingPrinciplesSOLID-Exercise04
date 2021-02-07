using UnityEngine;

public class SpawnDamageEffectParticlesBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject damageEffectPrefab;

    public void SpawnDamageEffectParticles()
    {
        // TODO: Pooling.
        Instantiate(damageEffectPrefab, transform.position, transform.rotation);
    }
}