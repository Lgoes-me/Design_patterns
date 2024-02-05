using Abstract_Factory.Domain.Factories;
using UnityEngine;

namespace Abstract_Factory.Managers
{
    public class EnemyManager : MonoBehaviour
    {
        private EnemyFactory EnemyFactory { get; set; }
        
        private void Start()
        {
            EnemyFactory = new EnemyFactory();
        }

        public void CreateEnemy()
        {
            var enemy = EnemyFactory.CreateEnemy();
            enemy.DebugEnemy();
        }
    }
}