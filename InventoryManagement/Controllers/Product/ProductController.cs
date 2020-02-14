using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Product;
using InventoryManagement.Events;
using InventoryManagement.Models;
using InventoryManagement.Services.Data;
using InventoryManagement.UI.Product;
using InventoryManagement.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryManagement.Controllers
{
    public class ProductController : IController<ProductControl>
    {
        public ProductController(ProductControl UIControl)
            : base(UIControl)
        {
            SetEventHandler(new EventHandler_Product(this));
        }

        public void Initialize(bool reset = true)
        {
            if (reset)
                ResetTable();

            var products = DataService.GetProductDataController().GetAll();
            if (products == null)
                return;

            InitializeTable(products);
            InitializeAutoSearchBox(products);
        }

        public void ResetTable()
        {
            var Table = GetTable();
            Table.Rows.Clear();
            Table.Refresh();
        }

        public void InitializeTable(List<ProductGet> products)
        {
            GetTable().Rows.Clear();

            foreach (var product in products)
                AddProductToTable(product);
        }

        public void UpdateProductInTable(ProductGet product)
        {
            // find the row with this productID
            var table = GetTable();

            for(int i=0; i<table.Rows.Count; ++i)
            {
                DataGridViewRow row = table.Rows[i];
                int id = int.Parse(row.Cells["ProductTableColumn_ID"].Value.ToString());

                if (product.ID == id)
                {
                    row.Cells["ProductTableColumn_ID"].Value = product.ID;
                    row.Cells["ProductTableColumn_Barcode"].Value = product.Barcode;
                    row.Cells["ProductTableColumn_Name"].Value = product.Name;
                    row.Cells["ProductTableColumn_Category"].Value = product.Category.Name;
                    row.Cells["ProductTableColumn_RetailPrice"].Value = product.RetailPrice;
                    row.Cells["ProductTableColumn_WholesalePrice"].Value = product.WholeSalePrice;
                    row.Cells["ProductTableColumn_AvailableStock"].Value 
                        = DataService.GetStockDataController().GetByProductID(product.ID).AvailableQuantity;

                    return;
                }
            }

        }

        public void AddProductToTable(ProductGet product)
        {
            var table = GetTable();
            int Index = table.Rows.Add();
            DataGridViewRow NewRow = table.Rows[Index];
            NewRow.Cells["ProductTableColumn_ID"].Value = product.ID;
            NewRow.Cells["ProductTableColumn_Barcode"].Value = product.Barcode;
            NewRow.Cells["ProductTableColumn_Name"].Value = product.Name;
            NewRow.Cells["ProductTableColumn_Category"].Value = product.Category.Name;
            NewRow.Cells["ProductTableColumn_RetailPrice"].Value = product.RetailPrice;
            NewRow.Cells["ProductTableColumn_WholesalePrice"].Value = product.WholeSalePrice;
            NewRow.Cells["ProductTableColumn_AvailableStock"].Value 
                = DataService.GetStockDataController().GetByProductID(product.ID).AvailableQuantity;

        }

        public void RefreshTable()
        {
            GetTable().Refresh();
        }

        public void InitializeAutoSearchBox(List<ProductGet> products)
        {
            var searchBox = m_UIControl.tb_searchProduct;
            searchBox.Clear();

            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            foreach (var product in products)
                collection.Add(product.Name);

            searchBox.AutoCompleteCustomSource = collection;
        }

        public void AddProductToAutoSearchBox(string productName)
        {
            var searchBox = m_UIControl.tb_searchProduct;
            searchBox.AutoCompleteCustomSource.Add(productName);
        }

        public void OpenForm_AddProduct()
        {
            Form_AddProduct addProduct = new Form_AddProduct();
            addProduct.Text = "Add Product";
            addProduct.ShowDialog();
        }

        public void OpenForm_ProductDetails()
        {
            var Table = GetTable();

            var rows = Table.SelectedRows;
            if (rows.Count <= 0)
            {
                // TODO: add notification
                return;
            }

            int selectedRowIndex = Table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Table.Rows[selectedRowIndex];
            int ProductID = int.Parse(selectedRow.Cells["ProductTableColumn_ID"].Value.ToString());

            Form_ProductDetails formProductDetails = new Form_ProductDetails(ProductID);
            formProductDetails.Text = "Product Details";
            formProductDetails.ShowDialog();
        }

        public void UpdateTableByProductName(string name)
        {
            var Table = GetTable();

            foreach (DataGridViewRow row in Table.Rows)
            {
                bool visible = false;
                var productName = row.Cells["ProductTableColumn_Name"].Value.ToString().ToLower();
                if (productName.StartsWith(name.ToLower()))
                    visible = true;

                row.Visible = visible;
            }
            return;
        }

        public void OnPurchaseAdded(PurchaseGet purchase)
        {
            string[] ids = purchase.ProductIDs.Split(',');

            for (int i = 0; i < ids.Length; ++i)
            {
                int productID = int.Parse(ids[i]);
                UpdateStockInTable(productID);
            }
        }

        public void OnTransactionAdded(TransactionGet transaction)
        {
            string[] ids = transaction.ProductIDs.Split(',');

            for (int i = 0; i < ids.Length; ++i)
            {
                int productID = int.Parse(ids[i]);
                UpdateStockInTable(productID);
            }
        }

        private void UpdateStockInTable(int productID)
        {
            var availableQuantity = DataService.GetStockDataController().GetByProductID(productID).AvailableQuantity;

            // go through the table rows
            var rows = GetTable().Rows;
            foreach (DataGridViewRow row in rows)
            {
                var rowID = int.Parse(row.Cells["ProductTableColumn_ID"].Value.ToString());

                if (rowID != productID)
                    continue;

                // found the product
                row.Cells["ProductTableColumn_AvailableStock"].Value = availableQuantity;
            }
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewEntryAdded);
            RegisterEvent(EventType.EntryUpdated);
        }

        private DataGridView GetTable()
        {
            return m_UIControl.productDataView;
        }
    }
}
