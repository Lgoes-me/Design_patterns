using UnityEngine;

namespace Abstract_Factory.Domain
{
    public interface IFlyingEnemy
    {
        void DebugFlyingEnemy();
    }
    
    public class Bat : IFlyingEnemy
    {
        public void DebugFlyingEnemy()
        {
            Debug.Log("Bat");
        }
    }
    
    public class Eagle : IFlyingEnemy
    {
        public void DebugFlyingEnemy()
        {
            Debug.Log("Eagle");
        }
    }
    
    public class Ghost : IFlyingEnemy
    {
        public void DebugFlyingEnemy()
        {
            Debug.Log("Ghost");
        }
    }
}