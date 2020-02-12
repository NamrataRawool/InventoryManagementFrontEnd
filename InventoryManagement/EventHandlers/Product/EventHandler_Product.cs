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
                        HandleEvent_NewEntryAdded(e.Cast<Event_NewEntryAdded>());
                        break;
                    }

                case EventType.EntryUpdated:
                    {
                        HandleEvent_EntryUpdated(e.Cast<Event_EntryUpdated>());
                        break;
                    }
            }
        }

        private void HandleEvent_NewEntryAdded(Event_NewEntryAdded e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.PRODUCT)
            {
                AddProductToTable(e.GetID());
            }
            else if (entityType == DBEntityType.PURCHASE)
            {
                OnPurchaseAdded(e.GetID());
            }
        }

        private void HandleEvent_EntryUpdated(Event_EntryUpdated e)
        {
            DBEntityType entityType = e.GetEntityType();

            if (entityType == DBEntityType.PRODUCT)
            {
                UpdateProductInTable(e.GetID());
            }
        }

        private void OnPurchaseAdded(int id)
        {
            var purchase = DataService.GetPurchaseDataController().Get(id);
            if (purchase == null)
            {
                Assert.Do("This should not have happened!");
                return;
            }

            m_Controller.OnPurchaseAdded(purchase);
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
