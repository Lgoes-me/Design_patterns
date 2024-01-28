using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    public abstract class BasePowerUp : IVisitor
    {
        public abstract void Visit(IVisitable visitable);
    }
}