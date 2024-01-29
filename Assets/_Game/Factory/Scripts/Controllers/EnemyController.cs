using Factory.Domain;
using UnityEngine;

namespace Factory.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        private IEnemy Enemy { get; set; }
        
        public void Init(IEnemy enemy)
        {
            Enemy = enemy;
            Enemy.DebugEnemy();
        }
    }
}