using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Export
{

    public enum ExportEntity
    {
        PRODUCTS,
        CATEGORIES,
        CUSTOMERS,
        TRANSACTIONS,
        STOCKS,
        DATAGRIDVIEW,
    }

    public enum ExportType
    {
        EXCEL,
    }

    public abstract class IExporter
    {

        public abstract void Export(string filename);
        public abstract ExportType Type();

    }
}
