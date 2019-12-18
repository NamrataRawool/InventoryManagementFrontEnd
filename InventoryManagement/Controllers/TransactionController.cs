using InventoryManagement.EventHandlers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.UI.UserControls;
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
            NewRow.Cells["BillTable_Discount"].Value = Entry.Discount;
            NewRow.Cells["BillTable_Quantity"].Value = Entry.Quantity;
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.UI_Transaction_AddProduct);
        }
    }
}
