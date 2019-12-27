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
            TextBoxAutoSearch();
            productDataView.DataSource = GetProducts();
        }
        private List<ProductUI> GetProducts()
        {
            var products = HTTPService.GET<List<ProductGet>>("products");
            var productDataSource = new List<ProductUI>();
            if (products == null)
                return null;
            foreach (var product in products)
            {
                productDataSource.Add(new ProductUI(product));
            }
            return productDataSource;
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            m_Controller.OnAddNewProductClicked();
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
                editProduct.tb_Name.Text = selectedRow.Cells["Name"].Value.ToString();
                editProduct.tb_description.Text = selectedRow.Cells["Description"].Value.ToString();
                editProduct.tb_retailPrice.Text = selectedRow.Cells["RetailPrice"].Value.ToString();
                editProduct.tb_wholeSalePrice.Text = selectedRow.Cells["WholeSalePrice"].Value.ToString();
                editProduct.cb_Category.Text = selectedRow.Cells["Category"].Value.ToString();
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
        void TextBoxAutoSearch()
        {
            tb_searchProduct.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_searchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            var products = GetProducts();
            if (products == null)
                return;
            foreach (var product in products)
            {
                collection.Add(product.Name);
            }
            tb_searchProduct.AutoCompleteCustomSource = collection;
        }

    }
}
