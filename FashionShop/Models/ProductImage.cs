
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ProductImage
{
    [Key]
    public int ImageID { get; set; }
    public int ProductID { get; set; }
    public required string Url { get; set; }
}
