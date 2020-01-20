using InventoryManagement.Controllers;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
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
                case EventType.NewEntryAdded:
                    {
                        var ev = e.Cast<Event_NewEntryAdded>();
                        if (ev.GetEntityType() == DBEntityType.PRODUCT)
                            AddProductToTable(ev.GetID());
                        break;
                    }

                case EventType.EntryUpdated:
                    { 
                        var ev = e.Cast<Event_EntryUpdated>();
                        if (ev.GetEntityType() == DBEntityType.PRODUCT)
                            UpdateProductInTable(ev.GetID());
                        break;
                    }
            }
        }

        private void UpdateProductInTable(int productID)
        {
            var product = DataService.GetProductDataController().Get(productID);
            if (product == null)
            {
                Assert.Do("This should not have happened!");
                return;
            }

            m_Controller.UpdateProductInTable(product);
        }

        private void AddProductToTable(int productID)
        {
            var product = DataService.GetProductDataController().Get(productID);
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
