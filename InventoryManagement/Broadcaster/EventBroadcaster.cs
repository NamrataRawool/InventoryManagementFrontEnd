using InventoryManagement.Events;
using InventoryManagement.Listeners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Broadcaster
{

    public class Singleton<T> where T : new()
    {

        protected Singleton() { }
        protected Singleton(Singleton<T> s) { }

        public static T Get()
        {
            if (m_Instance == null)
                m_Instance = new T();

            return m_Instance;
        }

        protected static T m_Instance;
    }

    public class EventBroadcaster : Singleton<EventBroadcaster>
    {
        Dictionary<EventType, List<IEventListener>> m_EventListeners;

        public EventBroadcaster()
        {
            m_EventListeners = new Dictionary<EventType, List<IEventListener>>();
        }

        public void RegisterListener(EventType type, IEventListener listener)
        {
            if (m_EventListeners.ContainsKey(type))
            {
                // add to the existing list
                m_EventListeners[type].Add(listener);
                return;
            }

            // create a new List
            m_EventListeners.Add(type, new List<IEventListener>() { listener });
        }

        public void BroadcastEvent(IEvent e)
        {
            EventType type = e.Type();

            if (!m_EventListeners.ContainsKey(type))
            {
                // TODO: raise an Assert
                return;
            }

            var Listeners = m_EventListeners[type];
            foreach (var Listener in Listeners)
            {
                if (Listener != null)
                {
                    Listener.OnEvent(e);
                }
            }

        }

    }
}
