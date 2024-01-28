using UnityEngine;

public class HealthComponent : BasePlayerComponent
{
    [field: SerializeField] private int CurrentHealth { get; set; }
    [field: SerializeField] private int MaxHealth { get; set; }

    public void ReceiveHealth(int health)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth + health, 0, MaxHealth);
    }
}
