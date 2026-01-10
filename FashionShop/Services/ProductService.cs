
using System.Text.Json;
using FashionShop.Services;

public class ProductService
{
    private readonly ExternalService _externalService;
    private readonly ApplicationDbContext _db;

    public ProductService(ExternalService externalService, ApplicationDbContext db)
    {
        _externalService = externalService;
        _db = db;
    }

    public List<Product> getListPagination()
    {
        return _db.Products.ToList();
    }
    //get top categories
    public List<Category> getLeafCategories()
    {
        var childCategories = _db.Categories
                              .Where(c => c.ParentID != null)
                              .Take(6)
                              .ToList();
        return childCategories;
    }
    //get top brands
    public List<Brand> getTopBrands()
    {
        var list = _db.Brands.Take(5)
                              .ToList();
        return list;
    }

}