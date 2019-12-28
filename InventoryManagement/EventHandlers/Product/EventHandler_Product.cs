using InventoryManagement.Controllers;
using InventoryManagement.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.EventHandlers.Product
{
    public class EventHandler_Product : IEventHandler<ProductController>
    {
        public EventHandler_Product(ProductController Controller)
            : base(Controller)
        {
        }

        public override void OnEvent(IEvent e)
        {
            EventType type = e.Type();

            if (type == EventType.UI_Product_AddNewProduct)
            {
                m_Controller.OpenForm_AddProduct();
            }
        }
    }
}
