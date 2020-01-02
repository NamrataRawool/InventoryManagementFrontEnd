using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Product;
using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers.Product
{
    class FormController_AddProduct : IController<Form_AddProduct>
    {

        public FormController_AddProduct(Form_AddProduct UIControl)
            : base(UIControl)
        {
        }

        public bool AddNewProduct()
        {
            var UI = m_UIControl;

            string categoryName = UI.cb_Category.Text;
            CategoryGet category = HTTPService.GET<CategoryGet>("category/name=" + categoryName);

            ProductPost product = new ProductPost();
            product.Name = UI.tb_Name.Text;
            product.Barcode = UI.tb_Barcode.Text;
            product.Description = UI.tb_Description.Text;
            product.RetailPrice = int.Parse(UI.tb_RetailPrice.Text);
            product.WholeSalePrice = int.Parse(UI.tb_WholeSalePrice.Text);
            product.ImagePath = UI.tb_imageName.Text;
            product.CategoryID = category.ID;

            var productPost = HTTPService.POST<ProductGet, ProductPost>("product", product, product.ImagePath);
            if (productPost == null)
                return false;

            // post the Default details
            StockPost stock = new StockPost();
            stock.ProductID = productPost.ID;
            stock.AvailableQuantity = 0;
            stock.TotalQuantity = 0;
            var stockPost = HTTPService.POST<StockGet, StockPost>("stock", stock);
            if (stockPost == null)
                return false;

            // Broadcast NewProductAdded Event
            Event_NewProductAdded e = new Event_NewProductAdded(productPost.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            return true;
        }

        protected override void RegisterEvents()
        {
        }
    }
}
