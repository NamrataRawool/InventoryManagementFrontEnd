using InventoryManagement.Services.Data;
using InventoryManagement.UI.UserControls;
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
            ResetTExtBoxes();
        }
        private void ResetTExtBoxes()
        {
            m_UIControl.tb_barCode.Text = string.Empty;
            m_UIControl.tb_availableStock.Text = string.Empty;
            m_UIControl.tb_purchasePrice.Text = string.Empty;
            m_UIControl.tb_quantity.Text = string.Empty;
            m_UIControl.tb_discount.Text = string.Empty;
            m_UIControl.tb_subtotal.Text = string.Empty;
            m_UIControl.tb_totalDiscount.Text = string.Empty;
            m_UIControl.tb_amountDue.Text = string.Empty;
            m_UIControl.tb_totalTax.Text = string.Empty;
            m_UIControl.tb_AmountPaid.Text = string.Empty;
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
