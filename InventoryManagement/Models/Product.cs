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
    public class ProductUI
    {
        public ProductUI(ProductGet productGet)
        {
            ID = productGet.ID;
            Name = productGet.Name;
            Description = productGet.Description;
            RetailPrice = productGet.RetailPrice;
            WholeSalePrice = productGet.WholeSalePrice;
            Category = productGet.Category.Name;
        }

        [DisplayName("Bar Code")]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        [DisplayName("Retail Price")]
        public int RetailPrice { get; set; }

        [DisplayName("Wholesale Price")]
        public int WholeSalePrice { get; set; }

        public string Category { get; set; }
    }

    public class ProductBase
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RetailPrice { get; set; }

        public int WholeSalePrice { get; set; }

    }

    public class ProductPost : ProductBase
    {
        public int CategoryID { get; set; }
    }

    public class ProductGet : ProductBase
    {
        public string ImagePath { get; set; }

        public int Quantity { get; set; }

        public CategoryGet Category { get; set; }
    }

}
