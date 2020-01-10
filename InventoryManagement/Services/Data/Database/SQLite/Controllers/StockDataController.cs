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

            if (stockDTO == null)
                return null;

            return new StockGet(m_Context, stockDTO);
        }

        public List<StockGet> GetAll()
        {
            var stockDTOs = m_Context.Stocks
                                .AsNoTracking()
                                .ToList();

            if (stockDTOs == null)
                return null;

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

            if (stockDTO == null)
                return null;

            return new StockGet(m_Context, stockDTO);
        }

        public StockGet Post(StockPost post)
        {
            var stockDTO = new StockDTO(post);
            m_Context.Stocks.Add(stockDTO);
            m_Context.SaveChanges();

            if (stockDTO == null)
                return null;

            return new StockGet(m_Context, stockDTO);
        }

        public StockGet Put(StockPost post)
        {
            var stockDTO = m_Context.GetStock(post.ID);

            if (stockDTO == null)
                return null;

            stockDTO.CopyFrom(post);

            m_Context.Entry(stockDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new StockGet(m_Context, stockDTO);
        }

    }
}
