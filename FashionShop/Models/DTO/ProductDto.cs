public class ProductDto
{
    public int ProductID { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public required string Description { get; set; }
    public string? ImageUrl { get; set; }
}
