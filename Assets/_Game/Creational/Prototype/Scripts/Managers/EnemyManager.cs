using Prototype.Controllers;
using Prototype.Domain;
using UnityEngine;

namespace Prototype.Managers
{
    public class EnemyManager : MonoBehaviour
    {
        [field: SerializeField]
        private EnemyController EnemyController { get; set; }
        private Enemy Enemy { get; set; }
        
        private void Start()
        {
            Enemy = new Enemy("Inimigo", 100);
        }

        public void CreateEnemy()
        {
            var enemy = Enemy.Clone();
            EnemyController.Init(enemy);
        }
    }
}