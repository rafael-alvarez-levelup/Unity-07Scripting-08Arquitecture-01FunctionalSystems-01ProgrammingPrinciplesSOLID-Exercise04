using System;
using System.Collections;
using UnityEngine;

[Serializable]
public struct Wave
{
    public SpawnObject[] spawnObjects;
    public float delay;
}

[Serializable]
public struct SpawnObject
{
    public GameObject prefab;
    public int amount;
    public float delay;
}

public class SpawnControllerAlternative : MonoBehaviour
{
    [SerializeField] private Wave[] waves;

    private SpawnBehaviour spawnBehaviour;

    private void Awake()
    {
        spawnBehaviour = GetComponent<SpawnBehaviour>();
    }

    private void Start()
    {
        StartCoroutine(WavesRoutine(waves));
    }

    private IEnumerator WavesRoutine(Wave[] waves)
    {
        foreach (Wave wave in waves)
        {
            yield return WaveRoutine(wave);
        }
    }

    private IEnumerator WaveRoutine(Wave wave)
    {
        yield return new WaitForSeconds(wave.delay);

        foreach (SpawnObject spawnObject in wave.spawnObjects)
        {
            yield return SpawnObjectRoutine(spawnObject);
        }
    }

    private IEnumerator SpawnObjectRoutine(SpawnObject spawnObject)
    {
        for (int i = 0; i < spawnObject.amount; i++)
        {
            yield return new WaitForSeconds(spawnObject.delay);

            spawnBehaviour.Spawn(spawnObject.prefab);
        }
    }
}