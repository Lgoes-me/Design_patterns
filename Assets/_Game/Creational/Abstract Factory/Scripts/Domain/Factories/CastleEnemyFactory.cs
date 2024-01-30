namespace Abstract_Factory.Domain.Factories
{
    public class CastleEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Soldier();
        }

        public IFlyingEnemy CreateFlyingEnemy()
        {
            return new Eagle();
        }

        public IBossEnemy CreateBoss()
        {
            return new Knight();
        }
    }
}