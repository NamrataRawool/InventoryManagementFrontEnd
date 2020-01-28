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
            SetEventHandler(new EventHandler_NewTransaction(this));
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

        public void OnAddProduct(BillProductDetails productDetails)
        {
            AddProductRowToTable(productDetails);
        }

        public void AddProductRowToTable(BillProductDetails productDetails)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;
            var product = productDetails.Product;

            foreach (DataGridViewRow row in GridView.Rows)
            {
                var productId = Convert.ToInt32(row.Cells["BillTable_ProductId"].Value);
                if (!productId.Equals(product.ID))
                    continue;

                var newQuantity = Convert.ToInt32(row.Cells["BillTable_Quantity"].Value) + 1; // add 1 to the existing quantity
                row.Cells["BillTable_Quantity"].Value = newQuantity;
                productDetails.Quantity = newQuantity;

                double discount = (product.RetailPrice * product.Discount / 100);
                row.Cells["BillTable_Discount"].Value = discount * newQuantity;

                var totalTax = CalculateTotalTax(productDetails);
                row.Cells["BillTable_Tax"].Value = totalTax;

                double finalPrice = CalculateFinalPrice(product.RetailPrice, product.Discount, newQuantity, totalTax);
                row.Cells["BillTable_FinalPrice"].Value = finalPrice;
                productDetails.FinalPrice = finalPrice;

                m_transactionSession.AddRowEntry(productDetails);
                UpdateUILabels();
                return;
            }

            int Index = GridView.Rows.Add();

            DataGridViewRow NewRow = GridView.Rows[Index];
            NewRow.Cells["BillTable_ProductId"].Value = product.ID;
            NewRow.Cells["BillTable_Name"].Value = product.Name;

            NewRow.Cells["BillTable_Price"].Value = product.RetailPrice;
            double discountInRupees = (product.RetailPrice * product.Discount / 100);

            NewRow.Cells["BillTable_Discount"].Value = discountInRupees * productDetails.Quantity;
            NewRow.Cells["BillTable_Quantity"].Value = productDetails.Quantity;

            var tax = CalculateTotalTax(productDetails);
            NewRow.Cells["BillTable_Tax"].Value = tax;

            var newFinalPrice = CalculateFinalPrice(product.RetailPrice, product.Discount, productDetails.Quantity, tax);
            NewRow.Cells["BillTable_FinalPrice"].Value = newFinalPrice;
            productDetails.FinalPrice = newFinalPrice;

            m_transactionSession.AddRowEntry(productDetails);
            UpdateUILabels();
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

        public void UpdateBillProductsDataRow()
        {
            if (m_UIControl.Bill_ProductsDataView.SelectedRows.Count <= 0)
                return;

            var currentRow = m_UIControl.Bill_ProductsDataView.CurrentRow;
            var productId = Convert.ToInt32(currentRow.Cells["BillTable_ProductId"].Value);
            var productGet = DataService.GetProductDataController().Get(productId);

            BillProductDetails rowEntry = new BillProductDetails(productGet);

            var newQuantity = currentRow.Cells["BillTable_Quantity"].Value.ToString();

            if (Validator.IsInteger(newQuantity))
            {
                rowEntry.Quantity = Convert.ToInt32(currentRow.Cells["BillTable_Quantity"].Value);
                if (rowEntry.Quantity == 0)
                {
                    currentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Quantity;
                    return;
                }

                double discountInRupees = (productGet.RetailPrice * productGet.Discount / 100);
                currentRow.Cells["BillTable_Discount"].Value = discountInRupees * rowEntry.Quantity;

                var tax = CalculateTotalTax(rowEntry);
                currentRow.Cells["BillTable_Tax"].Value = tax;

                var finalPrice = CalculateFinalPrice(productGet.RetailPrice, productGet.Discount, rowEntry.Quantity, tax);
                currentRow.Cells["BillTable_FinalPrice"].Value = finalPrice;
                rowEntry.FinalPrice = finalPrice;

                m_transactionSession.UpdateRowEntry(rowEntry);
                UpdateUILabels();
            }
            else
            {
                m_UIControl.Bill_ProductsDataView.CurrentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Quantity;
                return;
            }
        }

        public void SearchCustomerByMobileNumber(string mobileNumber)
        {
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_pendingAmount.Text = string.Empty;
            if (Validator.IsValidMobileNumber(mobileNumber))
            {
                var customer = DataService.GetCustomerDataController().GetByMobileNumber(mobileNumber);
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
                var customer = DataService.GetCustomerDataController().GetByName(name);
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
            double pendingAmount = 0.0;
            if (amountDue > amountPaid)
            {
                var customer = m_transactionSession.GetCustomer();
                if (customer == null || customer.ID == 0)
                {
                    m_UIControl.lbl_errorAmountPaid.Text = "Please add customer details";
                    return;
                }
                pendingAmount = amountDue - amountPaid;
            }

            pendingAmount += m_transactionSession.GetCustomer().PendingAmount;
            m_transactionSession.pendingAmount = pendingAmount.ToString();
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
            var customers = DataService.GetCustomerDataController().GetAll();
            var searchBox = m_UIControl.tb_customerName;

            searchBox.AutoCompleteCustomSource.Clear();

            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var customer in customers)
                collection.Add(customer.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }

        public void AddCustomerNameToSearchBox(string customerName)
        {
            var searchBox = m_UIControl.tb_customerName;
            searchBox.AutoCompleteCustomSource.Add(customerName);
        }

        public void InitializProductNameSearchBoxData()
        {
            var products = DataService.GetProductDataController().GetAll();
            var searchBox = m_UIControl.tb_productName;
            searchBox.AutoCompleteCustomSource.Clear();
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var product in products)
                collection.Add(product.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }

        public void InitializeCustomerMobileNumberSearchBoxData()
        {
            var customers = DataService.GetCustomerDataController().GetAll();
            var searchBox = m_UIControl.tb_mobileNumber;
            searchBox.AutoCompleteCustomSource.Clear();

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

        private double CalculateTotalTax(BillProductDetails productDetails)
        {
            var product = productDetails.Product;

            var cgst = (product.RetailPrice * product.CGST / 100) * productDetails.Quantity;
            var sgst = (product.RetailPrice * product.SGST / 100) * productDetails.Quantity;

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

        public void AddNewCustomer()
        {
            Form_AddCustomer form = new Form_AddCustomer();
            DialogResult result = form.ShowDialog();

            if (result != DialogResult.Yes)
                return;

            MessageBox.Show("Customer Added Succesfully!");

            // fill the customer details
            CustomerGet customer = form.GetCustomer();
            m_UIControl.tb_customerName.Text = customer.Name;
            m_UIControl.tb_mobileNumber.Text = customer.MobileNumber;
            m_UIControl.tb_pendingAmount.Text = customer.PendingAmount.ToString();
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
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }

    }
}
