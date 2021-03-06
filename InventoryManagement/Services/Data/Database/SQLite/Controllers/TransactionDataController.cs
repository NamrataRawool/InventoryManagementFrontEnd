﻿using InventoryManagement.Models;
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

            if (transactionDTO == null)
                return null;

            return new TransactionGet(m_Context, transactionDTO);
        }

        public List<TransactionGet> GetAll()
        {
            var transactionDTOs = m_Context.Transactions
                                .AsNoTracking()
                                .ToList();

            if (transactionDTOs == null)
                return null;

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

            if (transactionsDTOs == null)
                return null;

            List<TransactionGet> outList = new List<TransactionGet>();
            foreach (var dto in transactionsDTOs)
                outList.Add(new TransactionGet(m_Context, dto));

            return outList;
        }

        public List<TransactionGet> GetTodaysTransactions()
        {
            DateTime date = DateTime.Now;
            DateTime today = new DateTime(date.Year, date.Month, date.Day);
            date = date.AddDays(1);
            DateTime tomorrow = new DateTime(date.Year, date.Month, date.Day);
            return GetByDate(today, tomorrow);
        }

        public double GetTodaysTransactionAmount()
        {
            return GetTotalTransactionAmount(DateTime.Now, DateTime.Now);
        }

        public double GetTotalTransactionAmount(DateTime from, DateTime to)
        {
            double amount = 0.0;

            List<TransactionGet> todaysTransaction = GetByDate(from, to);
            foreach(TransactionGet t in todaysTransaction)
                amount += GetTotalBuyingPrice(t);

            return amount;
        }

        public List<TransactionGet> GetByDate(DateTime from, DateTime to)
        {
            List<TransactionDTO> transactionsDTOs = m_Context.Transactions
                                    .Where(t => t.TransactionDateTime.Date >= from.Date && t.TransactionDateTime.Date <= to.Date)
                                    .ToListAsync()
                                    .Result;

            if (transactionsDTOs == null)
                return null;

            List<TransactionGet> transactionList = new List<TransactionGet>();
            foreach (var dto in transactionsDTOs)
                transactionList.Add(new TransactionGet(m_Context, dto));

            return transactionList;
        }

        public TransactionGet Post(TransactionPost post)
        {
            var transactionDTO = new TransactionDTO(post);

            if (transactionDTO == null)
                return null;

            m_Context.Transactions.Add(transactionDTO);
            m_Context.SaveChanges();

            return new TransactionGet(m_Context, transactionDTO);
        }

        public TransactionGet Put(TransactionPost post)
        {
            var transactionDTO = m_Context.GetTransaction(post.ID);

            if (transactionDTO == null)
                return null;

            transactionDTO.CopyFrom(post);

            m_Context.Entry(transactionDTO).State = EntityState.Modified;

            m_Context.SaveChanges();

            return new TransactionGet(m_Context, transactionDTO);
        }

        private double GetTotalBuyingPrice(TransactionGet transaction)
        {
            double amount = 0.0;

            string[] buyingPrices = transaction.BuyingPrices.Split(',');
            string[] quantities = transaction.ProductQuantity.Split(',');
            string[] discounts = transaction.Discounts.Split(',');
            for (int i = 0; i < buyingPrices.Length; ++i)
            {
                double price = double.Parse(buyingPrices[i]);
                int quantity = int.Parse(quantities[i]);
                double discount = double.Parse(discounts[i]);
                amount += ((price * (100 - discount) / 100)) * quantity;
            }
            amount += transaction.TotalTax;

            return amount;
        }

    }
}
