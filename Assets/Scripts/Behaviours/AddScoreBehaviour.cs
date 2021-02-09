using UnityEngine;

public class AddScoreBehaviour : MonoBehaviour
{
    [SerializeField] private int amount;

    public void AddScore()
    {
        ScoreSingleton.Instance.AddScore(amount);
    }
}