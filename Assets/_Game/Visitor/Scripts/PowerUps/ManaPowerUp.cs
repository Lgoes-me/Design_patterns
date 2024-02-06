using UnityEngine;
using Visitor.Components;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    [CreateAssetMenu]
    public class ManaPowerUp : BasePowerUp
    {
        [field: SerializeField]
        private int Mana { get; set; }

        public override void Visit(IVisitable visitable)
        {
            switch (visitable)
            {
                case ManaComponent manaComponent:
                    Visit(manaComponent);
                    break;
            }
        }

        private void Visit(ManaComponent manaComponent)
        {
            manaComponent.ReceiveMana(Mana);
        }
    }
}