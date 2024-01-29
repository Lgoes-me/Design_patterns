using Factory.Controllers;
using Factory.Domain;
using UnityEngine;

namespace Factory.Manager
{
    public class EnemyManager : MonoBehaviour
    {
        [field: SerializeField]
        private EnemyController EnemyController { get; set; }
        private EnemyFactory EnemyFactory { get; set; }
        
        private void Start()
        {
            EnemyFactory = new GoblinFactory();
        }

        public void CreateEnemy()
        {
            var enemy = EnemyFactory.CreateEnemy();
            EnemyController.Init(enemy);
        }
    }
}