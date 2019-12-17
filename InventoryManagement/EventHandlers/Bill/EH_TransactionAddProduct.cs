using InventoryManagement.Controllers;
using InventoryManagement.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Bill
{
    class EH_TransactionAddProduct : IEventHandler<BillController>
    {
        public EH_TransactionAddProduct(BillController Controller) : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            throw new NotImplementedException();
        }
    }
}
