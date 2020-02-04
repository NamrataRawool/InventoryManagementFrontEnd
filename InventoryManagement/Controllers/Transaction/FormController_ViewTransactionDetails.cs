using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Transaction;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Transaction
{
    public class FormController_ViewTransactionDetails : IController<Form_ViewTransactionDetails>
    {
        public FormController_ViewTransactionDetails(int transasctionId, Form_ViewTransactionDetails UIControl) : base(UIControl)
        {
            Initialize(transasctionId);
        }

        public void Initialize(int transasctionId)
        {
            var transaction = DataService.GetTransactionDataController().Get(transasctionId);
            ResetTable();
            InitializeLabels(transaction);
            InitializeTable(transaction);
        }

        private void InitializeLabels(TransactionGet transaction)
        {
            if (transaction.Customer == null)
                m_UIControl.lbl_CustomerName.Text = "--";
            else
                m_UIControl.lbl_CustomerName.Text = transaction.Customer.Name;
            m_UIControl.lbl_transactionNumber.Text = transaction.ID.ToString();
            m_UIControl.lbl_Date.Text = transaction.TransactionDateTime.ToString();

            NumberFormatInfo indianCurrency = new CultureInfo("hi-IN", false).NumberFormat;
            indianCurrency.CurrencyPositivePattern = 2;

            m_UIControl.lbl_TotalPrice.Text = String.Format(indianCurrency, "{0:c}", transaction.TotalPrice);
            m_UIControl.lbl_totalTax.Text = String.Format(indianCurrency, "{0:c}", transaction.TotalTax);
        }
        private DataGridView GetTable()
        {
            return m_UIControl.transaction_productDetailsView;
        }
        private void InitializeTable(TransactionGet transaction)
        {
            foreach (var product in transaction.ProductDetailsList)
            {
                AddRowTotheProductDetails(product);
            }
        }
        private void AddRowTotheProductDetails(TransactionProductDetails productDetails)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["TransactionTable_ProductId"].Value = productDetails.Product.ID;
            NewRow.Cells["TransactionTable_ProductName"].Value = productDetails.Product.Name;
            NewRow.Cells["TransactionTable_Quantity"].Value = productDetails.Quantity;
            NewRow.Cells["TransactionTable_ActualPrice"].Value = productDetails.Quantity * productDetails.BuyingPrice;
            NewRow.Cells["TransactionTable_DiscountedPrice"].Value = productDetails.Quantity * CalculateDiscountedPrice(productDetails);
        }

        private double CalculateDiscountedPrice(TransactionProductDetails productDetails)
        {
            double discountInRupees = productDetails.BuyingPrice * (productDetails.Discount / 100);
            return productDetails.BuyingPrice - discountInRupees;
        }
        private void ResetTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }
        protected override void RegisterEvents()
        {

        }
    }
}
