using UnityEngine;

public class SpawnBehaviour : MonoBehaviour
{
    public void Spawn(GameObject gameObject)
    {
        Spawn(gameObject, Vector3.zero);
    }

    public void Spawn(GameObject gameObject, Vector3 position)
    {
        Spawn(gameObject, position, Quaternion.identity);
    }

    public void Spawn(GameObject gameObject, Vector3 position, Quaternion rotation)
    {
        Instantiate(gameObject, position, rotation);
    }
}