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
        
        public FormController_ViewBill(TransactionGet transaction, Form_ViewBill UIControl)
            : base(UIControl)
        {
            Initialize(transaction);
        }
        private void Initialize(TransactionGet transaction)
        {
            ResetViewBillTable();
            InitializeLabels(transaction);
            InitializeViewBillTable(transaction.ProductDetails);
        }

        private void InitializeViewBillTable(List<ProductGet> products)
        {
            foreach (var product in products)
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
        private void InitializeLabels(TransactionGet transaction)
        {
            m_UIControl.lbl_CustomerName.Text = transaction.Customer.Name;
            m_UIControl.lbl_Date.Text = transaction.TransactionDateTime.ToString();
            m_UIControl.lbl_TotalPrice.Text = transaction.TotalPrice.ToString();
            m_UIControl.lbl_totalTax.Text = transaction.TotalPrice.ToString();
        }
        protected override void RegisterEvents()
        {

        }
    }
}
