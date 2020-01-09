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
using InventoryManagement.Utilities;
using InventoryManagement.Controllers.Transaction;
using InventoryManagement.Services.Data;

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        NewTransactionController m_newTransactionController;
        TransactionHistoryController m_transactionHistoryController;

        public TransactionControl()
        {
            InitializeComponent();
            m_newTransactionController = new NewTransactionController(this);
            m_transactionHistoryController = new TransactionHistoryController(this);
        }

        private void TransactionControl_Load(Object sender, EventArgs e)
        {
            tb_barCode.Focus();
            m_newTransactionController.Initialize();
            ResetTextBox();
            cb_customerName.DataSource = InitializeCustomerNameDatasource();
        }

        #region New Transaction

        private void Bill_ProductsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_newTransactionController.UpdateBillProductsDataRow();
        }

        private void btn_addProductToBill_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_barCode.Text) || !Validator.IsInteger(tb_barCode.Text))
            {
                lbl_errorText.Text = "Please enter valid bar code";
                return;
            }
            lbl_errorText.Text = string.Empty;
            int productId = int.Parse(this.tb_barCode.Text);
            var product = DataService.Get().GetProductDataController().Get(productId);

            if (product == null)
            {
                lbl_errorText.Text = "Record not found";
                return;
            }
            product.Quantity = 1;
            m_newTransactionController.OnAddProduct(product);
            ResetTextBox();
        }

        private void ResetTextBox()
        {
            tb_barCode.Text = string.Empty;
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
                int productId = int.Parse(this.tb_barCode.Text);
                var product = DataService.Get().GetProductDataController().Get(productId);
                if (product == null)
                {
                    lbl_errorText.Text = "Record not found";
                    return;
                }
                product.Quantity = 1;
                m_newTransactionController.OnAddProduct(product);
                ResetTextBox();
            }
        }
        private void btn_deleteBillRecord_Click(object sender, EventArgs e)
        {
            m_newTransactionController.OnDeleteProduct();
        }


        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            m_newTransactionController.OpenForm_ViewBill();
        }

        private void tb_customerName_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_customerError.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                var customer = DataService.Get().GetCustomerDataController().GetByName(tb_customerName.Text.Trim());
                if (customer == null)
                {
                    lbl_customerError.Text = "Customer Not found!";
                    return;
                }
                tb_mobileNumber.Text = customer.MobileNumber;
                tb_pendingAmount.Text = customer.PendingAmount.ToString();
            }
        }

        private void tb_mobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_customerError.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                m_newTransactionController.SearchCustomerByMobileNumber(tb_mobileNumber.Text);
            }
        }

        private void Bill_ProductsDataView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                m_newTransactionController.OnDeleteProduct();
            }
        }

        private void btn_resetTransaction_Click(object sender, EventArgs e)
        {
            m_newTransactionController.ResetTransaction();
        }
        #endregion


        #region Transaction History
        private List<string> InitializeCustomerNameDatasource()
        {
            var customers = DataService.Get().GetCustomerDataController().GetAll();
            if (customers == null)
                return null;

            List<string> customerDataSource = new List<string>();
            foreach (var customer in customers)
                customerDataSource.Add(customer.Name);

            return customerDataSource;
        }
        private void btn_searchByCustomerName_Click(object sender, EventArgs e)
        {
            m_transactionHistoryController.SearchTransactionByCustomerName(cb_customerName.Text);
        }
        private void btn_searchByDate_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime_fromDate.Text;
            var toDate = DateTime_toDate.Text;
            m_transactionHistoryController.SearchTransactionsByDate(fromDate, toDate);
        }
        private void btn_exportToExcel_Click(object sender, EventArgs e)
        {
        }
        #endregion

    }
}
