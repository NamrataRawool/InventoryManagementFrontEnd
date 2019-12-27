using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class TransactionBase
    {
        public int ID { get; set; }

        public int TotalPrice { get; set; }

        public string ProductIDs { get; set; }

        public string ProductQuantity { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public int CustomerID { get; set; }
    }

    public class TransactionGet : TransactionBase
    {
        public List<ProductGet> ProductDetails { get; set; }

        public CustomerGet Customer { get; set; }
    }

    public class TransactionPost : TransactionBase
    {
    }


}
