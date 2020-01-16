using InventoryManagement.Controllers;
using InventoryManagement.Controllers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Services.Data;

namespace InventoryManagement.EventHandlers.Transaction
{
    public class EventHandler_Transaction : IEventHandler<NewTransactionController>
    {
        public EventHandler_Transaction(NewTransactionController Controller)
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            switch(type)
            {
                case EventType.UI_Transaction_AddProduct:
                    var evnt = e.Cast<Event_TransactionAddProduct>();
                    m_Controller.AddProductRowToTable(evnt.GetBillRowEntry());
                    break;

                case EventType.NewEntryAdded:
                    HandleNewEntryAddedEvent(e.Cast<Event_NewEntryAdded>());
                    break;
            }
        }

        private void HandleNewEntryAddedEvent(Event_NewEntryAdded e)
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
