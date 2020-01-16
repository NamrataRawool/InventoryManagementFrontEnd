using System;
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
                    var ev = e.Cast<Event_NewEntryAdded>();
                    if (ev.GetEntityType() == DBEntityType.CUSTOMER)
                        AddCustomerToTable(ev.GetID());
                    break;
            }
        }

        private void AddCustomerToTable(int customerID)
        {
            CustomerGet customer = DataService.GetCustomerDataController().Get(customerID);
            m_Controller.AddCustomerToTable(customer);
        }

    }

}
