using System.ComponentModel.DataAnnotations;

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

    public ProductDetail? ProductDetail { get; set; }

    public ICollection<Tag> Tags { get; set; } = new List<Tag>();

    [Timestamp]
    public byte[]? RowVersion { get; set; }
}