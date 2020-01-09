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
            return new VendorGet(m_Context, vendorDTO);
        }

        public List<VendorGet> GetAll()
        {
            var vendorDTOs = m_Context.Vendors
                                .AsNoTracking()
                                .ToList();

            List<VendorGet> outList = new List<VendorGet>();
            foreach (var dto in vendorDTOs)
                outList.Add(new VendorGet(m_Context, dto));

            return outList;
        }

        public VendorGet Post(VendorPost post)
        {
            var dto = new VendorDTO(post);
            m_Context.Vendors.Add(dto);
            m_Context.SaveChanges();

            return new VendorGet(m_Context, dto);
        }

        public VendorGet Put(VendorPost post)
        {
            var dto = m_Context.GetVendor(post.ID);
            dto.CopyFrom(post);

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new VendorGet(m_Context, dto);
        }

    }
}
