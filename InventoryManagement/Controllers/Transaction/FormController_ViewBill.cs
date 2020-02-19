using InventoryManagement.Broadcaster;
using InventoryManagement.Events.Common;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.Services.Misc.Assert;
using InventoryManagement.UI.Transaction;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Transaction
{
    public class FormController_ViewBill : IController<Form_ViewBill>
    {
        TransactionSession m_TransactionSession;

        public FormController_ViewBill(TransactionSession transactionSession, Form_ViewBill UIControl)
            : base(UIControl)
        {
            m_TransactionSession = transactionSession;
            Initialize();
        }

        private void Initialize()
        {
            ResetViewBillTable();
            InitializeLabels();
            InitializeViewBillTable();
        }

        public void SaveTransaction()
        {
            TransactionPost transactionPost = new TransactionPost
            {
                CustomerID = m_TransactionSession.GetCustomer().ID,
                TransactionDateTime = DateTime.Now,
                TotalPrice = double.Parse(m_TransactionSession.amountDue),
                TotalTax = double.Parse(m_TransactionSession.totalTax)
            };
            string productIds = string.Empty;
            string productQuantity = string.Empty;
            string buyingPrices = string.Empty;
            string discounts = string.Empty;

            foreach (var entry in m_TransactionSession.GetRowEntries())
            {
                var product = entry.Product;
                productIds += product.ID + ",";
                productQuantity += entry.Quantity + ",";
                buyingPrices += product.RetailPrice + ",";
                discounts += product.Discount + ",";
            }

            //Removing last comma
            transactionPost.ProductIDs = productIds.Substring(0, productIds.Length - 1);
            transactionPost.ProductQuantity = productQuantity.Substring(0, productQuantity.Length - 1);
            transactionPost.BuyingPrices = buyingPrices.Substring(0, buyingPrices.Length - 1);
            transactionPost.Discounts = discounts.Substring(0, discounts.Length - 1);

            var transaction = DataService.GetTransactionDataController().Post(transactionPost);
            UpdateCustomerDetails();
            UpdateStockDetails();

            // fire new transaction added event
            Event_NewEntryAdded e = new Event_NewEntryAdded(DBEntityType.TRANSACTION, transaction.ID);
            EventBroadcaster.Get().BroadcastEvent(e);
        }

        private void UpdateStockDetails()
        {
            var details = m_TransactionSession.GetRowEntries();
            for (int i = 0; i < details.Count; ++i)
            {
                var productDetail = details[i];
                int productID = productDetail.Product.ID;

                StockGet stockGet = DataService.GetStockDataController().GetByProductID(productID);
                StockPost stockPost = new StockPost(stockGet);
                stockPost.AvailableQuantity -= productDetail.Quantity;
                stockPost.AvailableQuantity = (stockPost.AvailableQuantity < 0) ? 0 : stockPost.AvailableQuantity;

                var updatedStock = DataService.GetStockDataController().Put(stockPost);
                if (updatedStock == null)
                    Assert.Do("Failed to update Stock for Product ID: " + productID);
            }
        }

        private void UpdateCustomerDetails()
        {
            //Update customer details
            var customer = m_TransactionSession.GetCustomer();
            if (customer == null || customer.ID == 0)
                return;

            double amountDue = double.Parse(m_TransactionSession.amountDue);
            double amountPaid = double.Parse(m_TransactionSession.amountPaid);

            CustomerPost customerPost = new CustomerPost();
            customerPost.ID = customer.ID;
            customerPost.MobileNumber = customer.MobileNumber;
            customerPost.Name = customer.Name;
            customerPost.Email = customer.Email;
            customerPost.TotalAmount = customer.TotalAmount + amountDue;
            customerPost.PendingAmount = amountDue - amountPaid;
            var c = DataService.GetCustomerDataController().Put(customerPost);
        }

        private void InitializeViewBillTable()
        {
            foreach (var entry in m_TransactionSession.GetRowEntries())
            {
                AddRowToViewBillTable(entry);
            }
        }

        private void AddRowToViewBillTable(BillProductDetails productDetails)
        {
            var product = productDetails.Product;
            var Table = GetViewBillTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["ViewBillTable_ProductId"].Value = product.ID;
            NewRow.Cells["ViewBillTable_ProductName"].Value = product.Name;
            NewRow.Cells["ViewBillTable_Quantity"].Value = productDetails.Quantity;
            NewRow.Cells["ViewBillTable_FinalPrice"].Value = productDetails.FinalPrice;
        }

        private double CalculateDiscountedPrice(ProductGet product)
        {
            double discountInRupees = product.RetailPrice * (product.Discount / 100);
            return product.RetailPrice - discountInRupees;
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

        private void InitializeLabels()
        {
            CustomerGet customer = m_TransactionSession.GetCustomer();
            m_UIControl.lbl_CustomerName.Text = (customer == null) ? "--" : customer.Name;
            m_UIControl.lbl_Date.Text = DateTime.Now.ToString();

            NumberFormatInfo indianCurrency = new CultureInfo("hi-IN", false).NumberFormat;
            indianCurrency.CurrencyPositivePattern = 2;

            m_UIControl.lbl_TotalPrice.Text = string.Format(indianCurrency, "{0:c}", double.Parse(m_TransactionSession.amountDue));
            m_UIControl.lbl_amountPaid.Text = string.Format(indianCurrency, "{0:c}", double.Parse(m_TransactionSession.amountPaid));
            m_UIControl.lbl_pendingAmount.Text = string.Format(indianCurrency, "{0:c}", double.Parse(m_TransactionSession.pendingAmount));
        }

        protected override void RegisterEvents()
        {

        }
    }
}
