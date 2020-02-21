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

        public void OnAddProduct( BillProductDetails productDetails)
        {
            if (!IsStockAvailable(productDetails))
            {
                DialogResult dialogResult = MessageBox.Show("Not Enough Stock Available? Do you still want to add", "Transaction successful !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
            }

            // check if this product is already added
            var product = productDetails.Product;
            DataGridViewRow row = CheckIfProductExistInTable(product.ID);
            if (row != null)
                UpdateProductRowInTable(row, productDetails);
            else
                AddProductRowToTable(productDetails);

            UpdateUILabels();
        }

        private DataGridViewRow CheckIfProductExistInTable(int id)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;
            foreach (DataGridViewRow row in GridView.Rows)
            {
                var productId = Convert.ToInt32(row.Cells["BillTable_ProductId"].Value);
                if (productId.Equals(id))
                    return row;
            }

            return null;
        }

        private bool IsStockAvailable(BillProductDetails productDetails)
        {
            // check if stock is available
            int productID = productDetails.Product.ID;
            StockGet stock = DataService.GetStockDataController().GetByProductID(productID);
            if (stock.AvailableQuantity < productDetails.Quantity)
                return false;
            return true;
        }

        private void UpdateProductRowInTable(DataGridViewRow row, BillProductDetails productDetails)
        {
            var product = productDetails.Product;

            var checkBoxCell = row.Cells["BillTable_useWholeSalePrice"] as DataGridViewCheckBoxCell;
            bool useWholeSalePrice = checkBoxCell.Value != null && (bool)checkBoxCell.Value;

            double productPrice = useWholeSalePrice ? product.WholeSalePrice : product.RetailPrice;

            var newQuantity = Convert.ToInt32(row.Cells["BillTable_Quantity"].Value) + 1; // add 1 to the existing quantity
            row.Cells["BillTable_Quantity"].Value = newQuantity;
            productDetails.Quantity = newQuantity;

            double discount = (productPrice * product.Discount / 100);
            row.Cells["BillTable_Discount"].Value = discount * newQuantity;

            var totalTax = CalculateTotalTax(productPrice, product.CGST, product.SGST, productDetails.Quantity);
            row.Cells["BillTable_Tax"].Value = totalTax;

            double finalPrice = CalculateFinalPrice(productPrice, product.Discount, newQuantity, totalTax);
            row.Cells["BillTable_FinalPrice"].Value = finalPrice;
            productDetails.FinalPrice = finalPrice;

            m_transactionSession.AddRowEntry(productDetails);
        }

        public void AddProductRowToTable(BillProductDetails productDetails)
        {
            var GridView = m_UIControl.Bill_ProductsDataView;
            var product = productDetails.Product;

            int Index = GridView.Rows.Add();

            DataGridViewRow newRow = GridView.Rows[Index];
            newRow.Cells["BillTable_ProductId"].Value = product.ID;
            newRow.Cells["BillTable_Name"].Value = product.Name;

            newRow.Cells["BillTable_Price"].Value = product.RetailPrice;
            double discountInRupees = (product.RetailPrice * product.Discount / 100);

            newRow.Cells["BillTable_Discount"].Value = discountInRupees * productDetails.Quantity;
            newRow.Cells["BillTable_Quantity"].Value = productDetails.Quantity;

            var tax = CalculateTotalTax(product.RetailPrice, product.CGST, product.SGST, productDetails.Quantity);
            newRow.Cells["BillTable_Tax"].Value = tax;

            int priceToUse = product.RetailPrice;
            double newFinalPrice = CalculateFinalPrice(priceToUse, product.Discount, productDetails.Quantity, tax);
            newRow.Cells["BillTable_FinalPrice"].Value = newFinalPrice;
            productDetails.FinalPrice = newFinalPrice;

            m_transactionSession.AddRowEntry(productDetails);
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

        public void UpdateBillProductsDataRow(bool useWholeSalePrice, bool checkStock)
        {
            if (m_UIControl.Bill_ProductsDataView.SelectedRows.Count <= 0)
                return;

            var currentRow = m_UIControl.Bill_ProductsDataView.CurrentRow;
            var productId = Convert.ToInt32(currentRow.Cells["BillTable_ProductId"].Value);
            var productGet = DataService.GetProductDataController().Get(productId);

            double productPrice = useWholeSalePrice ? productGet.WholeSalePrice : productGet.RetailPrice;
            currentRow.Cells["BillTable_Price"].Value = productPrice;

            var newQuantity = currentRow.Cells["BillTable_Quantity"].Value.ToString();

            if (!Validator.IsInteger(newQuantity))
            {
                currentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Quantity;
                return;
            }

            BillProductDetails productDetails = new BillProductDetails(productGet);
            productDetails.Quantity = Convert.ToInt32(currentRow.Cells["BillTable_Quantity"].Value);
            if (productDetails.Quantity == 0)
            {
                currentRow.Cells["BillTable_Quantity"].Value = m_transactionSession.GetRowEntry(productId).Quantity;
                return;
            }

            // check stock availability
            if (checkStock && !IsStockAvailable(productDetails))
            {
                DialogResult dialogResult = MessageBox.Show("Not Enough Stock Available? Do you still want to add?", "Transaction successful !", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    return;
            }

            double discountInRupees = (productPrice * productGet.Discount / 100);
            currentRow.Cells["BillTable_Discount"].Value = discountInRupees * productDetails.Quantity;

            var tax = CalculateTotalTax(productPrice, productGet.CGST, productGet.SGST, productDetails.Quantity);
            currentRow.Cells["BillTable_Tax"].Value = tax;

            var finalPrice = CalculateFinalPrice(productPrice, productGet.Discount, productDetails.Quantity, tax);
            currentRow.Cells["BillTable_FinalPrice"].Value = finalPrice;
            productDetails.FinalPrice = finalPrice;

            m_transactionSession.UpdateRowEntry(productDetails);
            UpdateUILabels();
        }

        public void UpdateCustomerDetailsByMobileNumber(string mobileNumber)
        {
            m_UIControl.tb_customerName.Text = string.Empty;
            m_UIControl.tb_pendingAmount.Text = string.Empty;
            if (Validator.IsValidMobileNumber(mobileNumber))
            {
                var customer = DataService.GetCustomerDataController().GetByMobileNumber(mobileNumber);
                if (customer == null || customer.ID == 0)
                {
                    ResetCustomerDetails();
                    m_UIControl.lbl_customerError.Text = "Customer not found!";
                    return;
                }
                m_transactionSession.SetCustomer(customer);
                UpdateCustomerDetails(customer);
            }
            else
                m_UIControl.lbl_customerError.Text = "Mobile number not valid !";
        }

        public void UpdateCustomerDetailsByName(string name)
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
                UpdateCustomerDetails(customer);
            }
            else
            {
                m_UIControl.lbl_customerError.Text = "Name not valid !";
            }
        }

        private void UpdateCustomerDetails(CustomerGet customer)
        {
            m_UIControl.tb_customerName.Text = customer.Name;

            double PendingAmount = customer.PendingAmount;
            m_UIControl.lbl_CustomerAmount.Text = (PendingAmount < 0.0) ? "Balance Amount :" : "Pending Amount :";

            m_UIControl.tb_pendingAmount.Text = Math.Abs(customer.PendingAmount).ToString();
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
            if (amountDue != amountPaid)
            {
                var customer = m_transactionSession.GetCustomer();
                if (customer == null || customer.ID == 0)
                {
                    m_UIControl.lbl_errorAmountPaid.Text = "Please add customer details";
                    return;
                }

            }

            pendingAmount = amountDue - amountPaid;

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

        public void UpdateUILabels()
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

            CustomerGet customer = m_transactionSession.GetCustomer();
            if (customer != null)
                amountDue = amountDue + customer.PendingAmount;

            m_UIControl.tb_amountDue.Text = amountDue.ToString();
            m_transactionSession.amountDue = amountDue.ToString();
        }

        private double CalculateTotalTax(double price, double CGST, double SGST, int quantity)
        {
            var cgst = (price * CGST / 100) * quantity;
            var sgst = (price * SGST / 100) * quantity;

            double totalTax = cgst + sgst;
            return totalTax;
        }

        private double CalculateFinalPrice(double price, double discountRate, int quantity, double totalTax)
        {
            double discountInRupees = (price * discountRate / 100);
            double discountedPrice = price - discountInRupees;
            double totalPrice = (discountedPrice * quantity) + totalTax;
            return totalPrice;
        }

        public void AddNewCustomer()
        {
            m_UIControl.lbl_customerError.Text = string.Empty;
            Form_AddCustomer form = new Form_AddCustomer();
            DialogResult result = form.ShowDialog();

            if (result != DialogResult.Yes)
                return;

            MessageBox.Show("Customer Added Successfully!");

            // fill the customer details
            CustomerGet customer = form.GetCustomer();
            m_UIControl.tb_customerName.Text = customer.Name;
            m_UIControl.tb_mobileNumber.Text = customer.MobileNumber;
            m_UIControl.tb_pendingAmount.Text = customer.PendingAmount.ToString();
            m_transactionSession.SetCustomer(customer);
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

            m_transactionSession.SetCustomer(null);
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
