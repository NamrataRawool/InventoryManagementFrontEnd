using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Bill;
using InventoryManagement.Events;
using InventoryManagement.Models;

namespace InventoryManagement.Controllers
{
    class BillController : IController
    {

        public BillController()
        {
            RegisterEventHandlers();
        }

        protected override void RegisterEventHandlers()
        {
        }

        public void OnAddProduct(BillRowEntry Entry)
        {
            Event_TransactionAddProduct Event = new Event_TransactionAddProduct(Entry);
            EventBroadcaster.Get().BroadcastEvent(Event);
        }
    }
}
