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
    public class FormController_ViewBill : IController<Form_ViewBill>
    {
        TransactionSession m_transactionSession;

        public FormController_ViewBill(TransactionSession transactionSession, Form_ViewBill UIControl)
            : base(UIControl)
        {
            m_transactionSession = transactionSession;
            Initialize();
        }
        private void Initialize()
        {
            ResetViewBillTable();
            InitializeLabels();
            InitializeViewBillTable();
        }


        public void SaveTransaction()
        {
            TransactionPost transactionPost = new TransactionPost();
            transactionPost.CustomerID = m_transactionSession.GetCustomer().ID;
            transactionPost.TransactionDateTime = DateTime.Now;
            transactionPost.TotalPrice = double.Parse(m_transactionSession.amountDue);
            string productIds = string.Empty;
            string productQuantity = string.Empty;
            foreach (var product in m_transactionSession.GetRowEntries())
            {
                productIds += product.Product.ID + ",";
                productQuantity += product.Product.Quantity + ",";
            }

            //Removing last comma
            transactionPost.ProductIDs = productIds.Substring(0, productIds.Length - 1);
            transactionPost.ProductQuantity = productQuantity.Substring(0, productQuantity.Length - 1);
            var transaction = DataService.Get().GetTransactionDataController().Post(transactionPost);
            UpdateCustomerDetails();
        }
        private void UpdateCustomerDetails()
        {
            //Update customer details
            var customer = m_transactionSession.GetCustomer();
            if (customer.ID == 0)
                return;

            CustomerPost customerPost = new CustomerPost();
            customerPost.ID = customer.ID;
            customerPost.MobileNumber = customer.MobileNumber;
            customerPost.Name = customer.Name;
            customerPost.Email = customer.Email;
            customerPost.TotalAmount = customer.TotalAmount + double.Parse(m_transactionSession.amountDue);
            customerPost.PendingAmount = customer.PendingAmount + (double.Parse(m_transactionSession.amountDue) - double.Parse(m_transactionSession.amountPaid));
            var c = DataService.Get().GetCustomerDataController().Put(customerPost);
        }

        private void InitializeViewBillTable()
        {
            foreach (var entry in m_transactionSession.GetRowEntries())
            {
                AddRowToViewBillTable(entry);
            }
        }

        private void AddRowToViewBillTable(BillProductDetails productDetails)
        {
            var Table = GetViewBillTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["ViewBillTable_ProductId"].Value = productDetails.Product.ID;
            NewRow.Cells["ViewBillTable_ProductName"].Value = productDetails.Product.Name;
            NewRow.Cells["ViewBillTable_Quantity"].Value = productDetails.Product.Quantity;
            NewRow.Cells["ViewBillTable_FinalPrice"].Value = productDetails.FinalPrice;
        }
        private double CalculateDiscountedPrice(ProductGet product)
        {
            double discountInRupees = product.RetailPrice * (product.Discount / 100);
            return product.RetailPrice - discountInRupees;
        }
        private void ResetViewBillTable()
        {
            var Table = GetViewBillTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private DataGridView GetViewBillTable()
        {
            return m_UIControl.ViewBill_ProductsDataView;
        }
        private void InitializeLabels()
        {
            if (m_transactionSession.GetCustomer().Name == null)
                m_UIControl.lbl_CustomerName.Text = "--";
            else
                m_UIControl.lbl_CustomerName.Text = m_transactionSession.GetCustomer().Name;
            m_UIControl.lbl_Date.Text = DateTime.Now.ToString();
            m_UIControl.lbl_TotalPrice.Text = m_transactionSession.amountDue;
            m_UIControl.lbl_amountPaid.Text = m_transactionSession.amountPaid;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
