﻿using InventoryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace InventoryManagement.Services.Data.Database
{
    public class InventoryDbContext : DbContext
    {
        public DbSet<ProductDTO> Products { get; set; }
        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<TransactionDTO> Transactions { get; set; }
        public DbSet<CustomerDTO> Customers { get; set; }
        public DbSet<StockDTO> Stocks { get; set; }
        public DbSet<VendorDTO> Vendors { get; set; }
        public DbSet<PurchaseDTO> Purchases { get; set; }

        public ProductDTO GetProduct(int ID) { return Products.Find(ID); }
        public CategoryDTO GetCategory(int ID) { return Categories.Find(ID); }
        public TransactionDTO GetTransaction(int ID) { return Transactions.Find(ID); }
        public CustomerDTO GetCustomer(int ID) { return Customers.Find(ID); }
        public VendorDTO GetVendor(int ID) { return Vendors.Find(ID); }
        public StockDTO GetStock(int ID) { return Stocks.Find(ID); }
        public PurchaseDTO GetPurchase(int ID) { return Purchases.Find(ID); }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=InventoryDb.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<ProductDTO>().ToTable("Products");
            modelBuilder.Entity<ProductDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CategoryDTO>().ToTable("Categories");
            modelBuilder.Entity<CategoryDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            //modelBuilder.Entity<Tax>().ToTable("Taxes");
            //modelBuilder.Entity<Tax>(entity =>
            //{
            //    entity.HasKey(e => e.TaxID);
            //    entity.Property(e => e.TaxID).ValueGeneratedOnAdd();
            //});

            modelBuilder.Entity<TransactionDTO>().ToTable("Transactions");
            modelBuilder.Entity<TransactionDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CustomerDTO>().ToTable("Customers");
            modelBuilder.Entity<CustomerDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<StockDTO>().ToTable("Stocks");
            modelBuilder.Entity<StockDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PurchaseDTO>().ToTable("Purchases");
            modelBuilder.Entity<PurchaseDTO>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
