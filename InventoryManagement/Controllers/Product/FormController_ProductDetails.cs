using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Product;
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
            int productID = int.Parse(m_UIControl.tf_ProductDetails_ProductID.Text);
            ProductGet existingProduct = DataService.GetProductDataController().Get(productID);

            ProductPost product = new ProductPost(existingProduct);
            product.ID = int.Parse(m_UIControl.tf_ProductDetails_ProductID.Text);
            product.Barcode = m_UIControl.tf_ProductDetails_Barcode.Text;
            product.Name = m_UIControl.tf_ProductDetails_ProductName.Text;
            product.Description = m_UIControl.tf_ProductDetails_Description.Text;
            product.RetailPrice = int.Parse(m_UIControl.tf_ProductDetails_RetailPrice.Text);
            product.WholeSalePrice = int.Parse(m_UIControl.tf_ProductDetails_WholesalePrice.Text);
            product.Discount = double.Parse(m_UIControl.tf_ProductDetails_Discount.Text);
            product.CGST = double.Parse(m_UIControl.tf_ProductDetails_CGST.Text);
            product.SGST = double.Parse(m_UIControl.tf_ProductDetails_SGST.Text);

            string categoryName = m_UIControl.cb_ProductDetails_Category.Text;
            product.CategoryID = DataService.GetCategoryDataController().GetByName(categoryName).ID;

            bool imageModified = false;
            if (m_UIControl.pictureBox_ProductImage.Tag != null)
            {
                product.ImagePath = m_UIControl.pictureBox_ProductImage.Tag.ToString();
                imageModified = true;
            }

            m_Product = DataService.GetProductDataController().Put(product, imageModified);
            if (m_Product == null)
            {
                MessageBox.Show(m_UIControl, "Failed to Update Product Details!");
            }
            else
            {
                MessageBox.Show(m_UIControl, "Product Details updated successfully!");
            }

            // fire entry updated event
            Event_EntryUpdated e = new Event_EntryUpdated(DBEntityType.PRODUCT, m_Product.ID);
            EventBroadcaster.Get().BroadcastEvent(e);

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
