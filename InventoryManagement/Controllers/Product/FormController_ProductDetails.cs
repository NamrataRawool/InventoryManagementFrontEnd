using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI.Product;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ProductPost product = new ProductPost();
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
            product.CategoryID = HTTPService.GET<CategoryGet>("category/name=" + categoryName).ID;
            if(m_UIControl.pictureBox_ProductImage.Tag != null)
                product.ImagePath = m_UIControl.pictureBox_ProductImage.Tag.ToString();

            m_Product = HTTPService.POST<ProductGet, ProductPost>("product", product, product.ImagePath);
        }

        private void InitializeAvailableStockLabel()
        {
            var stock = HTTPService.GET<StockGet>("/Stock/ProductID=" + m_Product.ID);

            m_UIControl.lbl_ProductDetails_AvailableStockValue.Text = "Not in Database";
            if (stock != null)
                m_UIControl.lbl_ProductDetails_AvailableStockValue.Text = stock.AvailableQuantity.ToString();
        }

        private byte[] GetImage(ProductGet product)
        {
            if (product.ImagePath == null)
                return null;

            string imagePath = m_Product.ImagePath.Split(',')[0];
            if (imagePath == null || imagePath.Length <= 0)
                return null;

            string path = imagePath;
            return HTTPService.GETFile(path);
        }

        private void InitializeProductDetails(int productID)
        {
            m_Product = HTTPService.GET<ProductGet>("product/" + productID);

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

            byte[] imageBytes = GetImage(m_Product);
            if (imageBytes != null && imageBytes.Length > 0)
            {
                UI.pictureBox_ProductImage.Image = Image.FromStream(new MemoryStream(imageBytes));
            }

            // fill categories
            var Categories = HTTPService.GET<List<CategoryGet>>("categories");
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
