using InventoryManagement.Services.Data.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class VendorBase
    {

        public VendorBase() { }

        public VendorBase(VendorBase rhs)
        {
            CopyFrom(rhs);
        }

        public void CopyFrom(VendorBase rhs)
        {
            ID = rhs.ID;
            CompanyName = rhs.CompanyName;
            Address = rhs.Address;
            Email = rhs.Email;
            MobileNumber = rhs.MobileNumber;
            City = rhs.City;
            State = rhs.State;
        }

        [Key]
        public int ID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }

    public class VendorGet : VendorBase
    {

        public VendorGet() { }

        public VendorGet(InventoryDbContext context, VendorDTO dto)
            : base(dto)
        {
        }

    }

    public class VendorPost : VendorBase { }

    public class VendorDTO : VendorBase
    {
        public VendorDTO() { }

        public VendorDTO(VendorPost vendorPOST)
            : base(vendorPOST)
        {
        }
    }


}
