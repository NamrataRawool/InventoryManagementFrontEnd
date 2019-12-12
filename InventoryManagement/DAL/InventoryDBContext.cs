using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DAL
{
    public class InventoryDBContext : DbContext
    {
        public InventoryDBContext() :
           base(new SQLiteConnection()
           {
               ConnectionString = new SQLiteConnectionStringBuilder()
               {
                   DataSource = "InventoryDBContext.db",
                   ForeignKeys = true
               }.ConnectionString
           }, true)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {  // Map table names
            modelBuilder.Entity<Product>().ToTable("Products");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
    public class SQLiteConfiguration : DbConfiguration
    {
        public SQLiteConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", 
                (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }
}
