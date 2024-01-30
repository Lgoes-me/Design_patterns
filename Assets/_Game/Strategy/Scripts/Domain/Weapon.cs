using Strategy.Domain.DoDamage;

namespace Strategy.Domain
{
    public class Weapon
    {
        private int Damage { get; }
        private IDoDamage DoDamage { get; }

        public Weapon(int damage, IDoDamage doDamage)
        {
            Damage = damage;
            DoDamage = doDamage;
        }

        public void Attack()
        {
            DoDamage.DoDamage(Damage);
        }
    }
}