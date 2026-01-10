
using System.ComponentModel.DataAnnotations.Schema;

public class Category
{
    public int CategoryID { get; set; }
    public required string CategoryName { get; set; }
    public int? ParentID { get; set; }
}
