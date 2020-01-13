using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Transaction;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Transaction
{
    public class TransactionHistoryController : IController<TransactionControl>
    {
        public TransactionHistoryController(TransactionControl UIControl)
             : base(UIControl)
        {

        }

        public void SearchTransactionsByDate(string from, string to)
        {
            m_UIControl.lbl_transactionError.Text = string.Empty;

            List<TransactionGet> transactions = DataService.GetTransactionDataController().GetByDate(DateTime.Parse(from), DateTime.Parse(to));
            if (transactions.Count == 0)
                m_UIControl.lbl_transactionError.Text = "Transaction not found";
            InitializeTransactionHistoryTable(transactions);
        }


        public void SearchTransactionByCustomerName(string name)
        {
            m_UIControl.lbl_transactionError.Text = string.Empty;
            int customerID = DataService.GetCustomerDataController().GetByName(name).ID;
            List<TransactionGet> transactions = DataService.GetTransactionDataController().GetByCustomerID(customerID);
            if (transactions.Count == 0)
                m_UIControl.lbl_transactionError.Text = "Transaction not found";
            InitializeTransactionHistoryTable(transactions);
        }

        public void OpenForm_ViewTransactionDetails()
        {
            var Table = GetTransactionHistoryTable();
            var transasctionId = Convert.ToInt32(Table.CurrentRow.Cells["Transaction_ID"].Value);
            Form_ViewTransactionDetails transactionDetails = new Form_ViewTransactionDetails(transasctionId);
            transactionDetails.ShowDialog();
        }

        public void InitializeTransactionHistoryTable(List<TransactionGet> transactions)
        {
            ResetTransactionHistoryTable();
            foreach (var transaction in transactions)
                AddTransactionToHistoryTable(transaction);
        }


        private void AddTransactionToHistoryTable(TransactionGet transaction)
        {
            var Table = GetTransactionHistoryTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["Transaction_ID"].Value = transaction.ID;
            NewRow.Cells["Transaction_Date"].Value = transaction.TransactionDateTime;
            if (transaction.Customer != null)
                NewRow.Cells["Transaction_CustomerName"].Value = transaction.Customer.Name;
            else
                NewRow.Cells["Transaction_CustomerName"].Value = "--";
            string[] productQuantity = transaction.ProductQuantity.Split(',');
            int qauntity = 0;
            foreach (string pq in productQuantity)
            {
                qauntity += Convert.ToInt32(pq);
            }
            NewRow.Cells["Transaction_TotalPrice"].Value = transaction.TotalPrice; ;
        }

        private void ResetTransactionHistoryTable()
        {
            var Table = GetTransactionHistoryTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private DataGridView GetTransactionHistoryTable()
        {
            return m_UIControl.TransactionHistoryDataView;
        }

        protected override void RegisterEvents()
        {

        }
    }
}
