using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Services.Data.Database.SQLite.Controllers
{
    public class TransactionDataController : IDataController
    {
        public TransactionDataController(InventoryDbContext context) 
            : base(context)
        {
        }

        public TransactionGet Get(int id)
        {
            var transactionDTO = m_Context.GetTransaction(id);
            return new TransactionGet(m_Context, transactionDTO);
        }

        public List<TransactionGet> GetAll()
        {
            var transactionDTOs = m_Context.Transactions
                                .AsNoTracking()
                                .ToList();

            List<TransactionGet> outList = new List<TransactionGet>();
            foreach (var dto in transactionDTOs)
                outList.Add(new TransactionGet(m_Context, dto));

            return outList;
        }

        public List<TransactionGet> GetByCustomerID(int CustomerID)
        {
            List<TransactionDTO> transactionsDTOs = m_Context.Transactions
                                .Where(t => t.CustomerID == CustomerID)
                                .ToListAsync()
                                .Result;

            List<TransactionGet> outList = new List<TransactionGet>();
            foreach (var dto in transactionsDTOs)
                outList.Add(new TransactionGet(m_Context, dto));

            return outList;
        }

        public List<TransactionGet> GetByDate(DateTime from, DateTime to)
        {
            List<TransactionDTO> transactionsDTOs = m_Context.Transactions
                                    .Where(t => t.TransactionDateTime.Date >= from.Date && t.TransactionDateTime.Date <= to.Date)
                                    .ToListAsync()
                                    .Result;

            List<TransactionGet> transactionList = new List<TransactionGet>();
            foreach (var dto in transactionsDTOs)
                transactionList.Add(new TransactionGet(m_Context, dto));

            return transactionList;
        }

        public TransactionGet Post(TransactionPost post)
        {
            var dto = new TransactionDTO(post);
            m_Context.Transactions.Add(dto);
            m_Context.SaveChanges();

            return new TransactionGet(m_Context, dto);
        }

        public TransactionGet Put(TransactionPost post)
        {
            var dto = m_Context.GetTransaction(post.ID);
            dto.CopyFrom(post);

            m_Context.Entry(dto).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new TransactionGet(m_Context, dto);
        }

    }
}
