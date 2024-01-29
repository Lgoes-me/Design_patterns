using UnityEngine;

namespace Factory.Domain
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
    
    public class Bat : IEnemy
    {
        public void DebugEnemy()
        {
            Debug.Log("Bat");
        }
    }
}