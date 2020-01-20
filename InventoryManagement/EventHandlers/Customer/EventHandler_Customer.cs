using InventoryManagement.Events;
using InventoryManagement.Controllers.Customer;
using InventoryManagement.Events.Common;
using InventoryManagement.Services.Data;
using InventoryManagement.Models;

namespace InventoryManagement.EventHandlers.Customer
{

    public class EventHandler_Customer : IEventHandler<CustomerController>
    {
        public EventHandler_Customer(CustomerController Controller)
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            switch (type)
            {
                case EventType.NewEntryAdded:
                    HandleEvent_NewEntryAdded(e.Cast<Event_NewEntryAdded>());
                    break;
                case EventType.EntryUpdated:
                    HandleEvent_EntryUpdated(e.Cast<Event_EntryUpdated>());
                    break;
            }
        }

        private void HandleEvent_EntryUpdated(Event_EntryUpdated e)
        {
            DBEntityType entityType = e.GetEntityType();
            if (entityType == DBEntityType.CUSTOMER)
            {
                CustomerGet customer = DataService.GetCustomerDataController().Get(e.GetID());
                m_Controller.UpdateCustomerInTable(customer);
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();
            if(entityType == DBEntityType.CUSTOMER)
            {
                int customerID = e.GetID();
                CustomerGet customer = DataService.GetCustomerDataController().Get(customerID);
                m_Controller.AddCustomerToTable(customer);
            }
        }
        
    }

}
