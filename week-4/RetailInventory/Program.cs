using RetailInventory.Data;

Console.WriteLine("==========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("==========================================");

using var context = new AppDbContext();

Console.WriteLine("Database Context Created Successfully!");