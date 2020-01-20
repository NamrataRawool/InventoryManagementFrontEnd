using InventoryManagement.Controllers.Purchase;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Purchase
{
    public class EventHandler_NewPurchase : IEventHandler<NewPurchaseController>
    {
        public EventHandler_NewPurchase(NewPurchaseController Controller) 
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();

            switch (type)
            {
                case EventType.NewEntryAdded:
                    HandleEvent_NewEntryEvent(e.Cast<Event_NewEntryAdded>());
                    break;
            }
        }

        private void HandleEvent_NewEntryEvent(Event_NewEntryAdded e)
        {
            var entity = e.GetEntityType();
            int id = e.GetID();
            if (entity == DBEntityType.VENDOR)
            {
                m_Controller.OnNewVendorAdded(id);
            }
            else if (entity == DBEntityType.PRODUCT)
            {
                m_Controller.OnNewProductAdded(id);
            }
        }

    }
}
