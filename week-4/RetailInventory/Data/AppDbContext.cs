using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    public DbSet<Category> Categories { get; set; }

    public DbSet<ProductDetail> ProductDetails { get; set; }

    public DbSet<Tag> Tags { get; set; }

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
        // One-to-One
        modelBuilder.Entity<Product>()
            .HasOne(p => p.ProductDetail)
            .WithOne(pd => pd.Product)
            .HasForeignKey<ProductDetail>(pd => pd.ProductId);

        // Seed Categories
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

        // Seed Products
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