using UnityEngine;

namespace Abstract_Factory.Domain
{
    public interface IEnemy
    {
        void DebugEnemy();
    }
    
    public class Goblin : IEnemy
    {
        public void DebugEnemy()
        {
            Debug.Log("Goblin");
        }
    }
    
    public class Soldier : IEnemy
    {
        public void DebugEnemy()
        {
            Debug.Log("Soldier");
        }
    }
    
    public class Skeleton : IEnemy
    {
        public void DebugEnemy()
        {
            Debug.Log("Skeleton");
        }
    }
}