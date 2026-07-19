using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

Console.WriteLine("========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("========================================");

using var context = new AppDbContext();

// Fetch all products
var productList = await context.Products.ToListAsync();

// Increase quantity of every product
foreach (var product in productList)
{
    product.Quantity += 10;
}

// Bulk Update
await context.BulkUpdateAsync(productList);

Console.WriteLine("\nBulk Update Completed Successfully!\n");

Console.WriteLine("Updated Products:\n");

foreach (var product in productList)
{
    Console.WriteLine($"{product.Name} - Quantity: {product.Quantity}");
}

Console.WriteLine("\nLab 14 Completed Successfully!");