using InventoryManagement.Controllers;
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
   
    // Singleton
    public class DataService
    {
        public DataService() { }

        public void Initialize()
        {
            m_Context = new InventoryDbContext();

            m_ProductDataController = new ProductDataController(m_Context);
            m_CategoryDataController = new CategoryDataController(m_Context);
            m_CustomerDataController = new CustomerDataController(m_Context);
            m_TransactionDataController = new TransactionDataController(m_Context);
            m_StockDataController = new StockDataController(m_Context);
            m_VendorDataController = new VendorDataController(m_Context);
        }

        public ProductDataController GetProductDataController() { return m_ProductDataController; }
        public CategoryDataController GetCategoryDataController() { return m_CategoryDataController; }
        public CustomerDataController GetCustomerDataController() { return m_CustomerDataController; }
        public TransactionDataController GetTransactionDataController() { return m_TransactionDataController; }
        public StockDataController GetStockDataController() { return m_StockDataController; }
        public VendorDataController GetVendorDataController() { return m_VendorDataController; }

        public static DataService Get()
        {
            if (s_Instance == null)
                s_Instance = new DataService();
            return s_Instance;
        }

        private ProductDataController m_ProductDataController;
        private CategoryDataController m_CategoryDataController;
        private CustomerDataController m_CustomerDataController;
        private TransactionDataController m_TransactionDataController;
        private StockDataController m_StockDataController;
        private VendorDataController m_VendorDataController;

        private InventoryDbContext m_Context;

        private static DataService s_Instance = null;
    }
}

/*
 public class DataService
    {
        public DataService() { }

        public void Initialize()
        {
            m_Service = new DatabaseService();
            m_Service.Initialize();
        }

        public T GET_ALL<T>(DBEntityType type) where T : new()
        {
            return CAST<T>(m_Service.GetAll(type));
        }

        public T GET<T>(DBEntityType type, int id) where T : new()
        {
            return CAST<T>(m_Service.Get(type, id));
        }

        public T GET<T>(DBEntityType type, KeyValuePair<string, object> attribute) where T : new()
        {
            return CAST<T>(m_Service.Get(type, attribute));
        }

        public RETURN_TYPE POST<RETURN_TYPE>(DBEntityType type, object obj)
        {
            return CAST<RETURN_TYPE>(m_Service.Post(type, obj));
        }

        public RETURN_TYPE PUT<RETURN_TYPE>(DBEntityType type, object obj)
        {
            return CAST<RETURN_TYPE>(m_Service.Put(type, obj));
        }

        public static DataService Get()
        {
            if (m_Instance == null)
                m_Instance = new DataService();
            return m_Instance;
        }

        private T CAST<T>(object obj)
        {
            return (T)obj;
        }

        private static DataService m_Instance = null;

        private IDataService m_Service;
    }
}

*/
