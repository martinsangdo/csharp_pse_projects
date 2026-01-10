
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int ProductID { get; set; }  //auto match with product_id
    public required string Name { get; set; }
    public required string Description { get; set; }

    public int CategoryID { get; set; }
    public required int BrandID { get; set; }

    public double Price { get; set; }
    public byte Quantity { get; set; }
    public bool IsActive { get; set; }
    public double Star { get; set; }
    public string? ImageUrl { get; set; }    // virtual field from ProductImages
}
