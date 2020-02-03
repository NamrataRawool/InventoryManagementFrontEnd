using InventoryManagement.Services.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{

    public class TransactionProductDetails
    {

        public TransactionProductDetails(ProductGet product, int quantity, double buyingPrice, double discount)
        {
            Product = product;
            Quantity = quantity;
            BuyingPrice = buyingPrice;
            Discount = discount;
        }

        public ProductGet Product { get; set; }

        public int Quantity { get; set; }

        public double BuyingPrice { get; set; }

        public double Discount { get; set; }
    }

    public class TransactionBase
    {

        public TransactionBase() { }

        public TransactionBase(TransactionBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(TransactionBase rhs)
        {
            ID = rhs.ID;
            TotalPrice = rhs.TotalPrice;
            TotalTax = rhs.TotalTax;
            ProductIDs = rhs.ProductIDs;
            ProductQuantity = rhs.ProductQuantity;
            BuyingPrices = rhs.BuyingPrices;
            Discounts = rhs.Discounts;
            TransactionDateTime = rhs.TransactionDateTime;
            CustomerID = rhs.CustomerID;
        }

        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public double TotalTax { get; set; }

        public string ProductIDs { get; set; }

        public string ProductQuantity { get; set; }

        public string BuyingPrices { get; set; }

        public string Discounts { get; set; }

        public DateTime TransactionDateTime { get; set; }

        public int CustomerID { get; set; }
    }

    public class TransactionGet : TransactionBase
    {
        public TransactionGet(InventoryDbContext context, TransactionDTO dto)
            : base(dto)
        {
            ProductDetailsList = new List<TransactionProductDetails>();

            // fill ProductDetails
            string[] IDs = dto.ProductIDs.Split(',');
            string[] Quantities = dto.ProductQuantity.Split(',');
            string[] BuyingPrices = dto.BuyingPrices.Split(',');
            string[] Discounts = dto.Discounts.Split(',');
            for (int i = 0; i < IDs.Length; ++i)
            {
                string sID = IDs[i];
                string sQuantity = Quantities[i];
                string sBuyingPrice = BuyingPrices[i];
                string sDiscount = Discounts[i];
                if (!string.IsNullOrEmpty(sID))
                {
                    int ID = int.Parse(sID);
                    int Quantity = int.Parse(sQuantity);
                    double BuyingPrice = double.Parse(sBuyingPrice);
                    double Discount = double.Parse(sDiscount);
                    ProductDetailsList.Add(new TransactionProductDetails(new ProductGet(context, context.GetProduct(ID)), Quantity, BuyingPrice, Discount));
                }
            }
            if (dto.CustomerID != 0)
                Customer = new CustomerGet(context, context.GetCustomer(dto.CustomerID));
        }

        public List<TransactionProductDetails> ProductDetailsList { get; set; }

        public CustomerGet Customer { get; set; }
    }

    public class TransactionPost : TransactionBase { }

    public class TransactionDTO : TransactionBase
    {
        public TransactionDTO() { }

        public TransactionDTO(TransactionPost transactionPOST)
            : base(transactionPOST)
        {
        }

    }

}
