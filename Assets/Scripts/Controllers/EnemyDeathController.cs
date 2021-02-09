using UnityEngine;

[RequireComponent(typeof(EnemyHealthBehaviour), typeof(AddScoreBehaviour))]
public class EnemyDeathController : MonoBehaviour
{
    private EnemyHealthBehaviour enemyHealthBehaviour;
    private AddScoreBehaviour addScoreBehaviour;

    private void Awake()
    {
        enemyHealthBehaviour = GetComponent<EnemyHealthBehaviour>();
        addScoreBehaviour = GetComponent<AddScoreBehaviour>();
    }

    private void OnEnable()
    {
        enemyHealthBehaviour.OnEnemyDeath += EnemyHealthBehaviour_OnEnemyDeath;
    }

    private void OnDestroy()
    {
        enemyHealthBehaviour.OnEnemyDeath -= EnemyHealthBehaviour_OnEnemyDeath;
    }

    private void EnemyHealthBehaviour_OnEnemyDeath()
    {
        addScoreBehaviour.AddScore();
    }
}