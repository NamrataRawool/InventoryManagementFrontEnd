using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database
{
    public abstract class IDatabase
    {
        public IDatabase() { }

        public abstract bool Initialize();

        public abstract byte[] GETFile(string imageURL);
        public abstract object GetAll(DBEntityType type);
        public abstract object Get(DBEntityType type, int id);
        public abstract object Get(DBEntityType type, KeyValuePair<string, object> attribute);
        public abstract object Post(DBEntityType type, object obj);
        public abstract object Put(DBEntityType type, object obj);

    }
}
