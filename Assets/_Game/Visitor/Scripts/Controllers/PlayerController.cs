using UnityEngine;
using Visitor.Components;
using Visitor.PowerUps;

namespace Visitor.Controllers
{
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
}