using Visitor.Components;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    public class HealthPowerUp : BasePowerUp
    {
        private int Health { get; }

        public HealthPowerUp(int health)
        {
            Health = health;
        }

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