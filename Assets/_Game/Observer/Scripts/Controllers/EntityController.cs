using Observer.Managers;
using UnityEngine;

namespace Observer.Controllers
{
    public class EntityController : MonoBehaviour, INotificationListener
    {
        private NotificationManager NotificationManager { get; set; }

        private void Start()
        {
            //this dependency should be better injected
            NotificationManager = FindObjectOfType<NotificationManager>();
            NotificationManager.SubscribeListener(this);
        }

        public void Notify()
        {
            Debug.Log($"Notified {gameObject.name}");
        }

        private void OnDestroy()
        {
            NotificationManager.UnsubscribeListener(this);
        }
    }
}