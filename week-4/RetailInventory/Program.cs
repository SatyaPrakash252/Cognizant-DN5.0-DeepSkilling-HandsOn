using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.DTOs;

Console.WriteLine("========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("========================================");

using var context = new AppDbContext();

var productDTOs = await context.Products
    .Include(p => p.Category)
    .Select(p => new ProductDTO
    {
        Name = p.Name,
        CategoryName = p.Category != null
            ? p.Category.Name
            : "No Category"
    })
    .ToListAsync();

Console.WriteLine("\nProducts\n");

foreach (var product in productDTOs)
{
    Console.WriteLine($"Product  : {product.Name}");
    Console.WriteLine($"Category : {product.CategoryName}");
    Console.WriteLine("------------------------------------");
}

Console.WriteLine("\nLab 12 Completed Successfully!");