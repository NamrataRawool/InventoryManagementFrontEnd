using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Transaction;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Customer;
using InventoryManagement.UI.Transaction;
using InventoryManagement.UI.UserControls;
using InventoryManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Controllers.Transaction
{

    public class NewTransactionController : IController<TransactionControl>
    {
        TransactionSession m_transactionSession;
        public NewTransactionController(TransactionControl UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Transaction(this));
            m_transactionSession = new TransactionSession();
        }

        public void Initialize(bool reset = true)
        {
            if (reset)
            {
                ResetTransaction();
            }
            InitializeCustomerNameSearchBoxData();
            InitializeCustomerMobileNumberSearchBoxData();
            InitializProductNameSearchBoxData();
        }

        public void OnAddProduct(ProductGet product)
        {
            Event_TransactionAddProduct Event = new Event_TransactionAddProduct(product);
            EventBroadcaster.Get().BroadcastEvent(Event);
        }

        public void OnDeleteProduct()
        {
            if (m_UIControl.Bill_ProductsDataView.SelectedRows.Count <= 0)
                return;
            var productId = Convert.ToInt32(m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_ProductId"].Value);
            int rowIndex = m_UIControl.Bill_ProductsDataView.CurrentCell.RowIndex;
            m_UIControl.Bill_ProductsDataView.Rows.RemoveAt(rowIndex);
            m_transactionSession.DeleteRowEntry(productId);
            UpdateUILabels();
        }

        public void AddProductRowToTable(ProductGet product)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;

            foreach (DataGridViewRow row in GridView.Rows)
            {
                var productId = Convert.ToInt32(row.Cells["BillTable_ProductId"].Value);
                if (productId.Equals(product.ID))
                {
                    var newQuantity = Convert.ToInt32(row.Cells["BillTable_Quantity"].Value) + product.Quantity;
                    product.Quantity = newQuantity;
                    row.Cells["BillTable_Quantity"].Value = newQuantity;
                    double discount = (product.RetailPrice * product.Discount / 100);
                    row.Cells["BillTable_Discount"].Value = discount * newQuantity;
                    var totalTax = CalculateTotalTax(product);
                    row.Cells["BillTable_Tax"].Value = totalTax;
                    double finalPrice = CalculateFinalPrice(product.RetailPrice, product.Discount, newQuantity, totalTax);
                    row.Cells["BillTable_FinalPrice"].Value = finalPrice;
                    m_transactionSession.AddRowEntry(product, finalPrice);
                    UpdateUILabels();
                    return;
                }
            }

            int Index = GridView.Rows.Add();

            DataGridViewRow NewRow = GridView.Rows[Index];
            NewRow.Cells["BillTable_ProductId"].Value = product.ID;
            NewRow.Cells["BillTable_Name"].Value = product.Name;
            NewRow.Cells["BillTable_Price"].Value = product.RetailPrice;
            double discountInRupees = (product.RetailPrice * product.Discount / 100);
            NewRow.Cells["BillTable_Discount"].Value = discountInRupees * product.Quantity;
            NewRow.Cells["BillTable_Quantity"].Value = product.Quantity;
            var tax = CalculateTotalTax(product);
            NewRow.Cells["BillTable_Tax"].Value = tax;
            var newFinalPrice = CalculateFinalPrice(product.RetailPrice, product.Discount, product.Quantity, tax);
            NewRow.Cells["BillTable_FinalPrice"].Value = newFinalPrice;
            m_transactionSession.AddRowEntry(product, newFinalPrice);
            UpdateUILabels();
        }

        public void UpdateBillProductsDataRow()
        {
            if (m_UIControl.Bill_ProductsDataView.SelectedRows.Count <= 0)
                return;
            var productId = Convert.ToInt32(m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_ProductId"].Value);
            var rowEntry = DataService.Get().GetProductDataController().Get(productId);
            var newQuantity = m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Quantity"].Value.ToString();
            if (Validator.IsInteger(newQuantity))
            {
                rowEntry.Quantity = Convert.ToInt32(m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Quantity"].Value);
                if (rowEntry.Quantity == 0)
                {
                    m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Product.Quantity;
                    return;
                }
                double discountInRupees = (rowEntry.RetailPrice * rowEntry.Discount / 100);
                m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Discount"].Value = discountInRupees * rowEntry.Quantity;

                var tax = CalculateTotalTax(rowEntry);
                m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Tax"].Value = tax;

                var finalPrice = CalculateFinalPrice(rowEntry.RetailPrice, rowEntry.Discount, rowEntry.Quantity, tax);
                m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_FinalPrice"].Value = finalPrice;
                m_transactionSession.UpdateRowEntry(rowEntry, finalPrice);
                UpdateUILabels();
            }
            else
            {
                m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Product.Quantity;
                return;
            }
        }

        public void SearchCustomerByMobileNumber(string mobileNumber)
        {
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_pendingAmount.Text = string.Empty;
            if (Validator.IsValidMobileNumber(mobileNumber))
            {
                var customer = DataService.Get().GetCustomerDataController().GetByMobileNumber(mobileNumber);
                if (customer == null || customer.ID == 0)
                {
                    //DialogResult dialogResult = MessageBox.Show("Do you want to add new customer?", "Not found !", MessageBoxButtons.YesNo);
                    //if (dialogResult == DialogResult.Yes)
                    //{
                    //    Form_AddCustomer addCustomer = new Form_AddCustomer();
                    //    addCustomer.ShowDialog();
                    //}
                    //else
                    //{
                    //    ResetCustomerDetails();
                    //    return;
                    //}
                    ResetCustomerDetails();
                    m_UIControl.lbl_customerError.Text = "Customer not found!";
                    return;
                }
                m_transactionSession.SetCustomer(customer);
                m_UIControl.tb_customerName.Text = customer.Name;
                m_UIControl.tb_pendingAmount.Text = customer.PendingAmount.ToString();
            }
            else
                m_UIControl.lbl_customerError.Text = "Mobile number not valid !";
        }

        public void SearchCustomerByName(string name)
        {
            m_UIControl.tb_mobileNumber.Text = string.Empty;
            m_UIControl.tb_pendingAmount.Text = string.Empty;
            if (Validator.IsValidString(name))
            {
                var customer = DataService.Get().GetCustomerDataController().GetByName(name);
                if (customer == null || customer.ID == 0)
                {
                    ResetCustomerDetails();
                    m_UIControl.lbl_customerError.Text = "Customer not found!";
                    return;
                }
                m_transactionSession.SetCustomer(customer);
                m_UIControl.tb_mobileNumber.Text = customer.MobileNumber;
                m_UIControl.tb_pendingAmount.Text = customer.PendingAmount.ToString();
            }
            else
                m_UIControl.lbl_customerError.Text = "Name not valid !";
        }

        public void OpenForm_ViewBill()
        {
            m_UIControl.lbl_errorAmountPaid.Text = string.Empty;
            if (m_UIControl.Bill_ProductsDataView.Rows.Count <= 0)
                return;

            if (string.IsNullOrEmpty(m_UIControl.tb_AmountPaid.Text))
            {
                m_UIControl.lbl_errorAmountPaid.Text = "Please enter amount paid";
                return;
            }
            if (!Validator.IsValidDouble(m_UIControl.tb_AmountPaid.Text.Trim()))
            {
                m_UIControl.lbl_errorAmountPaid.Text = "Enter valid amount!";
                return;
            }
            double amountPaid = double.Parse(m_UIControl.tb_AmountPaid.Text);
            double amountDue = double.Parse(m_UIControl.tb_amountDue.Text);
            if (amountDue > amountPaid)
            {
                var customer = m_transactionSession.GetCustomer();
                if (customer == null || customer.ID == 0)
                {
                    m_UIControl.lbl_errorAmountPaid.Text = "Please add customer details";
                    return;
                }
            }
            m_transactionSession.amountPaid = amountPaid.ToString();
            Form_ViewBill viewBill = new Form_ViewBill(m_transactionSession);
            var result = viewBill.ShowDialog();
            if (result == DialogResult.Yes)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to print bill?", "Transaction successful !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                }
                ResetTransaction();
            }
        }
        public void InitializeCustomerNameSearchBoxData()
        {
            var customers = DataService.Get().GetCustomerDataController().GetAll();
            var searchBox = m_UIControl.tb_customerName;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var customer in customers)
                collection.Add(customer.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }
        public void InitializProductNameSearchBoxData()
        {
            var products = DataService.Get().GetProductDataController().GetAll();
            var searchBox = m_UIControl.tb_productName;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var product in products)
                collection.Add(product.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }
        public void InitializeCustomerMobileNumberSearchBoxData()
        {
            var customers = DataService.Get().GetCustomerDataController().GetAll();
            var searchBox = m_UIControl.tb_mobileNumber;
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var customer in customers)
                collection.Add(customer.MobileNumber);

            searchBox.AutoCompleteCustomSource = collection;
        }
        private void UpdateUILabels()
        {
            double subtotal = 0;
            double totalDiscount = 0;
            double totalTax = 0;
            double amountDue = 0;
            for (int i = 0; i < m_UIControl.Bill_ProductsDataView.Rows.Count; ++i)
            {
                var actualPrice = Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Price"].Value);
                var quantity = Convert.ToInt32(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Quantity"].Value);
                subtotal += actualPrice * quantity;
                totalDiscount += Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Discount"].Value);
                totalTax += Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_Tax"].Value);
                amountDue += Convert.ToDouble(m_UIControl.Bill_ProductsDataView.Rows[i].Cells["BillTable_FinalPrice"].Value);
            }
            m_transactionSession.subtotal = m_UIControl.tb_subtotal.Text = subtotal.ToString();
            m_transactionSession.totalDiscount = m_UIControl.tb_totalDiscount.Text = totalDiscount.ToString();
            m_transactionSession.totalTax = m_UIControl.tb_totalTax.Text = totalTax.ToString();
            m_transactionSession.amountDue = m_UIControl.tb_amountDue.Text = amountDue.ToString();
        }
        private double CalculateTotalTax(ProductGet product)
        {
            var cgst = (product.RetailPrice * product.CGST / 100) * product.Quantity;
            var sgst = (product.RetailPrice * product.SGST / 100) * product.Quantity;
            double totalTax = cgst + sgst;
            return totalTax;
        }
        private double CalculateFinalPrice(int price, double discountRate, int quantity, double totalTax)
        {
            double discountInRupees = (price * discountRate / 100);
            double discountedPrice = price - discountInRupees;
            double totalPrice = (discountedPrice * quantity) + totalTax;
            return totalPrice;
        }

        public void ResetTransaction()
        {
            m_transactionSession = new TransactionSession();
            m_UIControl.lbl_errorText.Text = string.Empty;
            m_UIControl.lbl_errorAmountPaid.Text = string.Empty;
            ResetBillProductsTable();
            ResetTextBoxes();
        }
        private void ResetTextBoxes()
        {
            m_UIControl.tb_productName.Text = string.Empty;
            m_UIControl.tb_barCode.Text = string.Empty;
            m_UIControl.tb_subtotal.Text = string.Empty;
            m_UIControl.tb_totalDiscount.Text = string.Empty;
            m_UIControl.tb_amountDue.Text = string.Empty;
            m_UIControl.tb_totalTax.Text = string.Empty;
            m_UIControl.tb_AmountPaid.Text = string.Empty;
            ResetCustomerDetails();
        }
        public void ResetCustomerDetails()
        {
            m_UIControl.lbl_customerError.Text = string.Empty;
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_pendingAmount.Text = string.Empty;
            m_UIControl.tb_mobileNumber.Text = string.Empty;
        }
        private void ResetBillProductsTable()
        {
            var Table = m_UIControl.Bill_ProductsDataView;
            Table.Rows.Clear();
            Table.Refresh();
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.UI_Transaction_AddProduct);
        }
    }
}
