using Microsoft.EntityFrameworkCore;
using EFCore_Lab5_RetrieveData.Models;

namespace EFCore_Lab5_RetrieveData
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=RetailInventoryDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True");
        }
    }
}