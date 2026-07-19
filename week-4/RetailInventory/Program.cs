using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

Console.WriteLine("\n===== Eager Loading =====\n");

var products = await context.Products
    .Include(p => p.Category)
    .ToListAsync();

foreach (var product in products)
{
    Console.WriteLine($"Product : {product.Name}");
    Console.WriteLine($"Price   : ₹{product.Price}");
    Console.WriteLine($"Category: {product.Category?.Name}");
    Console.WriteLine("-----------------------------------");
}

Console.WriteLine("\n===== Explicit Loading =====\n");

var firstProduct = await context.Products.FirstAsync();

await context.Entry(firstProduct)
             .Reference(p => p.Category)
             .LoadAsync();

Console.WriteLine($"Product : {firstProduct.Name}");
Console.WriteLine($"Category: {firstProduct.Category?.Name}");