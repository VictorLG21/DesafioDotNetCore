using Microsoft.EntityFrameworkCore;
using DesafioDotNetCoreKhipo.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DesafioDotNetCoreKhipo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    CreatedAt = new DateTime(2022, 05, 20, 00, 31, 08),
                    Name = "Incredible Plastic Pants",
                    Price = (decimal)827.00,
                    Brand = "Hauck - Johnson",
                    UpdatedAt = new DateTime(2022, 05, 22, 02, 31, 08),
                    ID = 1
                },
                new Products
                {
                    CreatedAt = new DateTime(2022, 05, 20, 09, 05, 23),
                    Name = "Electronic Wooden Tuna",
                    Price = (decimal)765.00,
                    Brand = "Johns - Farrell",
                    UpdatedAt = new DateTime(2022, 05, 20, 09, 05, 23),
                    ID = 2
                },
                new Products
                {
                    CreatedAt = new DateTime(2022, 05, 20, 02, 07, 28),
                    Name = "Awesome Steel Mouse",
                    Price = (decimal)143.00,
                    Brand = "Paucek, Kuvalis and Zieme",
                    UpdatedAt = new DateTime(2022, 05, 23, 22, 35, 23),
                    ID = 3
                }
            );
        }
    }
}
