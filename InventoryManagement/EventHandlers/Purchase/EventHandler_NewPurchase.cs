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

            if (type == EventType.NewEntryAdded)
            {
                var evnt = e.Cast<Event_NewEntryAdded>();
                var entity = evnt.GetEntityType();
                int id = evnt.GetID();
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
}
