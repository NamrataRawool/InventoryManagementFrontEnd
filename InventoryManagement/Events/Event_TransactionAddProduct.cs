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

        private ProductGet m_BillEntry;

        public Event_TransactionAddProduct(ProductGet product)
        {
            m_BillEntry = product;
        }

        public ProductGet GetBillRowEntry() { return m_BillEntry; }

        public override EventType Type()
        {
            return EventType.UI_Transaction_AddProduct;
        }
    }
}
