using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

Console.WriteLine("========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("========================================");

using var context = new AppDbContext();

try
{
    var product = await context.Products.FirstOrDefaultAsync();

    if (product != null)
    {
        product.Quantity += 5;

        await context.SaveChangesAsync();

        Console.WriteLine("Product updated successfully.");
    }
    else
    {
        Console.WriteLine("No product found.");
    }
}
catch (DbUpdateConcurrencyException)
{
    Console.WriteLine("Concurrency conflict detected.");
}

Console.WriteLine("\nLab 15 Completed Successfully!");