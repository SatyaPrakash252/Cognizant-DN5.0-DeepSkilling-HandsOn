namespace RetailInventory.Models;

public class Tag
{
    public int TagId { get; set; }

    public string Name { get; set; } = string.Empty;

    public ICollection<Product> Products { get; set; } = new List<Product>();
}