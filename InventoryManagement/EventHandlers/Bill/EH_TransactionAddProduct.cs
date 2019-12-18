using InventoryManagement.Controllers;
using InventoryManagement.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Bill
{
    class EH_TransactionAddProduct : IEventHandler<TransactionController>
    {
        public EH_TransactionAddProduct(TransactionController Controller) : base(Controller) { }

        public override void OnEvent(IEvent e)
        {
            var evnt = (Event_TransactionAddProduct)e;
            m_Controller.AddProductRowToTable(evnt.GetBillRowEntry());
        }
    }
}
