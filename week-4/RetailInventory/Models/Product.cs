namespace RetailInventory.Models;

public class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    // NEW PROPERTY
    public string Description { get; set; } = string.Empty;

    // Foreign Key
    public int CategoryId { get; set; }

    // Navigation Property
    public Category? Category { get; set; }
}