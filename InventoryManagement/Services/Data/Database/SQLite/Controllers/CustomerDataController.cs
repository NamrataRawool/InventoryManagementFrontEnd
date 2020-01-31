using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class CustomerDataController : IDataController
    {
        public CustomerDataController(InventoryDbContext context)
            : base(context)
        {
        }

        public CustomerGet Get(int id)
        {
            var customerDTO = m_Context.GetCustomer(id);

            if (customerDTO == null)
                return null;

            return new CustomerGet(m_Context, customerDTO);
        }

        public List<CustomerGet> GetAll()
        {
            var customerDTOs = m_Context.Customers
                                .AsNoTracking()
                                .ToList();

            if (customerDTOs == null)
                return null;

            List<CustomerGet> outList = new List<CustomerGet>();
            foreach (var dto in customerDTOs)
                outList.Add(new CustomerGet(m_Context, dto));

            return outList;
        }

        public CustomerGet GetByName(string name)
        {
            var customerDTO = m_Context.Customers
                                .AsNoTracking()
                                .FirstOrDefaultAsync(c => c.Name.ToLower().Equals(name.ToLower()))
                                .Result;

            if (customerDTO == null)
                return null;

            return new CustomerGet(m_Context, customerDTO);
        }

        public CustomerGet GetByMobileNumber(string mobileNumber)
        {
            var customerDTO = m_Context.Customers
                                .AsNoTracking()
                                .FirstOrDefaultAsync(c => c.MobileNumber.Equals(mobileNumber))
                                .Result;

            if (customerDTO == null)
                return null;

            return new CustomerGet(m_Context, customerDTO);
        }

        public CustomerGet Post(CustomerPost post)
        {
            var customerDTO = new CustomerDTO(post);
            m_Context.Customers.Add(customerDTO);
            m_Context.SaveChanges();

            if (customerDTO == null)
                return null;

            return new CustomerGet(m_Context, customerDTO);
        }

        public CustomerGet Put(CustomerPost post)
        {
            var customerDTO = m_Context.GetCustomer(post.ID);

            if (customerDTO == null)
                return null;

            customerDTO.CopyFrom(post);

            m_Context.Entry(customerDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new CustomerGet(m_Context, customerDTO);
        }

    }
}
