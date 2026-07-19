using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;
              Database=RetailInventoryDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                Name = "Electronics"
            },
            new Category
            {
                CategoryId = 2,
                Name = "Groceries"
            }
        );

        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                Name = "Smartphone",
                Price = 25000,
                Quantity = 50,
                Description = "Android Smartphone",
                CategoryId = 1
            },
            new Product
            {
                ProductId = 2,
                Name = "Wheat Flour",
                Price = 800,
                Quantity = 100,
                Description = "5 Kg Pack",
                CategoryId = 2
            }
        );
    }
}