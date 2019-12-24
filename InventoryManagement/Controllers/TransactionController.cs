using InventoryManagement.EventHandlers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.UI.UserControls;
using System;
using System.Windows.Forms;

namespace InventoryManagement.Controllers
{

    public class TransactionController : IController<TransactionControl>
    {
        public TransactionController(TransactionControl UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Transaction(this));
        }

        public void AddProductRowToTable(BillRowEntry Entry)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;
            int Index = GridView.Rows.Add();

            DataGridViewRow NewRow = GridView.Rows[Index];
            NewRow.Cells["BillTable_Name"].Value = Entry.ProductName;
            NewRow.Cells["BillTable_Price"].Value = Entry.Price;
            double discountInRupees = (Entry.Price * Entry.Discount / 100);
            NewRow.Cells["BillTable_Discount"].Value = discountInRupees * Entry.Quantity;
            NewRow.Cells["BillTable_Quantity"].Value = Entry.Quantity;
            NewRow.Cells["BillTable_TotalPrice"].Value = CalculateTotalPrice(Entry.Price, Entry.Discount, Entry.Quantity);
            UpdateUILabels();
        }
        private void UpdateUILabels()
        {
            var subtotal = 0;
            var totalDiscount = 0;
            for (int i = 0; i < m_UIControl.Bill_ProductsDataView.Rows.Count; ++i)
            {
                subtotal += Convert.ToInt32(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_TotalPrice"].Value);
                totalDiscount += Convert.ToInt32(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Discount"].Value);
            }
            m_UIControl.lbl_subTotal.Text = subtotal.ToString();
            m_UIControl.lbl_discountedPrice.Text = totalDiscount.ToString();
        }

        private double CalculateTotalPrice(int price, double discountRate, int quantity)
        {
            double discountInRupees = (price * discountRate / 100);
            double discountedPrice = price - discountInRupees;
            double totalPrice = discountedPrice * quantity;
            return totalPrice;
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
        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.UI_Transaction_AddProduct);
        }
    }
}
