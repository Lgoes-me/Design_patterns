namespace Abstract_Factory.Domain.Factories
{
    public class SwampEnemyFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Goblin();
        }

        public IFlyingEnemy CreateFlyingEnemy()
        {
            return new Bat();
        }

        public IBossEnemy CreateBoss()
        {
            return new Orc();
        }
    }
}