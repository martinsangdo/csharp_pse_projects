
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

}