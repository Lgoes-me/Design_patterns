using Strategy.Domain;
using Strategy.Domain.DoDamage;
using UnityEngine;

namespace Strategy.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Weapon Weapon { get; set; }

        private void Start()
        {
            EquipSword();
        }
        
        public void EquipSword()
        {
            Weapon = new Weapon(10, new Damage());
        }
        
        public void EquipFireSword()
        {
            Weapon = new Weapon(12, new FireDamage());
        }
        
        public void EquipIceSword()
        {
            Weapon = new Weapon(5, new IceDamage());
        }

        public void Attack()
        {
            Weapon.Attack();
        }
    }
}