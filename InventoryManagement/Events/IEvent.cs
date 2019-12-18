using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Events
{

    public enum EventType
    {

        // Product
        UI_Product_AddNewProduct,

        // Transaction
        UI_Transaction_AddProduct,
    }

    public abstract class IEvent
    {
        public abstract EventType Type();
    }

}
