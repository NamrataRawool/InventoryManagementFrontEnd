using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Product;
using InventoryManagement.Events;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Properties;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Product;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Product
{
    public class FormController_AddProduct : IController<Form_AddProduct>
    {

        public FormController_AddProduct(Form_AddProduct UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_AddProduct(this));
        }

        public bool AddNewProduct()
        {
            var UI = m_UIControl;
            UI.lbl_Error.Text = string.Empty;
            if (!ValidateProductDetails())
                return false;

            string categoryName = UI.cb_Category.Text;
            CategoryGet category = DataService.GetCategoryDataController().GetByName(categoryName);

            ProductPost productPost = new ProductPost();
            productPost.Name = UI.tb_Name.Text;
            productPost.Barcode = UI.tb_Barcode.Text;
            productPost.Description = UI.tb_Description.Text;
            productPost.RetailPrice = int.Parse(UI.tb_RetailPrice.Text);
            productPost.WholeSalePrice = int.Parse(UI.tb_WholeSalePrice.Text);
            productPost.CategoryID = category.ID;
            productPost.CGST = double.Parse(UI.tb_CGST.Text);
            productPost.SGST = double.Parse(UI.tb_CGST.Text);
            productPost.Discount = double.Parse(UI.tb_SGST.Text);

            productPost.ImagePath = (string)UI.pictureBox_Image.Tag;

            if (string.IsNullOrEmpty(productPost.ImagePath))
            {
                string runningDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string placeholderImagePath = runningDirectory + "/Resources/Images/Placeholder.png";
                productPost.ImagePath = placeholderImagePath;
            }

            var productGet = DataService.GetProductDataController().Post(productPost);
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
            var stockPost = DataService.GetStockDataController().Post(stock);
            if (stockPost == null)
            {
                MessageBox.Show(m_UIControl, "Failed to Add Stock!");
                return false;
            }

            // Broadcast NewProductAdded Event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.PRODUCT, productGet.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            MessageBox.Show(m_UIControl, "Product Added Successfully!");
            UI.Close();
            return true;
        }

        private bool ValidateProductDetails()
        {
            var UI = m_UIControl;
            UI.lbl_Error.Text = string.Empty;

            string name = UI.tb_Name.Text;

            if (string.IsNullOrEmpty(name))
            {
                UI.lbl_Error.Text = "Name field cannot be empty!";
                return false;
            }
            if (!Validator.IsValidAlphaNumeric(UI.tb_Name.Text))
            {
                UI.lbl_Error.Text = "Name not valid!";
                return false;
            }
            if (!string.IsNullOrEmpty(UI.tb_Barcode.Text))
            {
                if (!Validator.IsInteger(UI.tb_Barcode.Text))
                {
                    UI.lbl_Error.Text = "Barcode not valid!";
                    return false;
                }
            }
            if (string.IsNullOrEmpty(UI.cb_Category.Text))
            {
                UI.lbl_Error.Text = "Please select category!";
                return false;
            }

            if (string.IsNullOrEmpty(UI.tb_Discount.Text))
            {
                UI.lbl_Error.Text = "Discount field cannot be empty!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tb_Discount.Text))
            {
                UI.lbl_Error.Text = "Discount not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tb_RetailPrice.Text))
            {
                UI.lbl_Error.Text = "Please enter retail price!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tb_RetailPrice.Text))
            {
                UI.lbl_Error.Text = "Retail Price not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tb_WholeSalePrice.Text))
            {
                UI.lbl_Error.Text = "Please enter wholesale price!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tb_WholeSalePrice.Text))
            {
                UI.lbl_Error.Text = "Wholesale price not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tb_CGST.Text))
            {
                UI.lbl_Error.Text = "Please enter CGST";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tb_CGST.Text))
            {
                UI.lbl_Error.Text = "CGST not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tb_SGST.Text))
            {
                UI.lbl_Error.Text = "Please enter SGST";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tb_SGST.Text))
            {
                UI.lbl_Error.Text = "SGST not valid!";
                return false;
            }

            //check if product with same name exists
            var product = DataService.GetProductDataController().GetByName(UI.tb_Name.Text);
            if (product != null)
            {
                UI.lbl_Error.Text = "Product with same name already exists!";
                return false;
            }

            //check if product with same bar code exists
            if (!string.IsNullOrEmpty(UI.tb_Barcode.Text))
            {
                var prod = DataService.GetProductDataController().GetByBarcode(UI.tb_Barcode.Text);
                if (prod != null)
                {
                    UI.lbl_Error.Text = "Product with same bar code already exists!";
                    return false;
                }
            }

            return true;
        }

        public void AddCategoryToComboBox(CategoryGet category)
        {
            var comboBox = m_UIControl.cb_Category;
            comboBox.Items.Add(category.Name);
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
        }
    }
}
