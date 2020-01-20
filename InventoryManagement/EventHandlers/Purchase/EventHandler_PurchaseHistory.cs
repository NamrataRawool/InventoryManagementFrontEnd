using InventoryManagement.Controllers.Purchase;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Purchase
{
    public class EventHandler_PurchaseHistory : IEventHandler<PurchaseHistoryController>
    {
        public EventHandler_PurchaseHistory(PurchaseHistoryController Controller) 
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();

            switch(type)
            {
                case EventType.NewEntryAdded:
                    HandleEvent_NewEntryAdded(e.Cast<Event_NewEntryAdded>());
                    break;
                case EventType.EntryUpdated:
                    HandleEvent_EntryUpdated(e.Cast<Event_EntryUpdated>());
                    break;
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.VENDOR)
            {
                VendorGet vendor = DataService.GetVendorDataController().Get(e.GetID());
                m_Controller.AddToComboBox_VendorName(vendor.CompanyName);
            }
        }

        private void HandleEvent_EntryUpdated(Event_EntryUpdated e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.VENDOR)
            {
                m_Controller.InitializeComboBox_VendorName();
            }
        }
    }
}
