using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.OrderService.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 1,CustomerName="Arif", ProductId = 1, Quantity = 20,OrderDate=DateTime.Now });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 2, CustomerName = "Shimul", ProductId = 2, Quantity = 20, OrderDate = DateTime.Now });
            modelBuilder.Entity<OrderModel>().HasData(new OrderModel { Id = 3, CustomerName = "Masum", ProductId = 3, Quantity = 20, OrderDate = DateTime.Now });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<OrderModel> Orders { get; set; }
    }
}
