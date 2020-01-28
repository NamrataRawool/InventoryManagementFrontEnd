using InventoryManagement.Services.Data.Database;
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
        public ProductBase() { }
        public ProductBase(ProductBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(ProductBase rhs)
        {
            ID = rhs.ID;
            Barcode = rhs.Barcode;
            Name = rhs.Name;
            Description = rhs.Description;
            RetailPrice = rhs.RetailPrice;
            WholeSalePrice = rhs.WholeSalePrice;
            ImagePath = rhs.ImagePath;
            CGST = rhs.CGST;
            SGST = rhs.SGST;
            Discount = rhs.Discount;
        }

        public int ID { get; set; }

        public string Barcode { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int RetailPrice { get; set; }

        public int WholeSalePrice { get; set; }

        public string ImagePath { get; set; }

        public double SGST { get; set; }

        public double CGST { get; set; }

        public double Discount { get; set; }
    }

    public class ProductPost : ProductBase
    {

        public ProductPost(ProductGet get)
            : base(get)
        {
            CategoryID = get.Category.ID;
        }

        public ProductPost() { }

        public int CategoryID { get; set; }
    }

    public class ProductGet : ProductBase
    {
        public ProductGet() { }

        public ProductGet(InventoryDbContext context, ProductDTO productDto)
            : base(productDto)
        {
            ImagePath = productDto.ImagePath;
            if (productDto.CategoryID != 0)
                Category = new CategoryGet(context, context.GetCategory(productDto.CategoryID));
        }

        public CategoryGet Category { get; set; }
    }

    public class ProductDTO : ProductBase
    {
        public ProductDTO() { }

        public ProductDTO(ProductPost productPOST)
            : base(productPOST)
        {
            CategoryID = productPOST.CategoryID;
        }

        public void CopyFrom(ProductPost productPOST)
        {
            base.CopyFrom(productPOST);
            CategoryID = productPOST.CategoryID;
        }

        public int CategoryID { get; set; }

    }

}
