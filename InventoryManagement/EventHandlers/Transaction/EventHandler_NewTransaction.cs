using InventoryManagement.Controllers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Services.Data;

namespace InventoryManagement.EventHandlers.Transaction
{
    public class EventHandler_NewTransaction : IEventHandler<NewTransactionController>
    {
        public EventHandler_NewTransaction(NewTransactionController Controller)
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
            var updatedEntryType = e.GetEntityType();
            if (updatedEntryType == DBEntityType.PRODUCT)
            {
                m_Controller.InitializProductNameSearchBoxData();
            }
            else if (updatedEntryType == DBEntityType.CUSTOMER)
            {
                m_Controller.InitializeCustomerMobileNumberSearchBoxData();
                m_Controller.InitializeCustomerNameSearchBoxData();
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            var addedEntityType = e.GetEntityType();
            if(addedEntityType == DBEntityType.CUSTOMER)
            {
                var customer = DataService.GetCustomerDataController().Get(e.GetID());
                m_Controller.AddCustomerNameToSearchBox(customer.Name);
            }
        }

    }
}
