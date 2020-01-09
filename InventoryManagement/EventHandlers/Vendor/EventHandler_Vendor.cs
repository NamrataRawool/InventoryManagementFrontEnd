using InventoryManagement.Controllers.Vendor;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Misc.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Vendor
{
    class EventHandler_Vendor : IEventHandler<VendorController>
    {
        public EventHandler_Vendor(VendorController Controller)
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();

            switch (type)
            {
                case EventType.NewEntryAdded:
                    var ev = e.Cast<Event_NewEntryAdded>();
                    if(ev.GetEntityType() == DBEntityType.VENDOR)
                        AddVendorToTable(ev.GetID());
                    break;
            }
        }

        private void AddVendorToTable(int vendorID)
        {
            var vendor = DataService.Get().GetVendorDataController().Get(vendorID);
            if (vendor == null)
            {
                Assert.Do("This should not have happened!");
                return;
            }

            m_Controller.AddVendorToTable(vendor);
            m_Controller.RefreshTable();

            m_Controller.AddProductToAutoSearchBox(vendor.CompanyName);
        }

    }
}
