using InventoryManagement.EventHandlers.Bill;
using InventoryManagement.Events;

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
            RegisterEvent(EventType.UI_Transaction_AddProduct, new EH_TransactionAddProduct(this));
        }

    }
}
