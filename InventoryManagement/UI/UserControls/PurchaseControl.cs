using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Controllers.Purchase;
using InventoryManagement.Utilities;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Vendor;

namespace InventoryManagement.UI.UserControls
{
    public partial class PurchaseControl : UserControl
    {

        NewPurchaseController m_newPurchaseController;
        PurchaseHistoryController m_purchaseHistoryController;

        int quantity = 0;
        double purchasePrice = 0;
        double discountRate = 0;

        public PurchaseControl()
        {
            InitializeComponent();
            m_newPurchaseController = new NewPurchaseController(this);
            m_purchaseHistoryController = new PurchaseHistoryController(this);
        }

        private void PurchaseControl_Load(object sender, EventArgs e)
        {
            m_newPurchaseController.Initialize();
        }

        #region NewPurchase

        private void btn_reset_Click(object sender, EventArgs e)
        {
            m_newPurchaseController.ResetUIControls();
        }

        private void tb_barCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(tb_barCode.Text))
                    return;

                if (!Validator.IsInteger(tb_barCode.Text))
                {
                    lbl_errorText.Text = "Please enter valid bar code";
                    return;
                }

                lbl_errorText.Text = string.Empty;

                string barcode = tb_barCode.Text;
                var product = DataService.GetProductDataController().GetByBarcode(barcode);
                if (product == null)
                {
                    lbl_errorText.Text = "Record not found";
                    return;
                }

                m_newPurchaseController.InitializeTextBoxes(product);
            }
        }

        private void cb_productName_SelectedValueChanged(object sender, EventArgs e)
        {
            lbl_errorText.Text = string.Empty;

            var productName = cb_productName.Text;
            var product = DataService.GetProductDataController().GetByName(productName);

            if (product == null)
            {
                lbl_errorText.Text = "Record not found";
                return;
            }
            m_newPurchaseController.InitializeTextBoxes(product);
        }

        private void tb_quantity_KeyDown(object sender, KeyEventArgs e)
        {
            lbl_errorText.Text = string.Empty;
            if (e.KeyCode == Keys.Enter)
            {
                m_newPurchaseController.OnAddProduct();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            m_newPurchaseController.OnAddProduct();
        }

        private void Purchase_ProductsDataView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                m_newPurchaseController.OnDeleteProduct();
            }
        }

        private void btn_ViewPuchaseBill_Click(object sender, EventArgs e)
        {
            m_newPurchaseController.SavePurchase();
        }

        private void Purchase_ProductsDataView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            purchasePrice = double.Parse(Purchase_ProductsDataView.CurrentRow.Cells["PurchaseTable_PurchasePrice"].Value.ToString());
            quantity = int.Parse(Purchase_ProductsDataView.CurrentRow.Cells["PurchaseTable_Quantity"].Value.ToString());
            discountRate = double.Parse(Purchase_ProductsDataView.CurrentRow.Cells["PurchaseTable_DiscountRate"].Value.ToString());
        }

        private void Purchase_ProductsDataView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            m_newPurchaseController.OnUpdateProduct(quantity, purchasePrice, discountRate);
        }
        #endregion

        #region Purchase History
        private void btn_searchByDate_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime_fromDate.Text;
            var toDate = DateTime_toDate.Text;
            m_purchaseHistoryController.SearchPurchaseByDate(fromDate, toDate);
        }

        private void btn_ResetTransactionHistory_Click(object sender, EventArgs e)
        {
            m_purchaseHistoryController.ResetTable_PurchaseHistory();
        }

        private void btn_searchByVendorName_Click(object sender, EventArgs e)
        {
            lbl_purchaseSearchError.Text = string.Empty;
            if (cb_VendorName_History.SelectedIndex < 0)
            {
                lbl_purchaseSearchError.Text = "Please select vendor!";
                return;
            }
            var vendorName = cb_VendorName_History.Text.Trim();
            m_purchaseHistoryController.SearchPurchaseByVendorName(vendorName);
        }

        private void PurchaseHistoryDataView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            m_purchaseHistoryController.OpenForm_ViewPurchaseBill();
        }

        #endregion

        private void btn_AddNewVendor_Click(object sender, EventArgs e)
        {
            lbl_vendorError.Text = string.Empty;
            Form_AddVendor form = new Form_AddVendor();
            form.DisableAddAnotherFunctionality();
            form.ShowDialog();

            if (form.DialogResult != DialogResult.OK)
                return;

            var vendor = form.GetVendor();
            cb_vendorName.Text = vendor.CompanyName;
        }

        private void btn_AddNewProduct_Click(object sender, EventArgs e)
        {
            var product = m_newPurchaseController.OpenForm_AddProduct();
            m_newPurchaseController.InitializeTextBoxes(product);
        }
    }
}
