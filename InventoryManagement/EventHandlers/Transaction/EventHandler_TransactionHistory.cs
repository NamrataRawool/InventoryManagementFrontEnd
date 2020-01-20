using InventoryManagement.Controllers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;

namespace InventoryManagement.EventHandlers.Transaction
{
    public class EventHandler_TransactionHistory : IEventHandler<TransactionHistoryController>
    {
        public EventHandler_TransactionHistory(TransactionHistoryController Controller) 
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
                m_Controller.InitializeComboBox_CustomerName();
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.CUSTOMER)
                m_Controller.InitializeComboBox_CustomerName();
        }

    }
}
