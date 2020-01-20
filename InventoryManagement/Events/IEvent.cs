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

        // Transaction
        UI_Transaction_AddProduct,

        // Vendor

        // Common
        NewEntryAdded,
        EntryUpdated,
    }

    public abstract class IEvent
    {
        public abstract EventType Type();

        public T Cast<T>()
        {
            return (T)Convert.ChangeType(this, typeof(T));
        }
    }

}
