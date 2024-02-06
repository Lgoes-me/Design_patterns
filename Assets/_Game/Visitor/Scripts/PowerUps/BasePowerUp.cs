using UnityEngine;
using Visitor.Interfaces;

namespace Visitor.PowerUps
{
    public abstract class BasePowerUp : ScriptableObject, IVisitor
    {
        public abstract void Visit(IVisitable visitable);
    }
}