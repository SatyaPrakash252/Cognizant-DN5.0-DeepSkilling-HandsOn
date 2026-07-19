using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;
using RetailInventory.Models;

Console.WriteLine("========================================");
Console.WriteLine(" Retail Inventory Management System");
Console.WriteLine("========================================");

using var context = new AppDbContext();

// Create a Product Detail
var detail = new ProductDetail
{
    WarrantyInfo = "2 Years Warranty",
    ProductId = 1
};

// Create Tags
var tag1 = new Tag
{
    Name = "Popular"
};

var tag2 = new Tag
{
    Name = "Featured"
};

context.ProductDetails.Add(detail);
context.Tags.AddRange(tag1, tag2);

await context.SaveChangesAsync();

Console.WriteLine("\nLab 11 Completed Successfully!");