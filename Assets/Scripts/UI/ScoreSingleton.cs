using UnityEngine;

[RequireComponent(typeof(UpdateScoreBehaviour))]
public class ScoreSingleton : MonoBehaviour
{
    public static ScoreSingleton Instance { get; private set; }

    private UpdateScoreBehaviour updateScoreBehaviour;
    private int score;

    private void Awake()
    {
        Instance = this;

        updateScoreBehaviour = GetComponent<UpdateScoreBehaviour>();
    }

    private void Start()
    {
        updateScoreBehaviour.UpdateScore(score);
    }

    public void AddScore(int amount)
    {
        score += amount;

        updateScoreBehaviour.UpdateScore(score);
    }
}