using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers.Transaction
{
    public class TransactionSession
    {
        private List<ProductGet> m_rowEntries;
        private CustomerGet m_customer;
        public string subtotal;
        public string totalDiscount;
        public string totalTax;
        public string amountDue;

        public TransactionSession()
        {
            m_rowEntries = new List<ProductGet>();
            m_customer = new CustomerGet();
        }

        public List<ProductGet> GetRowEntries()
        {
            return m_rowEntries;
        }

        public CustomerGet GetCustomer()
        {
            return m_customer;
        }
        public void SetCustomer(CustomerGet customer)
        {
            m_customer = customer;
        }

        public void AddRowEntry(ProductGet product)
        {
            foreach (var p in m_rowEntries)
            {
                if (p.ID == product.ID)
                {
                    p.Quantity += product.Quantity;
                    return;
                }
            }
            m_rowEntries.Add(product);
        }

        public void UpdateRowEntry(ProductGet product)
        {
            foreach (var p in m_rowEntries)
            {
                if (p.ID == product.ID)
                {
                    p.Quantity = product.Quantity;
                    return;
                }
            }
        }
        public void DeleteRowEntry(int productId)
        {
            foreach (var product in m_rowEntries)
            {
                if (product.ID == productId)
                {
                    m_rowEntries.Remove(product);
                    return;
                }
            }
        }
    }
}
