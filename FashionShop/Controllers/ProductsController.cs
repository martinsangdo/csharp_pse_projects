using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private readonly ProductService _productService;

    public ProductsController(ILogger<ProductsController> logger, ProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    //homepage (product list)
    [Route("{page:int?}")]
    public IActionResult list(int page = 1)
    {
        //get products
        var products = _productService.GetListPagination(page, 6);
        ViewBag.products = products.Data;
        ViewBag.Page = products.Page;
        ViewBag.Total = products.Total;
        ViewBag.Limit = products.Limit;
        //categories
        ViewBag.categories = _productService.getLeafCategories();

        ViewBag.brands = _productService.getTopBrands();

        // ViewBag.categories = new List<string> { "Keyboard", "Mouse", "PC", "Printer" };
        return View("~/Views/malefashion/shop.cshtml");
    }

    //display page detail of a product
    [Route("/product/{id:int?}")]
    public IActionResult detail(int id)
    {

        return View("~/Views/malefashion/product-details.cshtml");
    }

    [Route("/category/{id:int?}")]
    public IActionResult categoryProducts(int id)
    {
        //categories
        ViewBag.categories = _productService.getLeafCategories();

        ViewBag.brands = _productService.getTopBrands();

        return View("~/Views/malefashion/category.cshtml");
    }
}