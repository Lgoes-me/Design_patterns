namespace Abstract_Factory.Domain.Factories
{
    public class MansionEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Skeleton();
        }

        public IFlyingEnemy CreateFlyingEnemy()
        {
            return new Ghost();
        }

        public IBossEnemy CreateBoss()
        {
            return new Zombie();
        }
    }
}