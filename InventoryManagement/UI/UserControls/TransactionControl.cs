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
using InventoryManagement.Events;
using InventoryManagement.Broadcaster;
using InventoryManagement.Controllers;
using InventoryManagement.Services.HTTP;
using InventoryManagement.Utilities;
using InventoryManagement.Controllers.Transaction;

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        TransactionController m_Controller;
        BillRowEntry oldBillRowEntry;

        public TransactionControl()
        {
            InitializeComponent();
            m_Controller = new TransactionController(this);
        }

        private void TransactionControl_Load(Object sender, EventArgs e)
        {
            tb_barCode.Focus();
            m_Controller.Initialize();
            ResetTextBox();
            cb_customerName.DataSource = InitializeCustomerNameDatasource();
            TextBoxAutoSearch();
        }

        private List<string> InitializeCustomerNameDatasource()
        {
            var customers = HTTPService.GET<List<CustomerGet>>("customers");
            if (customers == null)
                return null;
            List<string> customerDataSource = new List<string>();
            foreach (var customer in customers)
            {
                customerDataSource.Add(customer.Name);
            }
            return customerDataSource;
        }
        private void TextBoxAutoSearch()
        {
            tb_productName.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb_productName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            List<ProductGet> products = HTTPService.GET<List<ProductGet>>("products");
            if (products == null)
                return;
            foreach (var product in products)
            {
                collection.Add(product.Name);
            }
            tb_productName.AutoCompleteCustomSource = collection;
        }
        private void Bill_ProductsDataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var rows = Bill_ProductsDataView.SelectedRows;
            if (rows.Count > 0)
            {
                oldBillRowEntry = new BillRowEntry();
                int selectedRowIndex = Bill_ProductsDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Bill_ProductsDataView.Rows[selectedRowIndex];
                oldBillRowEntry.Price = int.Parse(selectedRow.Cells["BillTable_Price"].Value.ToString());
                var discountedPrice = int.Parse(selectedRow.Cells["BillTable_Discount"].Value.ToString());
                oldBillRowEntry.Quantity = int.Parse(selectedRow.Cells["BillTable_Quantity"].Value.ToString());
                oldBillRowEntry.Discount = (discountedPrice * 100) / (oldBillRowEntry.Price * oldBillRowEntry.Quantity);
            }
        }
        private void Bill_ProductsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_Controller.UpdateBillProductsDataRow(oldBillRowEntry);
        }

        private void btn_addProductToBill_Click(object sender, EventArgs e)
        {
            BillRowEntry Entry = new BillRowEntry();
            Entry.ProductId = int.Parse(this.tb_barCode.Text);
            Entry.ProductName = this.tb_productName.Text;
            Entry.Price = int.Parse(this.tb_price.Text);
            Entry.Discount = int.Parse(this.tb_discount.Text);
            if (String.IsNullOrEmpty(tb_quantity.Text) || !Validator.IsInteger(tb_quantity.Text))
                return;
            Entry.Quantity = int.Parse(this.tb_quantity.Text);

            m_Controller.OnAddProduct(Entry);

            ResetTextBox();
        }

        void ResetTextBox()
        {
            tb_productName.Text = string.Empty;
            tb_quantity.Text = string.Empty;
            tb_discount.Text = string.Empty;
            tb_barCode.Text = string.Empty;
            tb_price.Text = string.Empty;
           
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_addProductToBill_Click(sender, e);
                tb_barCode.Focus();
            }
        }

        private void tb_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<ProductGet> products = HTTPService.GET<List<ProductGet>>("products");
                if (products == null)
                    return;
                foreach (var product in products)
                {
                    if (product.Name.Equals(tb_productName.Text))
                    {
                        tb_price.Text = product.RetailPrice.ToString();
                        tb_discount.Text = tb_price.Text = product.RetailPrice.ToString() + "%";
                        return;
                    }
                }
            }
        }

        private void tb_barCode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tb_barCode.Text) || !Validator.IsInteger(tb_barCode.Text))
                {
                    lbl_errorText.Text = "Please enter valid bar code";
                    return;
                }
                lbl_errorText.Text = string.Empty;
                List<ProductGet> products = HTTPService.GET<List<ProductGet>>("products");
                if (products == null)
                    return;
                foreach (var product in products)
                {
                    var id = Convert.ToInt32(tb_barCode.Text.Trim());
                    if (product.ID == id)
                    {
                        tb_productName.Text = product.Name;
                        tb_price.Text = product.RetailPrice.ToString();
                        tb_discount.Text = product.Category.Discount.ToString();
                        tb_quantity.Focus();
                        return;
                    }
                }
                lbl_errorText.Text = "Record not found";
            }

        }

        private void btn_searchByCustomerName_Click(object sender, EventArgs e)
        {
            m_Controller.SearchTransactionByCustomerName(cb_customerName.Text);
        }

        private void btn_deleteBillRecord_Click(object sender, EventArgs e)
        {
            m_Controller.OnDeleteProduct();
        }

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
        }

        private void btn_searchByDate_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime_fromDate.Text;
            var toDate = DateTime_toDate.Text;
            m_Controller.SearchTransactionsByDate(fromDate, toDate);
        }

        private void btn_exportToExcel_Click(object sender, EventArgs e)
        {

        }

        private void btn_saveTransaction_Click(object sender, EventArgs e)
        {
            m_Controller.SaveTransaction();
        }

        private void tb_customerName_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_customerError.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                var customer = HTTPService.GET<CustomerGet>("customer/name=" + tb_customerName.Text);
                if (customer == null)
                    lbl_customerError.Text = "Customer Not found!";
                tb_mobileNumber.Text = customer.MobileNumber;
                tb_pendingAmount.Text = customer.PendingAmount.ToString();
            }
        }

        private void tb_mobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //var customer = HTTPService.GET<CustomerGet>("customer/name=" + tb_customerName.Text);
            }
        }
    }
}
