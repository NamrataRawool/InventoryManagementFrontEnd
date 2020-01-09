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
            return new CustomerGet(m_Context, customerDTO);
        }

        public List<CustomerGet> GetAll()
        {
            var customerDTOs = m_Context.Customers
                                .AsNoTracking()
                                .ToList();

            List<CustomerGet> outList = new List<CustomerGet>();
            foreach (var dto in customerDTOs)
                outList.Add(new CustomerGet(m_Context, dto));

            return outList;
        }

        public CustomerGet GetByName(string name)
        {
            var customerDTO = m_Context.Customers
                                .AsNoTracking()
                                .FirstOrDefaultAsync(c => c.Name.Equals(name))
                                .Result;

            return new CustomerGet(m_Context, customerDTO);
        }

        public CustomerGet Post(CustomerPost post)
        {
            var dto = new CustomerDTO(post);
            m_Context.Customers.Add(dto);
            m_Context.SaveChanges();

            return new CustomerGet(m_Context, dto);
        }

        public CustomerGet Put(CustomerPost post)
        {
            var dto = m_Context.GetCustomer(post.ID);
            dto.CopyFrom(post);

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new CustomerGet(m_Context, dto);
        }

    }
}
