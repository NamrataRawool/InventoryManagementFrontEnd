using InventoryManagement.Controllers;
using InventoryManagement.Events;

namespace InventoryManagement.EventHandlers.Transaction
{
    public class EventHandler_Transaction : IEventHandler<TransactionController>
    {
        public EventHandler_Transaction(TransactionController Controller)
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();
            if (type == EventType.UI_Transaction_AddProduct)
            {
                var evnt = (Event_TransactionAddProduct)e;
                m_Controller.AddProductRowToTable(evnt.GetBillRowEntry());
            }
        }
    }
}
