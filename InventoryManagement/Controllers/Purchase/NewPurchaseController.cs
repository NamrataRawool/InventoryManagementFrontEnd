using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.UserControls;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Purchase
{
    public class NewPurchaseController : IController<PurchaseControl>
    {
        public NewPurchaseController(PurchaseControl UIControl) : base(UIControl)
        {

        }
        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetUIControls();
            }
            InitializeVendorNameDataSource();
            InitializeProductNameDataSource();
        }
        private void InitializeVendorNameDataSource()
        {
            var vendors = DataService.GetVendorDataController().GetAll();
            if (vendors == null)
                return;

            List<string> VendorDataSource = new List<string>();
            foreach (var vendor in vendors)
                VendorDataSource.Add(vendor.CompanyName);

            m_UIControl.cb_vendorName.DataSource = VendorDataSource;
        }

        private void InitializeProductNameDataSource()
        {
            var products = DataService.GetProductDataController().GetAll();
            if (products == null)
                return;

            List<string> ProductDataSource = new List<string>();
            foreach (var product in products)
                ProductDataSource.Add(product.Name);

            m_UIControl.cb_productName.DataSource = ProductDataSource;
        }

        public void ResetUIControls()
        {
            ResetProductsDataTable();
            ResetTextBoxes();
        }

        public void OnAddProduct()
        {
            if (!ValidateProductDetails())
                return;
            var product = DataService.GetProductDataController().GetByName(m_UIControl.cb_productName.Text);
            AddProductRowToTable(product);
        }
        public void AddProductRowToTable(ProductGet product)
        {
            var gridView = GetTable();

            int Index = gridView.Rows.Add();

            DataGridViewRow NewRow = gridView.Rows[Index];
            NewRow.Cells["PurchaseTable_ProductId"].Value = product.ID;
            NewRow.Cells["PurchaseTable_Name"].Value = product.Name;
            double purchasePrice = double.Parse(m_UIControl.tb_purchasePrice.Text);
            NewRow.Cells["PurchaseTable_PurchasePrice"].Value = purchasePrice;
            int quantity = int.Parse(m_UIControl.tb_quantity.Text);
            NewRow.Cells["PurchaseTable_Quantity"].Value = quantity;
            double discountPerProduct = purchasePrice * double.Parse(m_UIControl.tb_discount.Text) / 100;
            double totalDiscount = discountPerProduct * quantity;
            NewRow.Cells["PurchaseTable_Discount"].Value = totalDiscount;
            UpdateUILabels();
            ResetProductDetails();
        }

        private void UpdateUILabels()
        {
            double subtotal = 0;
            double totalDiscount = 0;
            double amountDue = 0;
            for (int i = 0; i < GetTable().Rows.Count; ++i)
            {
                var actualPrice = Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_PurchasePrice"].Value);
                var quantity = Convert.ToInt32(GetTable().Rows[i].Cells["PurchaseTable_Quantity"].Value);
                subtotal += actualPrice * quantity;
                totalDiscount += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_Discount"].Value);

                amountDue += subtotal - totalDiscount;
            }
            m_UIControl.tb_subtotal.Text = subtotal.ToString();
            m_UIControl.tb_totalDiscount.Text = totalDiscount.ToString();
            m_UIControl.tb_amountDue.Text = amountDue.ToString();
        }
        private bool ValidateProductDetails()
        {
            if (String.IsNullOrEmpty(m_UIControl.tb_quantity.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter quantity";
                return false;
            }
            if (String.IsNullOrEmpty(m_UIControl.tb_purchasePrice.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter purchase price";
                return false;
            }
            if (String.IsNullOrEmpty(m_UIControl.tb_barCode.Text) || string.IsNullOrEmpty(m_UIControl.cb_productName.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please select product !";
                return false;
            }
            if (String.IsNullOrEmpty(m_UIControl.tb_discount.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter purchase price";
                return false;
            }

            if (!Validator.IsInteger(m_UIControl.tb_barCode.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter valid bar code!";
                return false;
            }
            if (!Validator.IsValidDouble(m_UIControl.tb_discount.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter valid discount!";
                return false;
            }
            if (!Validator.IsValidDouble(m_UIControl.tb_purchasePrice.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter valid purchase price!";
                return false;
            }
            if (!Validator.IsInteger(m_UIControl.tb_quantity.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter valid  quantity!";
                return false;
            }
            return true;
        }
        public void InitilizeTextBoxes(ProductGet product)
        {
            m_UIControl.tb_barCode.Text = product.ID.ToString();
            m_UIControl.cb_productName.Text = product.Name;
            var stock = DataService.GetStockDataController().GetByProductID(product.ID);
            m_UIControl.tb_availableStock.Text = stock.AvailableQuantity.ToString();
        }
        private void ResetTextBoxes()
        {
            ResetProductDetails();
            m_UIControl.tb_subtotal.Text = string.Empty;
            m_UIControl.tb_totalDiscount.Text = string.Empty;
            m_UIControl.tb_amountDue.Text = string.Empty;
            m_UIControl.tb_totalTax.Text = string.Empty;
            m_UIControl.tb_AmountPaid.Text = string.Empty;
        }
        private void ResetProductDetails()
        {
            m_UIControl.cb_productName.Text = string.Empty;
            m_UIControl.tb_barCode.Text = string.Empty;
            m_UIControl.tb_availableStock.Text = string.Empty;
            m_UIControl.tb_purchasePrice.Text = string.Empty;
            m_UIControl.tb_quantity.Text = string.Empty;
            m_UIControl.tb_discount.Text = string.Empty;
        }
        private void ResetProductsDataTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        private DataGridView GetTable()
        {
            return m_UIControl.Purchase_ProductsDataView;
        }
        protected override void RegisterEvents()
        {

        }
    }
}
