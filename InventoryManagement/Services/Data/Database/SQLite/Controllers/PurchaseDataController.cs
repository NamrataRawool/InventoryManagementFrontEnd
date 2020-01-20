using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class PurchaseDataController : IDataController
    {
        public PurchaseDataController(InventoryDbContext context) : base(context)
        {
        }

        public PurchaseGet Get(int id)
        {
            var purchaseDTO = m_Context.GetPurchase(id);

            if (purchaseDTO == null)
                return null;

            return new PurchaseGet(m_Context, purchaseDTO);
        }

        public List<PurchaseGet> GetAll()
        {
            var purchaseDTOs = m_Context.Purchases
                                .AsNoTracking()
                                .ToList();

            if (purchaseDTOs == null)
                return null;

            List<PurchaseGet> outList = new List<PurchaseGet>();
            foreach (var dto in purchaseDTOs)
                outList.Add(new PurchaseGet(m_Context, dto));

            return outList;
        }

        public PurchaseGet Post(PurchasePost post)
        {
            var purchaseDTO = new PurchaseDTO(post);
            m_Context.Purchases.Add(purchaseDTO);
            m_Context.SaveChanges();

            if (purchaseDTO == null)
                return null;

            return new PurchaseGet(m_Context, purchaseDTO);
        }

        public PurchaseGet Put(PurchasePost post)
        {
            var purchaseDTO = m_Context.GetPurchase(post.ID);

            if (purchaseDTO == null)
                return null;

            purchaseDTO.CopyFrom(post);

            m_Context.Entry(purchaseDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new PurchaseGet(m_Context, purchaseDTO);
        }
    }
}
