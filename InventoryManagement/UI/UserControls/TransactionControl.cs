using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Models;
using InventoryManagement.Events;
using InventoryManagement.Broadcaster;
using InventoryManagement.Controllers;

namespace InventoryManagement.UI.UserControls
{
    public partial class TransactionControl : UserControl
    {
        TransactionController m_Controller;
        BillRowEntry oldBillRowEntry;

        public TransactionControl()
        {
            m_Controller = new TransactionController(this);

            InitializeComponent();
        }

        private void Bill_ProductsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_Controller.UpdateBillProductsDataRow(oldBillRowEntry);
        }

        private void Bill_ProductsDataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var rows = Bill_ProductsDataView.SelectedRows;
            if (rows.Count > 0)
            {
                oldBillRowEntry = new BillRowEntry();
                int selectedRowIndex = Bill_ProductsDataView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Bill_ProductsDataView.Rows[selectedRowIndex];
                oldBillRowEntry.Price = int.Parse(selectedRow.Cells["BillTable_Price"].Value.ToString());
                var discountedPrice = int.Parse(selectedRow.Cells["BillTable_Discount"].Value.ToString());
                oldBillRowEntry.Quantity = int.Parse(selectedRow.Cells["BillTable_Quantity"].Value.ToString());
                oldBillRowEntry.Discount = (discountedPrice * 100) / (oldBillRowEntry.Price * oldBillRowEntry.Quantity);
            }
        }

    }
}
