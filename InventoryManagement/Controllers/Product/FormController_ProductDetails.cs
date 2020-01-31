using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Product;
using InventoryManagement.Utilities;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Product
{
    class FormController_ProductDetails : IController<Form_ProductDetails>
    {
        private ProductGet m_Product;

        public FormController_ProductDetails(int productID, Form_ProductDetails UIControl)
            : base(UIControl)
        {
            Initialize(productID);
        }

        private void Initialize(int productID)
        {
            InitializeProductDetails(productID);
            InitializeAvailableStockLabel();
        }

        public void UpdateProductDetails()
        {
            if (!ValidateProductDetails())
                return;

            string barcode = m_UIControl.tf_ProductDetails_Barcode.Text.Trim();
            if (CheckIfBarcodeAlreadyInUse(barcode))
            {
                m_UIControl.lbl_Error.Text = "This Barcode is already in use!";
                return;
            }

            string name = m_UIControl.tf_ProductDetails_ProductName.Text.Trim();
            if (CheckIfProductNameAlreadyInUse(name))
            {
                m_UIControl.lbl_Error.Text = "This Name is already in use!";
                return;
            }

            ProductGet existingProduct = m_Product;

            ProductPost product = new ProductPost(existingProduct);
            product.ID = int.Parse(m_UIControl.tf_ProductDetails_ProductID.Text.Trim());
            product.Barcode = barcode;
            product.Name = name;
            product.Description = m_UIControl.tf_ProductDetails_Description.Text.Trim();
            product.RetailPrice = int.Parse(m_UIControl.tf_ProductDetails_RetailPrice.Text.Trim());
            product.WholeSalePrice = int.Parse(m_UIControl.tf_ProductDetails_WholesalePrice.Text.Trim());
            product.Discount = double.Parse(m_UIControl.tf_ProductDetails_Discount.Text.Trim());
            product.CGST = double.Parse(m_UIControl.tf_ProductDetails_CGST.Text.Trim());
            product.SGST = double.Parse(m_UIControl.tf_ProductDetails_SGST.Text.Trim());

            string categoryName = m_UIControl.cb_ProductDetails_Category.Text.Trim();
            product.CategoryID = DataService.GetCategoryDataController().GetByName(categoryName).ID;

            bool imageModified = false;
            if (m_UIControl.pictureBox_ProductImage.Tag != null)
            {
                product.ImagePath = m_UIControl.pictureBox_ProductImage.Tag.ToString();
                imageModified = true;
            }

            m_Product = DataService.GetProductDataController().Put(product, imageModified);
            string message = (m_Product == null) ? "Failed to Update Product Details!" : "Product Details updated successfully!";
            MessageBox.Show(m_UIControl, message);

            // fire entry updated event
            Event_EntryUpdated e = new Event_EntryUpdated(DBEntityType.PRODUCT, m_Product.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        private bool CheckIfBarcodeAlreadyInUse(string barcode)
        {
            var product = DataService.GetProductDataController().GetByBarcode(barcode);
            return product != null && product.ID != m_Product.ID;
        }

        private bool CheckIfProductNameAlreadyInUse(string name)
        {
            var product = DataService.GetProductDataController().GetByName(name);
            return product != null && product.ID != m_Product.ID;
        }

        private bool ValidateProductDetails()
        {
            var UI = m_UIControl;
            UI.lbl_Error.Text = string.Empty;

            if (string.IsNullOrEmpty(UI.tf_ProductDetails_ProductName.Text.Trim()))
            {
                UI.lbl_Error.Text = "Name field cannot be empty!";
                return false;
            }
            if (!Validator.IsValidAlphaNumeric(UI.tf_ProductDetails_ProductName.Text.Trim()))
            {
                UI.lbl_Error.Text = "Name not valid!";
                return false;
            }
            if (!string.IsNullOrEmpty(UI.tf_ProductDetails_Barcode.Text.Trim()))
            {
                if (!Validator.IsInteger(UI.tf_ProductDetails_Barcode.Text.Trim()))
                {
                    UI.lbl_Error.Text = "Barcode not valid!";
                    return false;
                }
            }
            if (string.IsNullOrEmpty(UI.cb_ProductDetails_Category.Text.Trim()))
            {
                UI.lbl_Error.Text = "Please select category!";
                return false;
            }

            if (string.IsNullOrEmpty(UI.tf_ProductDetails_Discount.Text.Trim()))
            {
                UI.lbl_Error.Text = "Discount field cannot be empty!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tf_ProductDetails_Discount.Text.Trim()))
            {
                UI.lbl_Error.Text = "Discount not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tf_ProductDetails_RetailPrice.Text.Trim()))
            {
                UI.lbl_Error.Text = "Please enter retail price!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tf_ProductDetails_RetailPrice.Text.Trim()))
            {
                UI.lbl_Error.Text = "Retail Price not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tf_ProductDetails_WholesalePrice.Text.Trim()))
            {
                UI.lbl_Error.Text = "Please enter wholesale price!";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tf_ProductDetails_WholesalePrice.Text.Trim()))
            {
                UI.lbl_Error.Text = "Wholesale price not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tf_ProductDetails_CGST.Text.Trim()))
            {
                UI.lbl_Error.Text = "Please enter CGST";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tf_ProductDetails_CGST.Text.Trim()))
            {
                UI.lbl_Error.Text = "CGST not valid!";
                return false;
            }
            if (string.IsNullOrEmpty(UI.tf_ProductDetails_SGST.Text.Trim()))
            {
                UI.lbl_Error.Text = "Please enter SGST";
                return false;
            }
            if (!Validator.IsValidDouble(UI.tf_ProductDetails_SGST.Text.Trim()))
            {
                UI.lbl_Error.Text = "SGST not valid!";
                return false;
            }
            return true;
        }

        private void InitializeAvailableStockLabel()
        {
            var stock = DataService.GetStockDataController().GetByProductID(m_Product.ID);

            m_UIControl.lbl_ProductDetails_AvailableStockValue.Text = "Not in Database";
            if (stock != null)
                m_UIControl.lbl_ProductDetails_AvailableStockValue.Text = stock.AvailableQuantity.ToString();
        }

        private string GetImagePath(ProductGet product)
        {
            if (product.ImagePath == null)
                return null;

            string imagePath = product.ImagePath.Split(',')[0];
            if (imagePath == null || imagePath.Length <= 0)
                return null;

            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            string path = directory + "/" + imagePath;
            return path;
        }

        private void InitializeProductDetails(int productID)
        {
            m_Product = DataService.GetProductDataController().Get(productID);

            var UI = m_UIControl;

            UI.tf_ProductDetails_ProductID.Text = m_Product.ID.ToString();
            UI.tf_ProductDetails_Barcode.Text = m_Product.Barcode;
            UI.tf_ProductDetails_ProductName.Text = m_Product.Name;
            UI.tf_ProductDetails_Description.Text = m_Product.Description;
            UI.tf_ProductDetails_RetailPrice.Text = m_Product.RetailPrice.ToString();
            UI.tf_ProductDetails_WholesalePrice.Text = m_Product.WholeSalePrice.ToString();
            UI.tf_ProductDetails_Discount.Text = m_Product.Discount.ToString();
            UI.tf_ProductDetails_CGST.Text = m_Product.CGST.ToString();
            UI.tf_ProductDetails_SGST.Text = m_Product.SGST.ToString();

            string filepath = GetImagePath(m_Product);

            using (var fs = new FileStream(filepath, FileMode.Open))
            {
                UI.pictureBox_ProductImage.Image = Image.FromStream(fs);
            }

            // fill categories
            var Categories = DataService.GetCategoryDataController().GetAll();
            foreach (var category in Categories)
            {
                UI.cb_ProductDetails_Category.Items.Add(category.Name);
            }
            UI.cb_ProductDetails_Category.SelectedItem = m_Product.Category.Name;
        }

        protected override void RegisterEvents()
        {
        }
    }
}
