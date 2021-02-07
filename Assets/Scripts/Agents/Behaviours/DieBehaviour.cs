using UnityEngine;

public class DieBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    public void Die()
    {
        SpawnExplosionParticles();

        destroyBehaviour.Destroy();
    }

    private void SpawnExplosionParticles()
    {
        // TODO: Pooling.
        Instantiate(explosionPrefab, transform.position, transform.rotation);
    }
}