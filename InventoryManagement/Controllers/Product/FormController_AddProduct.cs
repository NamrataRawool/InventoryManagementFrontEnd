using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CategoryGet category = DataService.Get().GetCategoryDataController().GetByName(categoryName);

            ProductPost productPost = new ProductPost();
            productPost.Name = UI.tb_Name.Text;
            productPost.Barcode = UI.tb_Barcode.Text;
            productPost.Description = UI.tb_Description.Text;
            productPost.RetailPrice = int.Parse(UI.tb_RetailPrice.Text);
            productPost.WholeSalePrice = int.Parse(UI.tb_WholeSalePrice.Text);
            productPost.ImagePath = (string)UI.pictureBox_Image.Tag;
            productPost.CategoryID = category.ID;
            productPost.CGST = double.Parse(UI.tb_CGST.Text);
            productPost.SGST = double.Parse(UI.tb_CGST.Text);
            productPost.Discount = double.Parse(UI.tb_SGST.Text);

            var productGet = DataService.Get().GetProductDataController().Post(productPost);
            if (productGet == null)
            {
                MessageBox.Show(m_UIControl, "Failed to Add Product!");
                return false;
            }

            // post the Default details
            StockPost stock = new StockPost();
            stock.ProductID = productGet.ID;
            stock.AvailableQuantity = 0;
            stock.TotalQuantity = 0;
            var stockPost = DataService.Get().GetStockDataController().Post(stock);
            if (stockPost == null)
            {
                MessageBox.Show(m_UIControl, "Failed to Add Stock!");
                return false;
            }

            // Broadcast NewProductAdded Event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.PRODUCT, productGet.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            MessageBox.Show(m_UIControl, "Product Added Successfully!");

            return true;
        }

        protected override void RegisterEvents()
        {
        }
    }
}
