using UnityEngine;

namespace Strategy.Domain.DoDamage
{
    public class IceDamage : IDoDamage
    {
        public void DoDamage(int damage)
        {
            Debug.Log($"Did {damage} ice damage");
        }
    }
}