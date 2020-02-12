using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagement.Services.Data.Database;

namespace InventoryManagement.Models
{
    public class CustomerBase
    {
        public CustomerBase() { }

        public CustomerBase(CustomerBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(CustomerBase rhs)
        {
            ID = rhs.ID;
            Name = rhs.Name;
            Email = rhs.Email;
            MobileNumber = rhs.MobileNumber;
            PendingAmount = rhs.PendingAmount;
            TotalAmount = rhs.TotalAmount;
            DateAdded = rhs.DateAdded;
        }

        public int ID { get; set; }

        public string Name { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public double TotalAmount { get; set; }

        public double PendingAmount { get; set; }

        public DateTime DateAdded { get; protected set; }

    }

    public class CustomerPost : CustomerBase
    {
        public CustomerPost() 
            : base()
        {
            DateAdded = DateTime.Now;
        }
    }

    public class CustomerGet : CustomerBase
    {
        public CustomerGet() { }

        public CustomerGet(InventoryDbContext context, CustomerDTO customerDTO)
            : base(customerDTO)
        {
        }
    }

    public class CustomerDTO : CustomerBase
    {
        public CustomerDTO()
        {

        }
        public CustomerDTO(CustomerPost customerPOST) 
            : base(customerPOST)
        {
        }
    }

}
