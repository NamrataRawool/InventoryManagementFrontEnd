using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class CategoryBase
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Discount { get; set; }

        public double CGST { get; set; }

        public double SGST { get; set; }

    }

    public class CategoryPost : CategoryBase { }

    public class CategoryGet : CategoryBase { }

}
