using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("=======================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("=======================================");

using var context = new AppDbContext();

var products = await context.Products.ToListAsync();

Console.WriteLine("\nSeeded Products\n");

foreach (var product in products)
{
    Console.WriteLine($"{product.ProductId} - {product.Name} - ₹{product.Price}");
}