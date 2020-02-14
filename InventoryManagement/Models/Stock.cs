using InventoryManagement.Services.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class StockBase
    {

        public StockBase() { }

        public StockBase(StockBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(StockBase rhs)
        {
            ID = rhs.ID;
            ProductID = rhs.ProductID;
            TotalQuantity = rhs.TotalQuantity;
            AvailableQuantity = rhs.AvailableQuantity;
            TotalQuantity = rhs.TotalQuantity;
        }

        public int ID { get; set; }

        public int ProductID { get; set; }

        public double AvailableQuantity { get; set; }

        public int TotalQuantity { get; set; }
    }

    public class StockGet : StockBase
    {
        public StockGet() { }

        public StockGet(InventoryDbContext context, StockDTO dto)
            : base(dto)
        {
        }
    }

    public class StockPost : StockBase
    {
        public StockPost() { }
        public StockPost(StockGet get)
            : base(get)
        {
        }
    }

    public class StockDTO : StockBase
    {
        public StockDTO() { }

        public StockDTO(StockPost stockPOST)
            : base(stockPOST)
        {
        }
    }

}
