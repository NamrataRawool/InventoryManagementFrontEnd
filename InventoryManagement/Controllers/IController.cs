using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers;
using InventoryManagement.EventHandlers.Bill;
using InventoryManagement.Events;
using InventoryManagement.Listeners;
using System.Collections.Generic;

namespace InventoryManagement.Controllers
{
    public class IController : IEventListener
    {
        protected Dictionary<EventType, IEventHandler> m_EventHandlers;

        protected IController()
        {
            m_EventHandlers = new Dictionary<EventType, IEventHandler>();
        }

        protected virtual void RegisterEventHandlers() { }

        protected void RegisterEvent(EventType type, IEventHandler handler)
        {
            if (m_EventHandlers.ContainsKey(type))
            {
                // should raise an assert
                return;
            }

            m_EventHandlers.Add(type, handler);

            // register with the Broadcaster
            EventBroadcaster.Get().RegisterListener(type, this);
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            if (!m_EventHandlers.ContainsKey(type))
            {
                // TODO: raise and assert
                return;
            }

            m_EventHandlers[type].OnEvent(e);
        }

    }   
}
