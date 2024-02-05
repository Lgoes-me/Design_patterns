using System.Collections.Generic;
using Observer.Controllers;
using UnityEngine;

namespace Observer.Managers
{
    public class NotificationManager : MonoBehaviour
    {
        private HashSet<INotificationListener> Listeners { get; set; }

        private void Awake()
        {
            Listeners = new HashSet<INotificationListener>();
        }

        public void SubscribeListener(INotificationListener listener)
        {
            Listeners.Add(listener);
        }
        
        public void UnsubscribeListener(INotificationListener listener)
        {
            Listeners.Remove(listener);
        }

        public void NotifyAll()
        {
            foreach (var listener in Listeners)
            {
                listener.Notify();
            }
        }
    }
}