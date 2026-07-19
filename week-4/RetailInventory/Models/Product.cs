namespace RetailInventory.Models;

public class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public string Description { get; set; } = string.Empty;

    public int CategoryId { get; set; }

    public Category? Category { get; set; }

    // One-to-One Relationship
    public ProductDetail? ProductDetail { get; set; }

    // Many-to-Many Relationship
    public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}