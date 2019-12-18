using InventoryManagement.Broadcaster;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.UI.UserControls;

namespace InventoryManagement.Controllers
{
    class BillController : IController<BillControl>
    {
        public BillController(BillControl UIControl)
            : base(UIControl)
        {
        }

        public void OnAddProduct(BillRowEntry Entry)
        {
            Event_TransactionAddProduct Event = new Event_TransactionAddProduct(Entry);
            EventBroadcaster.Get().BroadcastEvent(Event);
        }

        protected override void RegisterEvents()
        {
        }
    }
}
