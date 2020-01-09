using InventoryManagement.Services.Data.Database.SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database
{
    public class DatabaseService : IDataService
    {

        public DatabaseService() { }

        public override bool Initialize()
        {
            m_Database = new DatabaseSQLite();
            m_Database.Initialize();
            return true;
        }


        public override byte[] GETFile(string imageURL)
        {
            throw new NotImplementedException();
        }

        public override object GetAll(DBEntityType type)
        {
            return m_Database.GetAll(type);
        }

        public override object Get(DBEntityType type, int id)
        {
            return m_Database.Get(type, id);
        }

        public override object Get(DBEntityType type, KeyValuePair<string, object> attribute)
        {
            return m_Database.Get(type, attribute);
        }

        public override object Post(DBEntityType type, object obj)
        {
            return m_Database.Post(type, obj);
        }

        public override object Put(DBEntityType type, object obj)
        {
            return m_Database.Put(type, obj);
        }

        private IDatabase m_Database;
    }
}
