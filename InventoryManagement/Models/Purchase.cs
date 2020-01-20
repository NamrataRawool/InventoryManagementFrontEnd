using InventoryManagement.Services.Data;
using InventoryManagement.Services.Data.Database;
using InventoryManagement.Services.Misc.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{

    public class PurchaseProductDetails
    {

        public PurchaseProductDetails(ProductGet product, int quantity, double buyingPrice)
        {
            Product = product;
            Quantity = quantity;
            BuyingPrice = buyingPrice;
        }

        public ProductGet Product;
        public int Quantity;
        public double BuyingPrice;
    }

    public class PurchaseBase
    {

        public PurchaseBase() { }

        public PurchaseBase(PurchaseBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(PurchaseBase rhs)
        {
            ID = rhs.ID;
            VendorID = rhs.VendorID;
            PurchaseDateTime = rhs.PurchaseDateTime;
            ProductIDs = rhs.ProductIDs;
            ProductQuantities = rhs.ProductQuantities;
            BuyingPrices = rhs.BuyingPrices;
        }

        public int ID { get; set; }
        public int VendorID { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public string ProductIDs { get; set; }
        public string ProductQuantities { get; set; }
        public string BuyingPrices { get; set; }
    }

    public class PurchaseDTO : PurchaseBase
    {
        public PurchaseDTO() { }

        public PurchaseDTO(PurchasePost purchasePOST)
            : base(purchasePOST)
        {
        }
    }

    public class PurchaseGet : PurchaseBase
    {

        public PurchaseGet(InventoryDbContext context, PurchaseDTO dto) : base(dto)
        {
            ProductDetails = new List<PurchaseProductDetails>();

            string[] productIDs = dto.ProductIDs.Split(',');
            string[] productQuantities = dto.ProductQuantities.Split(',');
            string[] buyingPrices = dto.BuyingPrices.Split(',');

            if (!((productIDs.Length == productQuantities.Length) && (productQuantities.Length == buyingPrices.Length)))
                Assert.Do("Invalid Purchase Entry!");

            int length = productIDs.Length;
            for (int i = 0; i < length; ++i)
            {
                int id = int.Parse(productIDs[i]);
                int quantity = int.Parse(productQuantities[i]);
                double price = double.Parse(buyingPrices[i]);

                ProductGet product = DataService.GetProductDataController().Get(id);
                PurchaseProductDetails detail = new PurchaseProductDetails(product, quantity, price);
                ProductDetails.Add(detail);
            }
            if (dto.VendorID != 0)
                Vendor = new VendorGet(context, context.GetVendor(dto.VendorID));

        }

        public List<PurchaseProductDetails> ProductDetails { get; set; }

        public VendorGet Vendor { get; set; }
    }

    public class PurchasePost : PurchaseBase { }

}
