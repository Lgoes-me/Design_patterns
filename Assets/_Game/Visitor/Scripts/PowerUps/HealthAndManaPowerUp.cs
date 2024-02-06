using UnityEngine;
using Visitor.Components;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    [CreateAssetMenu]
    public class HealthAndManaPowerUp : BasePowerUp
    {
        [field: SerializeField]
        private int Health { get; set; }
        
        [field: SerializeField]
        private int Mana { get; set; }

        public override void Visit(IVisitable visitable)
        {
            switch (visitable)
            {
                case HealthComponent healthComponent:
                    Visit(healthComponent);
                    break;
                case ManaComponent manaComponent:
                    Visit(manaComponent);
                    break;
            }
        }

        private void Visit(HealthComponent healthComponent)
        {
            healthComponent.ReceiveHealth(Health);
        }

        private void Visit(ManaComponent manaComponent)
        {
            manaComponent.ReceiveMana(Mana);
        }
    }
}