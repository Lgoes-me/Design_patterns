using UnityEngine;
using Visitor.Components;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    [CreateAssetMenu]
    public class HealthPowerUp : BasePowerUp
    {
        [field: SerializeField]
        private int Health { get; set; }
        
        public override void Visit(IVisitable visitable)
        {
            switch (visitable)
            {
                case HealthComponent healthComponent:
                    Visit(healthComponent);
                    break;
            }
        }

        private void Visit(HealthComponent healthComponent)
        {
            healthComponent.ReceiveHealth(Health);
        }
    }
}