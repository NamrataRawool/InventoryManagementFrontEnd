using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{

    public class ProductBase
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RetailPrice { get; set; }

        public int WholeSalePrice { get; set; }

        public string ImagePath { get; set; }
    }

    public class ProductPost : ProductBase
    {
        public int CategoryID { get; set; }
    }

    public class ProductGet : ProductBase
    {
        public int Quantity { get; set; }

        public CategoryGet Category { get; set; }
    }

}
