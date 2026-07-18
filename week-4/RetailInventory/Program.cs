using RetailInventory.Data;
using RetailInventory.Models;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

// Insert Category if it doesn't already exist
if (!context.Categories.Any())
{
    var electronics = new Category
    {
        Name = "Electronics"
    };

    context.Categories.Add(electronics);
    context.SaveChanges();

    Console.WriteLine("Category inserted successfully!");
}

// Insert Products if they don't already exist
if (!context.Products.Any())
{
    var category = context.Categories.First();

    var product1 = new Product
    {
        Name = "Laptop",
        Price = 75000,
        Quantity = 10,
        CategoryId = category.CategoryId
    };

    var product2 = new Product
    {
        Name = "Mouse",
        Price = 800,
        Quantity = 50,
        CategoryId = category.CategoryId
    };

    context.Products.Add(product1);
    context.Products.Add(product2);

    context.SaveChanges();

    Console.WriteLine("Products inserted successfully!");
}

Console.WriteLine("Data insertion completed.");