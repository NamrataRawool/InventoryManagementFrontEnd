using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Models;

namespace InventoryManagement.UI.UserControls
{
    public partial class BillControl : UserControl
    {
        List<ProductGet> products;
        List<Bill> billingItems = new List<Bill>();
        public BillControl()
        {
            InitializeComponent();
            cb_Products.DataSource = GetProducts();
        }
        private List<string> GetProducts()
        {
            products = HTTPService.GET<List<ProductGet>>("products");
            var productDataSource = new List<string>();
            foreach (var product in products)
            {
                productDataSource.Add(product.Name);
            }
            return productDataSource;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void cb_Products_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                foreach (var product in products)
                {
                    if (product.Name.Equals(cb_Products.SelectedText))
                    {
                        tb_price.Text = product.RetailPrice.ToString();
                        tb_discount.Text = tb_price.Text = product.RetailPrice.ToString();
                    }
                }
            }
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TransactionControl transactionControl = new TransactionControl();
                var item = new Bill()
                {
                    ProductName = cb_Products.Text,
                    Quantity = Convert.ToInt32(tb_quantity.Text.Trim()),
                    Discount = Convert.ToInt32(tb_discount.Text.Trim()),
                    Price = Convert.ToInt32(tb_price.Text.Trim()),
                };


            }
        }
    }
}
