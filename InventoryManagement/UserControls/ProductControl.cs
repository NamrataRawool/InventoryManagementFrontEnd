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

namespace InventoryManagement.UserControls
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
            productDataView.DataSource = GetProducts();
        }

        private List<ProductUI> GetProducts()
        {
            var products = HTTPService.GET<List<ProductGet>>("products");
            var productDataSource = new List<ProductUI>();
            foreach (var product in products)
            {
                productDataSource.Add(new ProductUI(product));
            }
            return productDataSource;
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            form_ProductDetails addProduct = new form_ProductDetails();
            addProduct.Text = "Add Product";
            addProduct.ShowDialog();
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            form_ProductDetails editProduct = new form_ProductDetails();
            editProduct.Text = "Edit Product";
            var rows = productDataView.SelectedRows;
            if (rows.Count > 0)
            {
                int selectedRowIndex = productDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = productDataView.Rows[selectedRowIndex];
                var name = selectedRow.Cells["Name"].Value.ToString();
                var description = selectedRow.Cells["Description"].Value.ToString();
                var retailPrice = selectedRow.Cells["RetailPrice"].Value.ToString();
                var wholeSalePrice = selectedRow.Cells["WholeSalePrice"].Value.ToString();
                var category = selectedRow.Cells["Category"].Value.ToString();
                editProduct.tb_Name.Text = name;
                editProduct.tb_description.Text = description;
                editProduct.tb_retailPrice.Text = retailPrice;
                editProduct.tb_wholeSalePrice.Text = wholeSalePrice;
                editProduct.cb_Category.Text = category;
            }

            editProduct.ShowDialog();
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
    }
}
