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

namespace InventoryManagement.UI.UserControls
{
    public partial class PurchaseControl : UserControl
    {
        NewPurchaseController m_newPurchaseController;

        public PurchaseControl()
        {
            InitializeComponent();
            m_newPurchaseController = new NewPurchaseController(this);
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

                m_newPurchaseController.InitilizeTextBoxes(product);
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
            m_newPurchaseController.InitilizeTextBoxes(product);
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
        #endregion


    }
}
