using RetailInventory.Data;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

// -------------------- UPDATE --------------------

var productToUpdate = context.Products.FirstOrDefault(p => p.Name == "Laptop");

if (productToUpdate != null)
{
    productToUpdate.Price = 80000;
    productToUpdate.Quantity = 8;

    context.SaveChanges();

    Console.WriteLine("Product updated successfully!");
}

// -------------------- DELETE --------------------

var productToDelete = context.Products.FirstOrDefault(p => p.Name == "Mouse");

if (productToDelete != null)
{
    context.Products.Remove(productToDelete);

    context.SaveChanges();

    Console.WriteLine("Product deleted successfully!");
}

// -------------------- DISPLAY --------------------

Console.WriteLine("\nCurrent Products:\n");

var products = context.Products.ToList();

foreach (var product in products)
{
    Console.WriteLine($"ID       : {product.ProductId}");
    Console.WriteLine($"Name     : {product.Name}");
    Console.WriteLine($"Price    : ₹{product.Price}");
    Console.WriteLine($"Quantity : {product.Quantity}");
    Console.WriteLine("------------------------------");
}