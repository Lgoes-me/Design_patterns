using Factory.Domain;
using UnityEngine;

namespace Factory.Manager
{
    public class EnemyManager : MonoBehaviour
    {
        private EnemyFactory EnemyFactory { get; set; }
        
        private void Start()
        {
            EnemyFactory = new GoblinFactory();
        }

        public void CreateEnemy()
        {
            var enemy = EnemyFactory.CreateEnemy();
            enemy.DebugEnemy();
        }
    }
}