using UnityEngine;

namespace Builder.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        [field: SerializeField] public string Name { get; internal set; }
        [field: SerializeField] public int MaxHealth { get; internal set; }
        [field: SerializeField] public int Damage { get; internal set; }
        [field: SerializeField] public float Speed { get; internal set; }
    }

    public class EnemyBuilder
    {
        private EnemyController EnemyController { get; set; }

        public EnemyBuilder(EnemyController enemyController)
        {
            EnemyController = enemyController;
        }

        public EnemyBuilder Name(string name)
        {
            EnemyController.Name = name;
            return this;
        }

        public EnemyBuilder MaxHealth(int maxHealth)
        {
            EnemyController.MaxHealth = maxHealth;
            return this;
        }

        public EnemyBuilder Damage(int damage)
        {
            EnemyController.Damage = damage;
            return this;
        }

        public EnemyBuilder Speed(float speed)
        {
            EnemyController.Speed = speed;
            return this;
        }

        public EnemyController Build()
        {
            return EnemyController;
        }
    }

    public class EnemyDirector
    {
        public EnemyController BuildDefaultEnemy(EnemyController enemyController)
        {
            return new EnemyBuilder(enemyController)
                .Name("DefaultEnemy")
                .MaxHealth(1000)
                .Damage(10)
                .Speed(100)
                .Build();
        }
    }
}