using UnityEngine;

namespace Singleton.Managers
{
    public class DebugManager : Singleton<DebugManager>
    {

        public void DebugSingleton()
        {
            Debug.Log("DebugSingleton");
        }
    }
}