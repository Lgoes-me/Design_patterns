using Builder.Controllers;
using UnityEngine;

namespace Builder.Managers
{
    public class EnemyManager : MonoBehaviour
    {
        [field: SerializeField] private EnemyController EnemyControllerPrefab { get; set; }

        public void CreateNewEnemyWithBuilder()
        {
            var defaultEnemy = Instantiate(EnemyControllerPrefab);
            
            new EnemyBuilder(defaultEnemy)
                .Name("Enemy")
                .MaxHealth(1000)
                .Damage(10)
                .Speed(100)
                .Build();
        }
        
        public void CreateDefaultEnemyDirector()
        {
            var defaultEnemy = Instantiate(EnemyControllerPrefab);
            new EnemyDirector().BuildDefaultEnemy(defaultEnemy);
        }
    }
}