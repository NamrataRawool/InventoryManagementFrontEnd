using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class StockBase
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public int AvailableQuantity { get; set; }

        public int TotalQuantity { get; set; }
    }

    public class StockGet : StockBase
    {
    }

    public class StockPost : StockBase
    {
    }

}
