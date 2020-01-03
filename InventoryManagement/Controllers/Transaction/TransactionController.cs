using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Transaction;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Transaction
{

    public class TransactionController : IController<TransactionControl>
    {
        public TransactionController(TransactionControl UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Transaction(this));
        }

        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetTransaction();
            }

        }

        public void OnAddProduct(BillRowEntry Entry)
        {
            Event_TransactionAddProduct Event = new Event_TransactionAddProduct(Entry);
            EventBroadcaster.Get().BroadcastEvent(Event);
        }

        public void OnDeleteProduct()
        {
            foreach (DataGridViewRow row in m_UIControl.Bill_ProductsDataView.SelectedRows)
            {
                m_UIControl.Bill_ProductsDataView.Rows.RemoveAt(row.Index);
                UpdateUILabels();
            }
        }

        public void AddProductRowToTable(BillRowEntry Entry)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;

            foreach (DataGridViewRow row in GridView.Rows)
            {
                var productName = row.Cells["BillTable_Name"].Value;
                if (productName != null && productName.Equals(Entry.ProductName))
                {
                    row.Cells["BillTable_ProductId"].Value = Entry.ProductId;
                    var newQuantity = Convert.ToInt32(row.Cells["BillTable_Quantity"].Value) + Entry.Quantity;
                    row.Cells["BillTable_Quantity"].Value = newQuantity;
                    double discount = (Entry.Price * Entry.Discount / 100);
                    row.Cells["BillTable_Discount"].Value = discount * newQuantity;
                    row.Cells["BillTable_TotalPrice"].Value = CalculateTotalPrice(Entry.Price, Entry.Discount, newQuantity);
                    return;
                }
            }

            int Index = GridView.Rows.Add();

            DataGridViewRow NewRow = GridView.Rows[Index];
            NewRow.Cells["BillTable_ProductId"].Value = Entry.ProductId;
            NewRow.Cells["BillTable_Name"].Value = Entry.ProductName;
            NewRow.Cells["BillTable_Price"].Value = Entry.Price;
            double discountInRupees = (Entry.Price * Entry.Discount / 100);
            NewRow.Cells["BillTable_Discount"].Value = discountInRupees * Entry.Quantity;
            NewRow.Cells["BillTable_Quantity"].Value = Entry.Quantity;
            NewRow.Cells["BillTable_TotalPrice"].Value = CalculateTotalPrice(Entry.Price, Entry.Discount, Entry.Quantity);

            UpdateUILabels();
        }

        public void UpdateBillProductsDataRow(BillRowEntry oldBillRowEntry)
        {
            var rows = m_UIControl.Bill_ProductsDataView.SelectedRows;
            if (rows.Count > 0)
            {
                int selectedRowIndex = m_UIControl.Bill_ProductsDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = m_UIControl.Bill_ProductsDataView.Rows[selectedRowIndex];
                int newQuantity = Convert.ToInt32(selectedRow.Cells["BillTable_Quantity"].Value);

                selectedRow.Cells["BillTable_TotalPrice"].Value = CalculateTotalPrice(oldBillRowEntry.Price, oldBillRowEntry.Discount, newQuantity);

                double discountInRupees = (oldBillRowEntry.Price * oldBillRowEntry.Discount / 100);
                selectedRow.Cells["BillTable_Discount"].Value = discountInRupees * newQuantity;

                UpdateUILabels();
            }
        }
        public void SaveTransaction()
        {
            TransactionPost transactionPost = new TransactionPost();
            transactionPost.CustomerID = 1;
            transactionPost.TransactionDateTime = DateTime.Now;
            transactionPost.TotalPrice = double.Parse(m_UIControl.tb_subtotal.Text);
            string productIds = string.Empty;
            string productQuantity = string.Empty;
            int i = 0;
            for (i = 0; i < m_UIControl.Bill_ProductsDataView.Rows.Count - 1; ++i)
            {
                productIds += m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_ProductId"].Value + ",";
                productQuantity += m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Quantity"].Value + ",";
            }
            productIds += m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_ProductId"].Value;
            productQuantity += m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Quantity"].Value;
            transactionPost.ProductIDs = productIds;
            transactionPost.ProductQuantity = productQuantity;

            var transaction = HTTPService.POST<TransactionGet, TransactionPost>("Transaction", transactionPost);
            ViewBill(transaction);
            ResetTransaction();
        }

        public void ViewBill(TransactionGet transaction)
        {
            Form_ViewBill viewBill = new Form_ViewBill(transaction);
            viewBill.ShowDialog();
        }
        public void SearchTransactionByCustomerName(string name)
        {
            m_UIControl.lbl_transactionError.Text = string.Empty;
            int customerID = HTTPService.GET<CustomerGet>("Customer/name=" + name).ID;
            List<TransactionGet> transactions = HTTPService.GET<List<TransactionGet>>("Transaction/customerId=" + customerID);
            if (transactions.Count == 0)
                m_UIControl.lbl_transactionError.Text = "Transaction not found";
            InitializeTransactionHistoryTable(transactions);
        }

        public void SearchTransactionsByDate(string from, string to)
        {
            m_UIControl.lbl_transactionError.Text = string.Empty;
            List<TransactionGet> transactions = HTTPService.GET<List<TransactionGet>>("Transaction/from=" + from + "&to=" + to);
            if (transactions.Count == 0)
                m_UIControl.lbl_transactionError.Text = "Transaction not found";
            InitializeTransactionHistoryTable(transactions);
        }

        private void UpdateUILabels()
        {
            double subtotal = 0;
            double totalDiscount = 0;
            for (int i = 0; i < m_UIControl.Bill_ProductsDataView.Rows.Count; ++i)
            {
                subtotal += Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_TotalPrice"].Value);
                totalDiscount += Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Discount"].Value);
            }
            m_UIControl.tb_subtotal.Text = subtotal.ToString();
            m_UIControl.tb_totalDiscount.Text = totalDiscount.ToString();
        }

        private double CalculateTotalPrice(int price, double discountRate, int quantity)
        {
            double discountInRupees = (price * discountRate / 100);
            double discountedPrice = price - discountInRupees;
            double totalPrice = discountedPrice * quantity;
            return totalPrice;
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
            NewRow.Cells["Transaction_CustomerName"].Value = transaction.Customer.Name;
            string[] productQuantity = transaction.ProductQuantity.Split(',');
            int qauntity = 0;
            foreach (string pq in productQuantity)
            {
                qauntity += Convert.ToInt32(pq);
            }

            NewRow.Cells["Transaction_Quantity"].Value = qauntity;
            NewRow.Cells["Transaction_TotalPrice"].Value = transaction.TotalPrice; ;
        }

        public void ResetTransaction()
        {
            ResetTransactionHistoryTable();
            ResetBillProductsTable();
            m_UIControl.tb_subtotal.Text = string.Empty;
            m_UIControl.tb_totalDiscount.Text = string.Empty;
        }
        private void ResetBillProductsTable()
        {
            var Table = m_UIControl.Bill_ProductsDataView;
            Table.Rows.Clear();
            Table.Refresh();
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
            RegisterEvent(EventType.UI_Transaction_AddProduct);
        }
    }
}
