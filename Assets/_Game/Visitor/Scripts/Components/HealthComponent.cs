using UnityEngine;
using Visitor.Interfaces;

namespace Visitor.Components
{
    public class HealthComponent : MonoBehaviour, IVisitable
    {
        [field: SerializeField] private int CurrentHealth { get; set; }
        [field: SerializeField] private int MaxHealth { get; set; }

        public void ReceiveHealth(int health)
        {
            CurrentHealth = Mathf.Clamp(CurrentHealth + health, 0, MaxHealth);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}