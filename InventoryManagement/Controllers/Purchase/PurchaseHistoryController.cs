using InventoryManagement.EventHandlers.Purchase;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Purchase;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Purchase
{
    public class PurchaseHistoryController : IController<PurchaseControl>
    {
        public PurchaseHistoryController(PurchaseControl UIControl) : base(UIControl)
        {
            SetEventHandler(new EventHandler_PurchaseHistory(this));

            ResetTable_PurchaseHistory();
            InitializeComboBox_VendorName();
        }

        public void InitializeComboBox_VendorName()
        {
            var vendors = DataService.GetVendorDataController().GetAll();
            if (vendors == null)
                return;

            var comboBox = m_UIControl.cb_VendorName_History;
            comboBox.Items.Clear();

            foreach (var vendor in vendors)
                comboBox.Items.Add(vendor.CompanyName);
        }

        public void AddToComboBox_VendorName(string name)
        {
            var comboBox = m_UIControl.cb_VendorName_History;
            comboBox.Items.Add(name);
        }

        public void SearchPurchaseByVendorName(string name)
        {
            m_UIControl.lbl_purchaseSearchError.Text = string.Empty;
            var vendor = DataService.GetVendorDataController().GetByName(name);
            if (vendor == null)
            {
                m_UIControl.lbl_purchaseSearchError.Text = "Vendor not found";
                return;
            }
            var purchases = DataService.GetPurchaseDataController().GetByVendorID(vendor.ID);
            if (purchases.Count == 0)
            {
                m_UIControl.lbl_purchaseSearchError.Text = "Purchases not found!";
                return;
            }
            InitializeTable_PurchaseHistory(purchases);
        }

        public void SearchPurchaseByDate(string from, string to)
        {
            m_UIControl.lbl_purchaseSearchError.Text = string.Empty;

            var purchases = DataService.GetPurchaseDataController().GetByDate(DateTime.Parse(from), DateTime.Parse(to));
            if (purchases.Count == 0)
            {
                m_UIControl.lbl_purchaseSearchError.Text = "Purchases not found!";
                return;
            }
            InitializeTable_PurchaseHistory(purchases);
        }

        public void OpenForm_ViewPurchaseBill()
        {
            var Table = GetPurchaseHistoryTable();
            var purchaseId = Convert.ToInt32(Table.CurrentRow.Cells["Purchase_ID"].Value);
            Form_ViewPuchaseBill viewPuchaseBill = new Form_ViewPuchaseBill(purchaseId);
            viewPuchaseBill.Show();
        }

        private void InitializeTable_PurchaseHistory(List<PurchaseGet> purchases)
        {
            ResetTable_PurchaseHistory();
            foreach (var transaction in purchases)
                AddPurchaseToHistoryTable(transaction);
        }

        private void AddPurchaseToHistoryTable(PurchaseGet purchase)
        {
            var Table = GetPurchaseHistoryTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["Purchase_Date"].Value = purchase.PurchaseDateTime;
            NewRow.Cells["Purchase_ID"].Value = purchase.ID;
            NewRow.Cells["Purchase_VendorName"].Value = purchase.Vendor.CompanyName;
            double totalPrice = 0.0;
            foreach (var productDetails in purchase.ProductDetails)
            {
                totalPrice += productDetails.BuyingPrice;
            }
            NewRow.Cells["Purchase_TotalPrice"].Value = totalPrice;
        }

        public void ResetTable_PurchaseHistory()
        {
            var Table = GetPurchaseHistoryTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private DataGridView GetPurchaseHistoryTable()
        {
            return m_UIControl.PurchaseHistoryDataView;
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }
    }
}
