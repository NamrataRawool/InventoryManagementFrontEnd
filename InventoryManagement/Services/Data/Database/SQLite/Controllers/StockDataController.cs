using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class StockDataController : IDataController
    {
        public StockDataController(InventoryDbContext context) 
            : base(context)
        {
        }

        public StockGet Get(int id)
        {
            var stockDTO = m_Context.GetStock(id);
            return new StockGet(m_Context, stockDTO);
        }

        public List<StockGet> GetAll()
        {
            var stockDTOs = m_Context.Stocks
                                .AsNoTracking()
                                .ToList();

            List<StockGet> outList = new List<StockGet>();
            foreach (var dto in stockDTOs)
                outList.Add(new StockGet(m_Context, dto));

            return outList;
        }

        public StockGet GetByProductID(int ProductID)
        {
            var stockDTO = m_Context.Stocks
                            .AsNoTracking()
                            .FirstOrDefaultAsync(s => s.ProductID == ProductID)
                            .Result;

            return new StockGet(m_Context, stockDTO);
        }

        public StockGet Post(StockPost post)
        {
            var dto = new StockDTO(post);
            m_Context.Stocks.Add(dto);
            m_Context.SaveChanges();

            return new StockGet(m_Context, dto);
        }

        public StockGet Put(StockPost post)
        {
            var dto = m_Context.GetStock(post.ID);
            dto.CopyFrom(post);

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new StockGet(m_Context, dto);
        }

    }
}
