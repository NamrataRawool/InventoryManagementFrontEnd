using System;
using System.Windows.Forms;
using InventoryManagement.Utilities;
using InventoryManagement.Controllers.Transaction;
using InventoryManagement.Services.Data;
using InventoryManagement.Models;

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
        }

        #region New Transaction

        private void Bill_ProductsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_newTransactionController.UpdateBillProductsDataRow();
        }

        private void AddProductToTable(ProductGet product)
        {
            if (product == null)
            {
                lbl_errorText.Text = "Record not found";
                return;
            }

            BillProductDetails billProductDetails = new BillProductDetails(product, 1);
            m_newTransactionController.OnAddProduct(billProductDetails);
            ResetTextBox();
        }

        private void btn_addProductToBill_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_barCode.Text) || !Validator.IsInteger(tb_barCode.Text))
            {
                lbl_errorText.Text = "Please enter valid bar code";
                return;
            }
            lbl_errorText.Text = string.Empty;
            var barcode = this.tb_barCode.Text;

            ProductGet product = DataService.GetProductDataController().GetByBarcode(barcode);
            AddProductToTable(product);
        }

        private void btn_addProduct_ProductName_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_productName.Text) || !Validator.IsValidString(tb_productName.Text))
            {
                lbl_errorText.Text = "Please enter valid product name";
                return;
            }
            lbl_errorText.Text = string.Empty;
            string productName = tb_productName.Text.Trim();

            var product = DataService.GetProductDataController().GetByName(productName);
            AddProductToTable(product);
        }

        private void ResetTextBox()
        {
            tb_barCode.Text = string.Empty;
            tb_productName.Text = string.Empty;
        }

        private void tb_barCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tb_barCode.Text))
                {
                    return;
                }

                if (!Validator.IsInteger(tb_barCode.Text))
                {
                    lbl_errorText.Text = "Please enter valid bar code";
                    return;
                }

                lbl_errorText.Text = string.Empty;

                string productBarCode = tb_barCode.Text.Trim();

                var product = DataService.GetProductDataController().GetByBarcode(productBarCode);
                AddProductToTable(product);
            }
        }

        private void tb_productName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tb_productName.Text))
                {
                    return;
                }

                if (!Validator.IsValidString(tb_productName.Text))
                {
                    lbl_errorText.Text = "Please enter valid product name";
                    return;
                }

                lbl_errorText.Text = string.Empty;

                string productName = tb_productName.Text.Trim();

                var productGet = DataService.GetProductDataController().GetByName(productName);
                AddProductToTable(productGet);
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

        private void tb_AmountPaid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                m_newTransactionController.OpenForm_ViewBill();
            }
        }

        private void tb_mobileNumber_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_customerError.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tb_mobileNumber.Text))
                {
                    m_newTransactionController.ResetCustomerDetails();
                    return;
                }

                m_newTransactionController.SearchCustomerByMobileNumber(tb_mobileNumber.Text);
            }
        }

        private void tb_customerName_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_customerError.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tb_customerName.Text))
                {
                    m_newTransactionController.ResetCustomerDetails();
                    return;
                }
                m_newTransactionController.SearchCustomerByName(tb_customerName.Text);
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

        private void btn_searchByCustomerName_Click(object sender, EventArgs e)
        {
            if (cb_customerName.SelectedIndex < 0)
            {
                MessageBox.Show("Select a Customer!");
                return;
            }
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
            m_transactionHistoryController.ExportTrasactionHistory();
        }

        private void TransactionHistoryDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_transactionHistoryController.OpenForm_ViewTransactionDetails();
        }





        #endregion

        private void btn_AddNewCustomer_Click(object sender, EventArgs e)
        {
            m_newTransactionController.AddNewCustomer();
        }
    }
}
