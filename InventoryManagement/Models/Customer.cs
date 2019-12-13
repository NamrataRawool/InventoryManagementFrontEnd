using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class CustomerBase
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [DisplayName("Mobile Number")]
        public string MobileNumber { get; set; }

        public string Email { get; set; }

        [DisplayName("Total Amount")]
        public int TotalAmount { get; set; }

        [DisplayName("Pending Amount")]
        public int PendingAmount { get; set; }

    }

    public class CustomerPost : CustomerBase { }

    public class CustomerGet : CustomerBase { }

}
