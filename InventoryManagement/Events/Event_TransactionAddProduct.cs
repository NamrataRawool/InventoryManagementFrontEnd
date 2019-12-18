using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Events
{
    class Event_TransactionAddProduct : IEvent
    {

        private BillRowEntry m_BillEntry;

        public Event_TransactionAddProduct(BillRowEntry Entry)
        {
            m_BillEntry = Entry;
        }

        public BillRowEntry GetBillRowEntry() { return m_BillEntry; }

        public override EventType Type()
        {
            return EventType.UI_Transaction_AddProduct;
        }
    }
}
