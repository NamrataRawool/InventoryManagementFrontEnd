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
            productDataView.DataSource = HTTPService.GET<List<ProductGet>>("products");
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
                editProduct.cb_Category.SelectedText = category;
            }

            editProduct.ShowDialog();
        }

        private void btn_SearchProduct_Click(object sender, EventArgs e)
        {
            string searchValue = tb_searchProduct.Text;
            productDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResult = false;
                foreach (DataGridViewRow row in productDataView.Rows)
                {
                    var count = row.Cells.Count;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(searchValue.ToLower()))
                        {
                            int rowIndex = row.Index;
                            productDataView.Rows[rowIndex].Selected = true;
                            productDataView.FirstDisplayedScrollingRowIndex = rowIndex;
                            valueResult = true;
                            break;
                        }
                    }
                    if (valueResult)
                        break;
                }
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
