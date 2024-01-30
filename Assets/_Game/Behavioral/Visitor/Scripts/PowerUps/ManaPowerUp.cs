using Visitor.Components;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    public class ManaPowerUp : BasePowerUp
    {
        private int Mana { get; }

        public ManaPowerUp(int mana)
        {
            Mana = mana;
        }

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