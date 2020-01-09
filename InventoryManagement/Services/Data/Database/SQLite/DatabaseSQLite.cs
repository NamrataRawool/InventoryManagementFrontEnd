using InventoryManagement.Controllers;
using InventoryManagement.Models;
using InventoryManagement.Services.Data.Database.SQLite.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite
{

    public class DatabaseSQLite : IDatabase
    {

        Dictionary<DBEntityType, IDataController> m_Controllers;

        public DatabaseSQLite() { }

        public override bool Initialize()
        {

            m_Context = new InventoryDbContext();
            m_Context.Database.EnsureCreated();

            m_Controllers = new Dictionary<DBEntityType, IDataController>();
            m_Controllers.Add(DBEntityType.PRODUCT, new ProductDataController(m_Context));
            m_Controllers.Add(DBEntityType.CATEGORY, new CategoryDataController(m_Context));

            return true;
        }

        public override byte[] GETFile(string imageURL)
        {
            throw new NotImplementedException();
        }

        public override object GetAll(DBEntityType type)
        {
            //return m_Controllers[type].GetAll();
            throw new NotImplementedException();
        }

        public override object Get(DBEntityType type, int id)
        {
            //return m_Controllers[type].Get(id);
            throw new NotImplementedException();
        }

        public override object Get(DBEntityType type, KeyValuePair<string, object> attribute)
        {
            //return m_Controllers[type].Get(type, attribute);
            throw new NotImplementedException();
        }

        public override object Post(DBEntityType type, object obj)
        {
            //return m_Controllers[type].Post(obj);
            throw new NotImplementedException();
        }

        public override object Put(DBEntityType type, object obj)
        {
            //return m_Controllers[type].Put(obj);
            throw new NotImplementedException();
        }

        private InventoryDbContext m_Context;
    }
}
