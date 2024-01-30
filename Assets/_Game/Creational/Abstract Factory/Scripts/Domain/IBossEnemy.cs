using UnityEngine;

namespace Abstract_Factory.Domain
{
    public interface IBossEnemy
    {
        void DebugBossEnemy();
    }
    
    public class Orc : IBossEnemy
    {
        public void DebugBossEnemy()
        {
            Debug.Log("HobGoblin");
        }
    }
    
    public class Knight : IBossEnemy
    {
        public void DebugBossEnemy()
        {
            Debug.Log("Knight");
        }
    }
    
    public class Zombie : IBossEnemy
    {
        public void DebugBossEnemy()
        {
            Debug.Log("Zombie");
        }
    }
}