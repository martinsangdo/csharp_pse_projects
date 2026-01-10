
using System.ComponentModel.DataAnnotations.Schema;

public class Brand
{
    public Guid BrandID { get; set; }
    public required string BrandName { get; set; }
}
