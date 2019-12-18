﻿using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers;
using InventoryManagement.Events;
using InventoryManagement.Listeners;
using System.Collections.Generic;
using System.Diagnostics;

namespace InventoryManagement.Controllers
{

    public class IController<UICONTROL> : IController
    {
        protected IController(UICONTROL UIControl)
        {
            m_UIControl = UIControl;
        }

        protected UICONTROL m_UIControl;
    }

    public class IController : IEventListener
    {

        private List<EventType> m_RegisteredEvents;
        private IEventHandler m_Handler;

        protected IController()
        {
            m_RegisteredEvents = new List<EventType>();
        }

        protected void RegisterEvent(EventType type)
        {
            m_RegisteredEvents.Add(type);

            // register with the Broadcaster
            EventBroadcaster.Get().RegisterListener(type, this);
        }

        protected void SetEventHandler(IEventHandler Handler)
        {
            m_Handler = Handler;
        }

        public override void OnEvent(IEvent e)
        {
            m_Handler.OnEvent(e);
        }

    }   
}
