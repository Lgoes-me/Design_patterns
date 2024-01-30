using UnityEngine;

namespace Strategy.Domain.DoDamage
{
    public class Damage : IDoDamage
    {
        public void DoDamage(int damage)
        {
            Debug.Log($"Did {damage} damage");
        }
    }
}