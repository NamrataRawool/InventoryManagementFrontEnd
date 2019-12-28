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
    class FormController_ProductDetails : IController<Form_ProductDetails>
    {
        private int m_ProductID;

        public FormController_ProductDetails(int ProductID, Form_ProductDetails UIControl) 
            :   base(UIControl)
        {
            m_ProductID = ProductID;

            Initialize();
        }

        private void Initialize()
        {
            InitializeProductDetails();
        }

        private void InitializeProductDetails()
        {
            var Product = HTTPService.GET<ProductGet>("product/" + m_ProductID);

            var UI = m_UIControl;

            UI.tf_ProductDetails_ProductID.Text = Product.ID.ToString();
            UI.tf_ProductDetails_ProductName.Text = Product.Name;
            UI.tf_ProductDetails_RetailPrice.Text = Product.RetailPrice.ToString();
            UI.tf_ProductDetails_WholesalePrice.Text = Product.WholeSalePrice.ToString();

            // fill categories
            var Categories = HTTPService.GET<List<CategoryGet>>("categories");
            foreach (var category in Categories)
            {
                UI.cb_ProductDetails_Category.Items.Add(category.Name);
            }
            UI.cb_ProductDetails_Category.SelectedItem = Product.Category.Name;
        }

        protected override void RegisterEvents()
        {
        }
    }
}
