using Prototype.Domain;
using UnityEngine;

namespace Prototype.Controllers
{
    public class EnemyController : MonoBehaviour
    {
        public void Init(Enemy enemy)
        {
            Debug.Log(enemy.Name);
            Debug.Log(enemy.Health);
        }
    }
}