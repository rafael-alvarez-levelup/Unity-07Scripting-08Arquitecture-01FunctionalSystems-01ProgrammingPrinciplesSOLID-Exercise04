using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Modularize (SRP).

/// <summary>
/// Manages the instantiation of enemies.
/// </summary>
[RequireComponent(typeof(SpawnBehaviour))]
public class SpawnController : MonoBehaviour
{
    #region Private Fields

    [SerializeField] private List<WaveData> waves = new List<WaveData>();
    [SerializeField] private List<Transform> spawnPoints = new List<Transform>();
    [SerializeField] private float delay;

    private SpawnBehaviour spawnBehaviour;

    #endregion

    #region Unity Methods

    private void Awake()
    {
        spawnBehaviour = GetComponent<SpawnBehaviour>();
    }

    private void Start()
    {
        StartCoroutine(SpawnWaves());
    }

    #endregion

    #region My Methods

    private IEnumerator SpawnWaves()
    {
        WaitForSeconds waveDelay = new WaitForSeconds(delay);

        foreach (WaveData wave in waves)
        {
            WaitForSeconds memberDelay = new WaitForSeconds(wave.Delay);

            foreach (GameObject member in wave.Sequence)
            {
                Transform pointToSpawn = spawnPoints[Utilities.GetRandomIndex(0, spawnPoints.Count)];

                spawnBehaviour.Spawn(member, pointToSpawn.position);

                yield return memberDelay;
            }

            yield return waveDelay;
        }
    }

    #endregion
}