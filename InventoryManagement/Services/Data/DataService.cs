﻿using InventoryManagement.Controllers;
using InventoryManagement.Services.Data.Database;
using InventoryManagement.Services.Data.Database.SQLite;
using InventoryManagement.Services.Data.Database.SQLite.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data
{
   
    public static class DataService
    {
        public static void Initialize()
        {
            m_Context = new InventoryDbContext();
            m_Context.Database.EnsureCreated();
            m_ProductDataController = new ProductDataController(m_Context);
            m_CategoryDataController = new CategoryDataController(m_Context);
            m_CustomerDataController = new CustomerDataController(m_Context);
            m_TransactionDataController = new TransactionDataController(m_Context);
            m_StockDataController = new StockDataController(m_Context);
            m_VendorDataController = new VendorDataController(m_Context);
        }

        public static ProductDataController GetProductDataController() { return m_ProductDataController; }
        public static CategoryDataController GetCategoryDataController() { return m_CategoryDataController; }
        public static CustomerDataController GetCustomerDataController() { return m_CustomerDataController; }
        public static TransactionDataController GetTransactionDataController() { return m_TransactionDataController; }
        public static StockDataController GetStockDataController() { return m_StockDataController; }
        public static VendorDataController GetVendorDataController() { return m_VendorDataController; }


        private static ProductDataController m_ProductDataController;
        private static CategoryDataController m_CategoryDataController;
        private static CustomerDataController m_CustomerDataController;
        private static TransactionDataController m_TransactionDataController;
        private static StockDataController m_StockDataController;
        private static VendorDataController m_VendorDataController;

        private static InventoryDbContext m_Context;

    }
}