using RetailInventory.Data;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

var products = context.Products.ToList();

Console.WriteLine("\n===== Product List =====\n");

foreach (var product in products)
{
    Console.WriteLine($"ID          : {product.ProductId}");
    Console.WriteLine($"Name        : {product.Name}");
    Console.WriteLine($"Price       : ₹{product.Price}");
    Console.WriteLine($"Quantity    : {product.Quantity}");
    Console.WriteLine($"Description : {product.Description}");
    Console.WriteLine("---------------------------------------");
}