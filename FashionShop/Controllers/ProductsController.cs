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
    [Route("/")]
    public IActionResult list()
    {
        var products = _productService.getListPagination();
        ViewBag.products = products;

        //categories
        ViewBag.categories = _productService.getLeafCategories();

        ViewBag.brands = _productService.getTopBrands();

        // ViewBag.categories = new List<string> { "Keyboard", "Mouse", "PC", "Printer" };
        return View("~/Views/malefashion/shop.cshtml");
    }

    //display page detail of a product
    public IActionResult detail(int id)
    {
        return View();
    }

    [Route("products/shop/detail")]    //custom url
    public IActionResult showShopDetailPage()
    {
        return View("~/Views/malefashion/product-details.cshtml");
    }
}