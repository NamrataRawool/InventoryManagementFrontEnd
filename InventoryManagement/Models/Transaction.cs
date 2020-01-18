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

        public TransactionProductDetails(ProductGet p, int q)
        {
            Product = p;
            Quantity = q;
        }

        public ProductGet Product { get; set; }

        public int Quantity { get; set; }
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
            ProductIDs = rhs.ProductIDs;
            ProductQuantity = rhs.ProductQuantity;
            TransactionDateTime = rhs.TransactionDateTime;
            CustomerID = rhs.CustomerID;
        }

        public int ID { get; set; }

        public double TotalPrice { get; set; }

        public string ProductIDs { get; set; }

        public string ProductQuantity { get; set; }

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
            for (int i = 0; i < IDs.Length; ++i)
            {
                string sID = IDs[i];
                string sQuantity = Quantities[i];
                if (!string.IsNullOrEmpty(sID))
                {
                    int ID = int.Parse(sID);
                    int Quantity = int.Parse(sQuantity);
                    ProductDetailsList.Add(new TransactionProductDetails(new ProductGet(context, context.GetProduct(ID)), Quantity));
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
