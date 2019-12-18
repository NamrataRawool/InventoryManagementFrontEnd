using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Events.Product
{
    class Event_AddProduct : IEvent
    {
        public override EventType Type()
        {
            return EventType.UI_Product_AddNewProduct;
        }
    }
}
