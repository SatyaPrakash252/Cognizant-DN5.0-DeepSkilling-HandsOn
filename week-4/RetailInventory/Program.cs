using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

Console.WriteLine("========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("========================================");

using var context = new AppDbContext();

Console.WriteLine("\n===== AsNoTracking() =====\n");

var products = await context.Products
    .AsNoTracking()
    .ToListAsync();

foreach (var product in products)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

Console.WriteLine("\n===== Compiled Query =====\n");

var expensiveProductsQuery =
    EF.CompileAsyncQuery(
        (AppDbContext ctx, decimal price) =>
            ctx.Products.Where(p => p.Price > price));

await foreach (var product in expensiveProductsQuery(context, 10000))
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

Console.WriteLine("\nLab 13 Completed Successfully!");