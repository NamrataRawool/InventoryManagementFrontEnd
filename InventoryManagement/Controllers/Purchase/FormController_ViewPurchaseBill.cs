using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Purchase;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            double amountPaid = 0.0;
            for (int i = 0; i < GetTable().Rows.Count; ++i)
            {
                totalPrice += double.Parse(GetTable().Rows[i].Cells["PurchaseTable_ActualPrice"].Value.ToString());
                amountPaid += double.Parse(GetTable().Rows[i].Cells["PurchaseTable_DiscountedPrice"].Value.ToString());
            }
            NumberFormatInfo indianCurrency = new CultureInfo("hi-IN", false).NumberFormat;
            indianCurrency.CurrencyPositivePattern = 2;
            var totalDiscount = totalPrice - amountPaid;
            m_UIControl.lbl_TotalDiscount.Text = String.Format(indianCurrency, "{0:c}", totalDiscount);
            m_UIControl.lbl_TotalPrice.Text = String.Format(indianCurrency, "{0:c}", totalPrice);
            m_UIControl.lbl_amountPaid.Text = String.Format(indianCurrency, "{0:c}", amountPaid);
        }

        private void InitializeProductDetailsTable(PurchaseGet purchase)
        {
            foreach (var productDetails in purchase.ProductDetails)
            {
                AddRowToTable(productDetails);
            }
            InitializeLabels(purchase);
        }
        private void AddRowToTable(PurchaseProductDetails productDetails)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["PurchaseTable_ProductId"].Value = productDetails.Product.ID;
            NewRow.Cells["PurchaseTable_ProductName"].Value = productDetails.Product.Name;
            NewRow.Cells["PurchaseTable_Quantity"].Value = productDetails.Quantity;
            var actualPrice = productDetails.BuyingPrice * productDetails.Quantity;
            NewRow.Cells["PurchaseTable_ActualPrice"].Value = actualPrice;
            double discountPerProduct = productDetails.BuyingPrice * productDetails.Discount / 100;
            double totalDiscount = discountPerProduct * productDetails.Quantity;
            NewRow.Cells["PurchaseTable_DiscountedPrice"].Value = actualPrice - totalDiscount;
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
