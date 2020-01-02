﻿using InventoryManagement.Broadcaster;
using InventoryManagement.EventHandlers.Product;
using InventoryManagement.Events;
using InventoryManagement.Events.Product;
using InventoryManagement.Models;
using InventoryManagement.Services.HTTP;
using InventoryManagement.UI.Product;
using InventoryManagement.UI.UserControls;
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
            {
                ResetTable();
            }

            var products = HTTPService.GET<List<ProductGet>>("products");
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
            foreach (var product in products)
                AddProductToTable(product);
        }

        public void AddProductToTable(ProductGet product)
        {
            var Table = GetTable();
            int Index = Table.Rows.Add();
            DataGridViewRow NewRow = Table.Rows[Index];
            NewRow.Cells["ProductTableColumn_ID"].Value = product.ID;
            NewRow.Cells["ProductTableColumn_Barcode"].Value = product.ID;
            NewRow.Cells["ProductTableColumn_Name"].Value = product.Name;
            NewRow.Cells["ProductTableColumn_Category"].Value = product.Category.Name;
            NewRow.Cells["ProductTableColumn_RetailPrice"].Value = product.RetailPrice;
            NewRow.Cells["ProductTableColumn_WholesalePrice"].Value = product.WholeSalePrice;
        }

        public void RefreshTable()
        {
            GetTable().Refresh();
        }

        public void InitializeAutoSearchBox(List<ProductGet> products)
        {
            var searchBox = m_UIControl.tb_searchProduct;
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
            if (rows.Count < 0)
                return;

            int selectedRowIndex = Table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Table.Rows[selectedRowIndex];
            int ProductID = int.Parse(selectedRow.Cells["ProductTableColumn_ID"].Value.ToString());

            Form_ProductDetails formProductDetails = new Form_ProductDetails(ProductID);
            formProductDetails.Text = "Product Details";
            formProductDetails.ShowDialog();
        }

        protected override void RegisterEvents()
        {
            RegisterEvent(EventType.NewProductAdded);
        }

        private DataGridView GetTable()
        {
            return m_UIControl.productDataView;
        }
    }
}
