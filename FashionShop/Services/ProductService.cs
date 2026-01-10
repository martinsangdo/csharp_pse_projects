
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

    public PagedResult<ProductDto> GetListPagination(int page, int limit)
    {
        var query =
            from p in _db.Products
            join i in _db.ProductImages on p.ProductID equals i.ProductID into imgs
            select new ProductDto
            {
                ProductID = p.ProductID,
                Name = p.Name,
                Price = p.Price,
                Description = p.Description,
                ImageUrl = imgs.Select(x => x.Url).FirstOrDefault()   // FIRST image
            };

        var total = query.Count();

        var data = query.OrderBy(x => x.ProductID)
                        .Skip((page - 1) * limit)
                        .Take(limit)
                        .ToList();

        return new PagedResult<ProductDto>
        {
            Page = page,
            Limit = limit,
            Total = total,
            Data = data
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