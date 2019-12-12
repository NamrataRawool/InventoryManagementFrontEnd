using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class CustomerBase
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public int TotalAmount { get; set; }

        public int PendingAmount { get; set; }

    }

    public class CustomerPost : CustomerBase { }

    public class CustomerGet : CustomerBase { }

}
