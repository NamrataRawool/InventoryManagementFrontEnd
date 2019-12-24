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
using InventoryManagement.Events;
using InventoryManagement.Broadcaster;
using InventoryManagement.Controllers;

namespace InventoryManagement.UI.UserControls
{
    public partial class BillControl : UserControl
    {

        BillController m_Controller;

        List<ProductGet> products;
        List<BillRowEntry> billingItems = new List<BillRowEntry>();

        public BillControl()
        {
            m_Controller = new BillController(this);

            InitializeComponent();
            TextBoxAutoSearch();
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

        private void TextBoxAutoSearch()
        {
            tb_productName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_productName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            var products = GetProducts();
            foreach (var product in products)
            {
                collection.Add(product);
            }
            tb_productName.AutoCompleteCustomSource = collection;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            BillRowEntry Entry = new BillRowEntry();
            Entry.ProductName = this.tb_productName.Text;
            Entry.Price = int.Parse(this.tb_price.Text);
            Entry.Discount = int.Parse(this.tb_discount.Text);
            Entry.Quantity = int.Parse(this.tb_quantity.Text);

            m_Controller.OnAddProduct(Entry);

            ResetTextBox();
        }

        void ResetTextBox()
        {
            tb_productName.Text = string.Empty;
            tb_quantity.Text = string.Empty;
            tb_discount.Text = string.Empty;
            tb_barcode.Text = string.Empty;
            tb_price.Text = string.Empty;
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
        }

        private void tb_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var product in products)
                {
                    if (product.Name.Equals(tb_productName.Text))
                    {
                        tb_price.Text = product.RetailPrice.ToString();
                        tb_discount.Text = tb_price.Text = product.RetailPrice.ToString();
                        return;
                    }
                }
            }
        }

        private void tb_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (var product in products)
                {
                    var id = Convert.ToInt32(tb_barcode.Text.Trim());
                    if (product.ID == id)
                    {
                        tb_productName.Text = product.Name;
                        tb_price.Text = product.RetailPrice.ToString();
                        tb_discount.Text = product.Category.Discount.ToString();
                        return;
                    }
                }
            }
        }
    }
}
