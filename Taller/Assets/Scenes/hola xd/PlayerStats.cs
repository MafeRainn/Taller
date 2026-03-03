using UnityEngine;


public class PlayerStats : MonoBehaviour
{
    [Header("Health Settings")]
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth = 100f;

    [Header("Speed Settings")]
    [SerializeField] private float baseSpeed = 5f;
    private float speedMultiplier = 1f;

    [Header("Shield")]
    [SerializeField] private bool isShieldActive = false;

    public float CurrentHealth => currentHealth;
    public float MaxHealth => maxHealth;
    public float CurrentSpeed => baseSpeed * speedMultiplier;
    public bool IsShieldActive => isShieldActive;

    

    public void Heal(float amount)
    {
        if (amount <= 0f) 
       
        return;

        currentHealth += amount;

        if (currentHealth > maxHealth)
            currentHealth = maxHealth;
    }

    public void SetSpeedMultiplier(float multiplier)
    {
        if (multiplier <= 0f) 
        messageText.text = "Ingrese un valor válido";
        return;

        speedMultiplier = multiplier;
        //CurrentSpeed
        return;
    }

    public void SetShield(bool active)
    {
        isShieldActive = active;
    }
}