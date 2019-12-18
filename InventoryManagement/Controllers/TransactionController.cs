using InventoryManagement.EventHandlers.Bill;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.UI.UserControls;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagement.Controllers
{

    class TransactionController : IController
    {

        TransactionControl m_UIControl;

        public TransactionController(TransactionControl UIControl)
        {
            m_UIControl = UIControl;
            RegisterEventHandlers();
        }

        protected override void RegisterEventHandlers()
        {
            RegisterEvent(EventType.UI_Transaction_AddProduct, new EH_TransactionAddProduct(this));
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

    }
}
