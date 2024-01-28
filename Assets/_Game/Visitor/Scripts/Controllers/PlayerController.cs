using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] private HealthComponent HealthComponent { get; set; }
    [field: SerializeField] private ManaComponent ManaComponent { get; set; }

    public void ReceivePowerUp(BasePowerUp powerUp)
    {
        HealthComponent.Accept(powerUp);
        ManaComponent.Accept(powerUp);
    }
}