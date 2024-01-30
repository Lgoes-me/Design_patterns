using UnityEngine;

namespace Strategy.Domain.DoDamage
{
    public class FireDamage : IDoDamage
    {
        public void DoDamage(int damage)
        {
            Debug.Log($"Did {damage} fire damage");
        }
    }
}