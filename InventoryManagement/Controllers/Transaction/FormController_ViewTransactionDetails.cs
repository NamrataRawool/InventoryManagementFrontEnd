using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Transaction;
using System;
using System.Collections.Generic;
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
            var transaction = DataService.Get().GetTransactionDataController().Get(transasctionId);
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
            m_UIControl.lbl_TotalPrice.Text = transaction.TotalPrice.ToString();

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
        private void AddRowTotheProductDetails(ProductDetails productDetails)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["TransactionTable_ProductId"].Value = productDetails.Product.ID;
            NewRow.Cells["TransactionTable_ProductName"].Value = productDetails.Product.Name;
            NewRow.Cells["TransactionTable_Quantity"].Value = productDetails.Quantity;
            NewRow.Cells["TransactionTable_ActualPrice"].Value = productDetails.Quantity * productDetails.Product.RetailPrice;
            NewRow.Cells["TransactionTable_DiscountedPrice"].Value = productDetails.Quantity * CalculateDiscountedPrice(productDetails);
        }

        private double CalculateDiscountedPrice(ProductDetails productDetails)
        {
            double discountInRupees = productDetails.Product.RetailPrice * (productDetails.Product.Discount / 100);
            return productDetails.Product.RetailPrice - discountInRupees;
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
