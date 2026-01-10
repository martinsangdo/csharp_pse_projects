
using System.Text.Json;
using FashionShop.Services;
using Microsoft.EntityFrameworkCore;

public class ProductService
{
    private readonly ExternalService _externalService;
    private readonly ApplicationDbContext _db;

    public ProductService(ExternalService externalService, ApplicationDbContext db)
    {
        _externalService = externalService;
        _db = db;
    }

    public PagedResult<Product> GetListPagination(int page, int limit)
    {
        if (page < 1) page = 1;
        if (limit < 1) limit = 10;

        var query = _db.Products.AsNoTracking();

        return new PagedResult<Product>
        {
            Page = page,
            Limit = limit,
            Total = query.Count(),
            Data = query.OrderBy(p => p.ProductID)
                        .Skip((page - 1) * limit)
                        .Take(limit)
                        .ToList()
        };
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