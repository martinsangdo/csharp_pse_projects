public class ProductDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public required string description { get; set; }
    public required string image_url { get; set; }
    public byte category_id { get; set; }
}
