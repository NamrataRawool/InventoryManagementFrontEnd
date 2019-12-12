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

namespace InventoryManagement.UserControls
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {

            InitializeComponent();
            productDataView.DataSource = GetProducts();
        }
        private List<Product> GetProducts()
        {
            var prlist = new List<Product>();
            for (int i = 1; i <= 100; i++)
            {
                prlist.Add(new Product
                {
                    ID = i,
                    Name = "product" + i,
                    Description = "Description" + i,
                    RetailPrice = 120,
                    WholeSalePrice = 130,
                    Category = "c" + i
                });
            }
            return prlist;
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            AddProduct editProduct = new AddProduct();
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
    }
}
