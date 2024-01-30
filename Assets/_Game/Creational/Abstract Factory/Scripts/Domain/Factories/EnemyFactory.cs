namespace Abstract_Factory.Domain.Factories
{
    public class EnemyFactory : IEnemyFactory
    {
        private IEnemyFactory Factory { get; set; }

        public EnemyFactory()
        {
            Factory = new SwampEnemyFactory();
        }

        public IEnemy CreateEnemy()
        {
            return Factory.CreateEnemy();
        }

        public IFlyingEnemy CreateFlyingEnemy()
        {
            return Factory.CreateFlyingEnemy();
        }

        public IBossEnemy CreateBoss()
        {
            return Factory.CreateBoss();
        }
    }

    public interface IEnemyFactory
    {
        IEnemy CreateEnemy();
        IFlyingEnemy CreateFlyingEnemy();
        IBossEnemy CreateBoss();
    }
}