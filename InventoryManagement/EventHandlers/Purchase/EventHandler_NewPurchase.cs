using InventoryManagement.Controllers.Purchase;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Services.Misc.Assert;

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
                case EventType.EntryUpdated:
                    HandleEvent_EntryUpdated(e.Cast<Event_EntryUpdated>());
                    break;

                default:
                    Assert.Do("This Event Is Not Expected for this Handler!");
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

        private void HandleEvent_EntryUpdated(Event_EntryUpdated e)
        {
            var entity = e.GetEntityType();
            if (entity == DBEntityType.VENDOR)
            {
                m_Controller.InitializeComboBox_VendorName();
            }
            else if (entity == DBEntityType.PRODUCT)
            {
                m_Controller.InitializeComboBox_ProductName();
            }
        }

    }
}
