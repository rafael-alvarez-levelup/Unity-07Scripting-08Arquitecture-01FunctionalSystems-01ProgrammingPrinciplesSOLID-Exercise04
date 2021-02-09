using UnityEngine;
using UnityEngine.UI;

public class LifebarSingleton : MonoBehaviour
{
    public static LifebarSingleton Instance { get; private set; }

    [SerializeField] private Image fillImage;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateLifebar(int currentHealth, int maxHealth)
    {
        fillImage.fillAmount = (float)currentHealth / maxHealth;
    }
}