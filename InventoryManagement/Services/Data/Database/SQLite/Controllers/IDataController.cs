using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public abstract class IDataController
    {
        public IDataController(InventoryDbContext context)
        {
            m_Context = context;
        }

        protected InventoryDbContext m_Context;

    }
}
