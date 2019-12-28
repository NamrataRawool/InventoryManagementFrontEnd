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

        public void SubmitNewProduct()
        {
            var UI = m_UIControl;

            string categoryName = UI.cb_Category.Text;
            CategoryGet category = HTTPService.GET<CategoryGet>("category/name-" + categoryName);

            ProductPost product = new ProductPost();
            product.Name = UI.tb_Name.Text;
            product.Description = UI.tb_description.Text;
            product.RetailPrice = int.Parse(UI.tb_retailPrice.Text);
            product.WholeSalePrice = int.Parse(UI.tb_wholeSalePrice.Text);
            product.ImagePath = UI.tb_imageName.Text;
            product.CategoryID = category.ID;

            HTTPService.POST("product", product, UI.tb_imageName.Text);

        }

        protected override void RegisterEvents()
        {
        }
    }
}
