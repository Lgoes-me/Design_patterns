using UnityEngine;
using Visitor.Interfaces;

namespace Visitor.Components
{
    public class ManaComponent : MonoBehaviour, IVisitable
    {
        [field: SerializeField] private int Mana { get; set; }

        public void ReceiveMana(int mana)
        {
            Mana += mana;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}