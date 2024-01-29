namespace Factory.Domain
{
    public abstract class EnemyFactory
    {
        public abstract IEnemy CreateEnemy();
    }

    public class GoblinFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Goblin();
        }
    }

    public class BatFactory : EnemyFactory
    {
        public override IEnemy CreateEnemy()
        {
            return new Bat();
        }
    }
}