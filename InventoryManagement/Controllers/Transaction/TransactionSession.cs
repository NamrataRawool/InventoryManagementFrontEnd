using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers.Transaction
{
    public class BillProductDetails
    {
        public ProductGet Product;
        public double FinalPrice;
    }
    public class TransactionSession
    {
        private List<BillProductDetails> m_rowEntries;
        private CustomerGet m_customer;
        public string subtotal;
        public string totalDiscount;
        public string totalTax;
        public string amountDue;
        public string amountPaid;

        public TransactionSession()
        {
            m_rowEntries = new List<BillProductDetails>();
            m_customer = new CustomerGet();
        }

        public List<BillProductDetails> GetRowEntries()
        {
            return m_rowEntries;
        }
        public BillProductDetails GetRowEntry(int id)
        {
            if (m_rowEntries == null)
                return null;
            foreach (var entry in m_rowEntries)
            {
                if (entry.Product.ID == id)
                {
                    return entry;
                }
            }
            return null;
        }
        public CustomerGet GetCustomer()
        {
            return m_customer;
        }
        public void SetCustomer(CustomerGet customer)
        {
            m_customer = customer;
        }

        public void AddRowEntry(ProductGet product, double finalPrice)
        {
            BillProductDetails billProduct = new BillProductDetails();
            foreach (var p in m_rowEntries)
            {
                if (p.Product.ID == product.ID)
                {
                    p.Product.Quantity += product.Quantity;
                    p.Product = product;
                    p.FinalPrice = finalPrice;
                    return;
                }
            }
            billProduct.Product = product;
            billProduct.FinalPrice = finalPrice;
            m_rowEntries.Add(billProduct);
        }

        public void UpdateRowEntry(ProductGet product, double finalPrice)
        {
            foreach (var p in m_rowEntries)
            {
                if (p.Product.ID == product.ID)
                {
                    p.Product.Quantity = product.Quantity;
                    p.FinalPrice = finalPrice;
                    return;
                }
            }
        }
        public void DeleteRowEntry(int productId)
        {
            foreach (var entry in m_rowEntries)
            {
                if (entry.Product.ID == productId)
                {
                    m_rowEntries.Remove(entry);
                    return;
                }
            }
        }
    }
}
