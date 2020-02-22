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

        private ProductGet m_Product;

        public FormController_AddProduct(Form_AddProduct UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_AddProduct(this));
        }

        public void Initialize()
        {
            InitializeCategoryComboBox();
            InitializeUnitComboBox();
        }

        private void InitializeUnitComboBox()
        {
            var comboBox = m_UIControl.cb_Unit;

            comboBox.Items.Add("KG");
            comboBox.Items.Add("Gram");
            comboBox.Items.Add("Liter");
            comboBox.Items.Add("MiliLiter");
            comboBox.Items.Add("Packet");

            comboBox.SelectedIndex = 0;
        }

        private void InitializeCategoryComboBox()
        {
            var categories = DataService.GetCategoryDataController().GetAll();
            var comboBox = m_UIControl.cb_Category;

            foreach (var category in categories)
                comboBox.Items.Add(category.Name);

            comboBox.SelectedIndex = 0;
        }

        public void ResetAll()
        {
            var UI = m_UIControl;

            UI.tb_Name.Text = string.Empty;
            UI.tb_Barcode.Text = string.Empty;
            UI.tb_Description.Text = string.Empty;
            UI.tb_RetailPrice.Text = string.Empty;
            UI.tb_WholeSalePrice.Text = string.Empty;
            UI.tb_CGST.Text = string.Empty;
            UI.tb_SGST.Text = string.Empty;
            UI.tb_Discount.Text = string.Empty;
            UI.lbl_Error.Text = string.Empty;

            // set category to
            UI.cb_Category.SelectedIndex = 0;
            UI.pictureBox_Image.ImageLocation = "Resources\\Images\\placeholder.jpg";
        }

        public bool AddNewProduct()
        {
            var UI = m_UIControl;

            UI.DialogResult = DialogResult.None;

            UI.lbl_Error.Text = string.Empty;
            if (!ValidateProductDetails())
                return false;

            string categoryName = UI.cb_Category.Text.Trim();
            CategoryGet category = DataService.GetCategoryDataController().GetByName(categoryName);

            int unit = UI.cb_Unit.SelectedIndex + 1;

            ProductPost productPost = new ProductPost();
            productPost.Name = UI.tb_Name.Text.Trim();
            productPost.Barcode = UI.tb_Barcode.Text.Trim();
            productPost.Description = UI.tb_Description.Text.Trim();
            productPost.Unit = unit;
            productPost.RetailPrice = int.Parse(UI.tb_RetailPrice.Text.Trim());
            productPost.WholeSalePrice = int.Parse(UI.tb_WholeSalePrice.Text.Trim());
            productPost.CategoryID = category.ID;
            productPost.CGST = double.Parse(UI.tb_CGST.Text.Trim());
            productPost.SGST = double.Parse(UI.tb_CGST.Text.Trim());
            productPost.Discount = double.Parse(UI.tb_SGST.Text.Trim());

            productPost.ImagePath = GetImagePath();

            m_Product = DataService.GetProductDataController().Post(productPost);
            if (m_Product == null)
            {
                MessageBox.Show(UI, "Failed to Add Product!");
                return false;
            }

            // post the Default details
            StockPost stock = new StockPost();
            stock.ProductID = m_Product.ID;
            stock.AvailableQuantity = 0;
            stock.TotalQuantity = 0;
            var stockPost = DataService.GetStockDataController().Post(stock);
            if (stockPost == null)
            {
                MessageBox.Show(UI, "Failed to Add Stock!");
                return false;
            }

            // Broadcast NewProductAdded Event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.PRODUCT, m_Product.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

            MessageBox.Show(UI, "Product Added Successfully!");

            if (!m_UIControl.checkBox_AddAnotherProduct.Checked)
            {
                UI.DialogResult = DialogResult.OK;
                UI.Close();
            }

            return true;
        }

        private string GetImagePath()
        {
            string imagePath = ((string)m_UIControl.pictureBox_Image.Tag);

            if (!string.IsNullOrEmpty(imagePath))
                return imagePath;

            return GetPlaceHolderImagePath();
        }

        private string GetPlaceHolderImagePath()
        {
            string runningDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string placeholderImagePath = Path.Combine(runningDirectory, "Resources\\Images\\placeholder.jpg");
            return placeholderImagePath;
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
            if (UI.cb_Category.SelectedIndex < 0)
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

        public ProductGet GetCustomer() { return m_Product; }

    }
}
