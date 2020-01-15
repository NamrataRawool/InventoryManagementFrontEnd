using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class VendorDataController : IDataController
    {
        public VendorDataController(InventoryDbContext context) 
            : base(context)
        {
        }

        public VendorGet Get(int id)
        {
            var vendorDTO = m_Context.GetVendor(id);

            if (vendorDTO == null)
                return null;

            return new VendorGet(m_Context, vendorDTO);
        }

        public List<VendorGet> GetAll()
        {
            var vendorDTOs = m_Context.Vendors
                                .AsNoTracking()
                                .ToList();

            if (vendorDTOs == null)
                return null;

            List<VendorGet> outList = new List<VendorGet>();
            foreach (var dto in vendorDTOs)
                outList.Add(new VendorGet(m_Context, dto));

            return outList;
        }

        public VendorGet Post(VendorPost post)
        {
            var vendorDTO = new VendorDTO(post);
            m_Context.Vendors.Add(vendorDTO);
            m_Context.SaveChanges();

            if (vendorDTO == null)
                return null;

            return new VendorGet(m_Context, vendorDTO);
        }

        public VendorGet Put(VendorPost post)
        {
            var vendorDTO = m_Context.GetVendor(post.ID);

            if (vendorDTO == null)
                return null;

            vendorDTO.CopyFrom(post);

            m_Context.Entry(vendorDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new VendorGet(m_Context, vendorDTO);
        }

        public VendorGet GetByName(string name)
        {
            var vendorDTO = m_Context.Vendors
                    .AsNoTracking()
                    .FirstOrDefault(v => v.CompanyName.Equals(name));

            return new VendorGet(m_Context, vendorDTO);
        }

    }
}
