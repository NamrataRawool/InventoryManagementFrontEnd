using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagement.UI.Product;
using InventoryManagement.Controllers;

namespace InventoryManagement.UI.UserControls
{
    public partial class ProductControl : UserControl
    {

        ProductController m_Controller;

        public ProductControl()
        {
            InitializeComponent();
            m_Controller = new ProductController(this);
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            m_Controller.Initialize();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_AddProduct();
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            m_Controller.OpenForm_ProductDetails();
        }

        private void btn_SearchProduct_Click(object sender, EventArgs e)
        {
            m_Controller.UpdateTableByProductName(tb_searchProduct.Text.Trim());
        }

        private void tb_searchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_Controller.UpdateTableByProductName(tb_searchProduct.Text.Trim());
            }
        }

        private void onTextChanged_SearchProduct(object sender, EventArgs e)
        {
            m_Controller.UpdateTableByProductName(tb_searchProduct.Text.Trim());
        }
    }
}
