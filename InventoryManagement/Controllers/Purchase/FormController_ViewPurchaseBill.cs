using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Purchase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Purchase
{
    public class FormController_ViewPurchaseBill : IController<Form_ViewPuchaseBill>
    {
        public FormController_ViewPurchaseBill(int purchaseId, Form_ViewPuchaseBill UIControl) : base(UIControl)
        {
            Initialize(purchaseId);
        }
        public void Initialize(int purchaseId)
        {
            var purchase = DataService.GetPurchaseDataController().Get(purchaseId);
            ResetTable();
            InitializeLabels(purchase);
            InitializeProductDetailsTable(purchase);
        }
        private void InitializeLabels(PurchaseGet purchase)
        {
            if (purchase.Vendor == null)
                m_UIControl.lbl_VendorName.Text = "--";
            else
                m_UIControl.lbl_VendorName.Text = purchase.Vendor.CompanyName;
            m_UIControl.lbl_PurchaseDate.Text = purchase.PurchaseDateTime.ToString();
            double totalPrice = 0.0;
            foreach (var product in purchase.ProductDetails)
            {
                totalPrice += product.BuyingPrice;
            }
            m_UIControl.lbl_TotalPrice.Text = totalPrice.ToString();
        }
        private void InitializeProductDetailsTable(PurchaseGet purchase)
        {
            foreach (var productDetails in purchase.ProductDetails)
            {
                AddRowToTable(productDetails);
            }
        }
        private void AddRowToTable(PurchaseProductDetails productDetails)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["PurchaseTable_ProductId"].Value = productDetails.Product.ID;
            NewRow.Cells["PurchaseTable_ProductName"].Value = productDetails.Product.Name;
            NewRow.Cells["PurchaseTable_Quantity"].Value = productDetails.Quantity;
            NewRow.Cells["PurchaseTable_PurchasePrice"].Value = productDetails.BuyingPrice;
        }
        private void ResetTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }
        private DataGridView GetTable()
        {
            return m_UIControl.PurchaseBill_ProductsDataView;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
