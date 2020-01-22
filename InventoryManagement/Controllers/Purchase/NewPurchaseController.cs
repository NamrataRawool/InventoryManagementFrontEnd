using InventoryManagement.EventHandlers.Purchase;
using InventoryManagement.Events;
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
            SetEventHandler(new EventHandler_NewPurchase(this));
        }

        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetUIControls();
            }
            InitializeComboBox_VendorName();
            InitializeComboBox_ProductName();
        }

        public void InitializeComboBox_ProductName()
        {
            var products = DataService.GetProductDataController().GetAll();
            if (products == null)
                return;

            var comboBox = m_UIControl.cb_productName;
            comboBox.Items.Clear();
            foreach (var product in products)
                comboBox.Items.Add(product.Name);
        }

        public void InitializeComboBox_VendorName()
        {
            var vendors = DataService.GetVendorDataController().GetAll();
            if (vendors == null)
                return;

            var comboBox = m_UIControl.cb_vendorName;
            comboBox.Items.Clear();
            foreach (var vendor in vendors)
                comboBox.Items.Add(vendor.CompanyName);
        }

        public void OnNewVendorAdded(int vendorID)
        {
            var vendor = DataService.GetVendorDataController().Get(vendorID);
            string name = vendor.CompanyName;
            m_UIControl.cb_vendorName.Items.Add(name);
        }

        public void OnNewProductAdded(int productID)
        {
            var product = DataService.GetProductDataController().Get(productID);
            string name = product.Name;
            m_UIControl.cb_productName.Items.Add(name);
        }

        public void ResetUIControls()
        {
            ResetProductsDataTable();
            ResetTextBoxes();
            ResetLabels();
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

            var discountRate = double.Parse(m_UIControl.tb_discount.Text);
            NewRow.Cells["PurchaseTable_DiscountRate"].Value = discountRate;

            double discountPerProduct = purchasePrice * discountRate / 100;
            double totalDiscount = discountPerProduct * quantity;
            NewRow.Cells["PurchaseTable_TotalDiscount"].Value = totalDiscount;

            UpdateUILabels();
            ResetProductDetails();
            ResetLabels();
        }

        public void InitilizeTextBoxes(ProductGet product)
        {
            m_UIControl.tb_barCode.Text = product.Barcode.ToString();
            m_UIControl.cb_productName.Text = product.Name;
            var stock = DataService.GetStockDataController().GetByProductID(product.ID);
            m_UIControl.tb_availableStock.Text = stock.AvailableQuantity.ToString();
        }

        public void OnUpdateProduct(int oldQuantity, double oldPurchasePrice, double oldDiscountRate)
        {
            if (GetTable().SelectedRows.Count <= 0)
                return;
            string purchasePrice = GetTable().CurrentRow.Cells["PurchaseTable_PurchasePrice"].Value.ToString();
            var quantity = GetTable().CurrentRow.Cells["PurchaseTable_Quantity"].Value.ToString();
            var discountRate = GetTable().CurrentRow.Cells["PurchaseTable_DiscountRate"].Value.ToString();

            if (!Validator.IsInteger(quantity) || !Validator.IsValidDouble(purchasePrice) || !Validator.IsValidDouble(discountRate))
            {
                GetTable().CurrentRow.Cells["PurchaseTable_PurchasePrice"].Value = oldPurchasePrice;
                GetTable().CurrentRow.Cells["PurchaseTable_Quantity"].Value = oldQuantity;
                GetTable().CurrentRow.Cells["PurchaseTable_DiscountRate"].Value = oldDiscountRate;
                return;
            }

            var newPurchasePrice = double.Parse(purchasePrice);
            var newQuantity = int.Parse(quantity);
            var newDiscountRate = double.Parse(discountRate);

            if (newPurchasePrice <= 0 || newQuantity <= 0)
            {
                GetTable().CurrentRow.Cells["PurchaseTable_PurchasePrice"].Value = oldPurchasePrice;
                GetTable().CurrentRow.Cells["PurchaseTable_Quantity"].Value = oldQuantity;
                return;
            }
           
            double discountPerProduct = newPurchasePrice * newDiscountRate / 100;
            double totalDiscount = discountPerProduct * newQuantity;
            GetTable().CurrentRow.Cells["PurchaseTable_TotalDiscount"].Value = totalDiscount;
            UpdateUILabels();
        }

        public void OnDeleteProduct()
        {
            if (GetTable().SelectedRows.Count <= 0)
                return;
            int rowIndex = GetTable().CurrentCell.RowIndex;
            GetTable().Rows.RemoveAt(rowIndex);
            UpdateUILabels();
        }

        public void SavePurchase()
        {
            if (GetTable().Rows.Count <= 0)
                return;

            if (string.IsNullOrEmpty(m_UIControl.cb_vendorName.Text) || m_UIControl.cb_vendorName.Text.Equals("Select Vendor"))
            {
                m_UIControl.lbl_vendorError.Text = "Please select vendor!";
                return;
            }
            PurchasePost purchasePost = new PurchasePost();
            purchasePost.PurchaseDateTime = DateTime.Now;
            var vendorId = DataService.GetVendorDataController().GetByName(m_UIControl.cb_vendorName.Text.Trim()).ID;
            purchasePost.VendorID = vendorId;
            string productIds = string.Empty;
            string productQuantities = string.Empty;
            string buyingPrices = string.Empty;
            int i = 0;
            for (i = 0; i < GetTable().Rows.Count - 1; ++i)
            {
                productIds += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_ProductId"].Value) + ",";
                buyingPrices += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_PurchasePrice"].Value) + ",";
                productQuantities += Convert.ToInt32(GetTable().Rows[i].Cells["PurchaseTable_Quantity"].Value) + ",";
            }
            productIds += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_ProductId"].Value);
            buyingPrices += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_PurchasePrice"].Value);
            productQuantities += Convert.ToInt32(GetTable().Rows[i].Cells["PurchaseTable_Quantity"].Value);

            purchasePost.ProductIDs = productIds;
            purchasePost.ProductQuantities = productQuantities;
            purchasePost.BuyingPrices = buyingPrices;

            var purchase = DataService.GetPurchaseDataController().Post(purchasePost);

            if (purchase == null)
            {
                MessageBox.Show("Purchase entry failed! Please try saving again.");
                return;
            }
            MessageBox.Show("Purchase entry saved successfully!");
            ResetUIControls();
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
                totalDiscount += Convert.ToDouble(GetTable().Rows[i].Cells["PurchaseTable_TotalDiscount"].Value);

                amountDue += subtotal - totalDiscount;
            }
            m_UIControl.tb_subtotal.Text = subtotal.ToString();
            m_UIControl.tb_totalDiscount.Text = totalDiscount.ToString();
            m_UIControl.tb_amountDue.Text = amountDue.ToString();
        }

        private bool ValidateProductDetails()
        {
            if (string.IsNullOrEmpty(m_UIControl.tb_quantity.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter quantity";
                return false;
            }
            if (string.IsNullOrEmpty(m_UIControl.tb_purchasePrice.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter purchase price";
                return false;
            }
            if (string.IsNullOrEmpty(m_UIControl.tb_barCode.Text) && string.IsNullOrEmpty(m_UIControl.cb_productName.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please select product !";
                return false;
            }
            if (string.IsNullOrEmpty(m_UIControl.tb_discount.Text))
            {
                m_UIControl.lbl_errorText.Text = "Please enter purchase price";
                return false;
            }

            if (!Validator.IsInteger(m_UIControl.tb_barCode.Text) && !string.IsNullOrEmpty(m_UIControl.tb_barCode.Text))
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
            if (int.Parse(m_UIControl.tb_quantity.Text) <= 0)
            {
                m_UIControl.lbl_errorText.Text = "Quantity should be greater than 0!";
                return false;
            }
            if (double.Parse(m_UIControl.tb_purchasePrice.Text) <= 0)
            {
                m_UIControl.lbl_errorText.Text = "Purchase price should be greater than 0!";
                return false;
            }
            return true;
        }

        private void ResetTextBoxes()
        {
            ResetProductDetails();
            m_UIControl.tb_subtotal.Text = string.Empty;
            m_UIControl.tb_totalDiscount.Text = string.Empty;
            m_UIControl.tb_amountDue.Text = string.Empty;
        }

        private void ResetProductDetails()
        {
            m_UIControl.cb_productName.Text = string.Empty;
            m_UIControl.tb_barCode.Text = string.Empty;
            m_UIControl.tb_availableStock.Text = string.Empty;
            m_UIControl.tb_purchasePrice.Text = string.Empty;
            m_UIControl.tb_quantity.Text = string.Empty;
            m_UIControl.tb_discount.Text = string.Empty;
            m_UIControl.tb_barCode.Focus();
        }

        private void ResetLabels()
        {
            m_UIControl.lbl_vendorError.Text = string.Empty;
            m_UIControl.lbl_errorText.Text = string.Empty;
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
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }

    }
}
