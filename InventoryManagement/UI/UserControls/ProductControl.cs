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
using InventoryManagement.Services.HTTP;
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
            string searchValue = tb_searchProduct.Text.Trim();

            productDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CurrencyManager currencyManager = (CurrencyManager)BindingContext[productDataView.DataSource];
            currencyManager.SuspendBinding();
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in productDataView.Rows)
                {
                    int rowIndex = row.Index;
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().StartsWith(searchValue.ToLower()))
                    {
                        productDataView.Rows[rowIndex].Visible = true;
                        productDataView.FirstDisplayedScrollingRowIndex = rowIndex;
                        valueResult = true;
                    }
                    else
                    {
                        productDataView.Rows[rowIndex].Visible = false;
                    }

                }
                currencyManager.ResumeBinding();
                if (!valueResult)
                {
                    MessageBox.Show("Unable to find " + tb_searchProduct.Text, "Not Found");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tb_searchProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SearchProduct_Click(this, new EventArgs());
            }
        }
        void TextBoxAutoSearch()
        {

        }

    }
}
