using InventoryManagement.Controllers;
using InventoryManagement.Events;
using InventoryManagement.Events.Product;
using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Services.Misc.Assert;
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

            switch (type)
            {
                case EventType.NewProductAdded:
                    AddProductToTable(e.Cast<Event_NewProductAdded>().GetProductID());
                    break;
            }
        }

        private void AddProductToTable(int productID)
        {
            var product = HTTPService.GET<ProductGet>("product/" + productID);
            if (product == null)
            {
                Assert.Do("This should not have happened!");
                return;
            }

            m_Controller.AddProductToTable(product);
            m_Controller.RefreshTable();

            m_Controller.AddProductToAutoSearchBox(product.Name);
        }
    }
}
