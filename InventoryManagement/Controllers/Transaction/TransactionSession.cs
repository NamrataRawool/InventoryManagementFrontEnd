using InventoryManagement.Models;
using InventoryManagement.Services.Misc.Assert;
using System.Collections.Generic;

namespace InventoryManagement.Controllers.Transaction
{
    public class BillProductDetails
    {
        public BillProductDetails(ProductGet product, int quantity = 0, double finalPrice = 0)
        {
            Product = product;
            Quantity = quantity;
            FinalPrice = finalPrice;
        }

        public ProductGet Product;
        public double FinalPrice;
        public int Quantity;
    }

    public class TransactionSession
    {
        private List<BillProductDetails> m_RowEntries;
        private CustomerGet m_Customer;
        public string subtotal;
        public string totalDiscount;
        public string totalTax;
        public string amountDue;
        public string amountPaid;
        public string pendingAmount;

        public TransactionSession()
        {
            m_RowEntries = new List<BillProductDetails>();
            m_Customer = new CustomerGet();
        }

        public List<BillProductDetails> GetRowEntries()
        {
            return m_RowEntries;
        }

        public BillProductDetails GetRowEntry(int id)
        {
            if (m_RowEntries == null || m_RowEntries.Count <= 0)
            {
                Assert.Do("This should not have happened!");
                return null;
            }

            foreach (var entry in m_RowEntries)
                if (entry.Product.ID == id)
                    return entry;

            return null;
        }

        public CustomerGet GetCustomer()
        {
            return m_Customer;
        }

        public void SetCustomer(CustomerGet customer)
        {
            m_Customer = customer;
        }

        public void AddRowEntry(BillProductDetails productDetails)
        {
            var product = productDetails.Product;
            foreach (var p in m_RowEntries)
            {
                if (p.Product.ID == product.ID)
                {
                    p.Quantity = productDetails.Quantity;
                    p.Product = product;
                    p.FinalPrice = productDetails.FinalPrice;
                    return;
                }
            }

            m_RowEntries.Add(productDetails);
        }

        public void UpdateRowEntry(BillProductDetails productDetails)
        {
            var product = productDetails.Product;
            foreach (var p in m_RowEntries)
            {
                if (p.Product.ID == product.ID)
                {
                    p.Quantity = productDetails.Quantity;
                    p.FinalPrice = productDetails.FinalPrice;
                    return;
                }
            }
        }

        public void DeleteRowEntry(int productId)
        {
            foreach (var entry in m_RowEntries)
            {
                if (entry.Product.ID == productId)
                {
                    m_RowEntries.Remove(entry);
                    return;
                }
            }
        }

    }
}
