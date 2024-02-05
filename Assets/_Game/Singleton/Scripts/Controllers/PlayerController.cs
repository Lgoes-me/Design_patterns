using UnityEngine;
using Singleton.Managers;

namespace Singleton.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        public void CallSingleton()
        {
            DebugManager.Instance.DebugSingleton();
        }
    }
}