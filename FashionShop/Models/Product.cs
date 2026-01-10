
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public Guid ProductID { get; set; }  //auto match with product_id
    public required string Name { get; set; }
    public string? Description { get; set; }

    public byte CategoryID { get; set; }
    public required byte BrandID { get; set; }

    public double Price { get; set; }
    public byte Quantity { get; set; }
    public bool IsActive { get; set; }

}
