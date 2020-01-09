using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
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
            transactionPost.TotalPrice = Convert.ToInt32(m_transactionSession.subtotal);
            string productIds = string.Empty;
            string productQuantity = string.Empty;
            foreach (var product in m_transactionSession.GetRowEntries())
            {
                productIds += product.ID + ",";
                productQuantity += product.Quantity + ",";
            }

            //Removing last comma
            transactionPost.ProductIDs = productIds.Substring(0, productIds.Length - 1);
            transactionPost.ProductQuantity = productQuantity.Substring(0, productQuantity.Length - 1);
            var transaction = HTTPService.POST<TransactionGet, TransactionPost>("Transaction", transactionPost);
        }

        private void InitializeViewBillTable()
        {
            foreach (var product in m_transactionSession.GetRowEntries())
            {
                AddRowToViewBillTable(product);
            }
        }

        private void AddRowToViewBillTable(ProductGet product)
        {
            var Table = GetViewBillTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["ViewBillTable_ProductId"].Value = product.ID;
            NewRow.Cells["ViewBillTable_ProductName"].Value = product.Name;
            NewRow.Cells["ViewBillTable_Quantity"].Value = product.Quantity;
            NewRow.Cells["ViewBillTable_TotalPrice"].Value = product.RetailPrice;
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
            m_UIControl.lbl_totalTax.Text = m_transactionSession.totalTax;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
