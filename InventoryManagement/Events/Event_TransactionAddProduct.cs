using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Events
{
    class Event_TransactionAddProduct : IEvent
    {
        public override EventType Type()
        {
            return EventType.UI_Transaction_AddProduct;
        }
    }
}
