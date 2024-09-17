﻿using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel {Id=1,Name="T-shirt",Quantity=20,Price=20 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "Pant", Quantity = 20, Price = 20 });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "Polo", Quantity = 20, Price = 20 });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
