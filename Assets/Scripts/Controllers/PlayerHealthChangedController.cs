using UnityEngine;

[RequireComponent(typeof(PlayerHealthBehaviour))]
public class PlayerHealthChangedController : MonoBehaviour
{
    private PlayerHealthBehaviour playerHealthBehaviour;

    private void Awake()
    {
        playerHealthBehaviour = GetComponent<PlayerHealthBehaviour>();
    }

    private void OnEnable()
    {
        playerHealthBehaviour.OnPlayerHealthChanged += PlayerHealthBehaviour_OnPlayerHealthChanged;
    }

    private void OnDestroy()
    {
        playerHealthBehaviour.OnPlayerHealthChanged -= PlayerHealthBehaviour_OnPlayerHealthChanged;
    }

    private void PlayerHealthBehaviour_OnPlayerHealthChanged(int currentHealth, int maxHealth)
    {
        LifebarSingleton.Instance.UpdateLifebar(currentHealth, maxHealth);
    }
}