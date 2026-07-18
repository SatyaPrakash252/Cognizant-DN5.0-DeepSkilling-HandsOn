using RetailInventory.Data;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

// -------------------- Display All Products --------------------

Console.WriteLine("\n===== All Products =====");

var allProducts = context.Products.ToList();

foreach (var product in allProducts)
{
    Console.WriteLine($"{product.ProductId} - {product.Name} - ₹{product.Price}");
}

// -------------------- Filter Products --------------------

Console.WriteLine("\n===== Products with Price > 1000 =====");

var expensiveProducts = context.Products
                               .Where(p => p.Price > 1000)
                               .ToList();

foreach (var product in expensiveProducts)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

// -------------------- Sort Products --------------------

Console.WriteLine("\n===== Products Sorted by Price =====");

var sortedProducts = context.Products
                            .OrderBy(p => p.Price)
                            .ToList();

foreach (var product in sortedProducts)
{
    Console.WriteLine($"{product.Name} - ₹{product.Price}");
}

// -------------------- Find Specific Product --------------------

Console.WriteLine("\n===== Find Product: Laptop =====");

var laptop = context.Products
                    .FirstOrDefault(p => p.Name == "Laptop");

if (laptop != null)
{
    Console.WriteLine($"Found: {laptop.Name} - ₹{laptop.Price}");
}
else
{
    Console.WriteLine("Product not found.");
}