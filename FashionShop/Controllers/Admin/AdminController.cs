using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class AdminController : Controller
{
    private readonly ILogger<ProductsController> _logger;
    private readonly ProductService _productService;

    public AdminController(ILogger<ProductsController> logger, ProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [Route("/admin/dashboard")]
    public IActionResult adminDashboard()
    {
        return View("~/Views/dashmin/admin/dashboard.cshtml");
    }

    //========== Products
    [Route("/admin/products")]
    public IActionResult adminProducts()
    {
        return View("~/Views/dashmin/admin/products.cshtml");
    }
    [Route("/admin/product/{id:int?}")]
    public IActionResult adminProductDetail(int id)
    {
        return View("~/Views/dashmin/admin/product_detail.cshtml");
    }

    //========== Orders
    [Route("/admin/orders")]
    public IActionResult adminOrders()
    {
        return View("~/Views/dashmin/admin/orders.cshtml");
    }
    [Route("/admin/order/{id:int?}")]
    public IActionResult adminOrderDetail(int id)
    {
        return View("~/Views/dashmin/admin/product_detail.cshtml");
    }

    //========== Users
    [Route("/admin/users")]
    public IActionResult adminUsers()
    {
        return View("~/Views/dashmin/admin/users.cshtml");
    }
    [Route("/admin/user/{id:int?}")]
    public IActionResult adminUserDetail(int id)
    {
        return View("~/Views/dashmin/admin/product_detail.cshtml");
    }

    //========== Categories
    [Route("/admin/categories")]
    public IActionResult adminCategories()
    {
        return View("~/Views/dashmin/admin/categories.cshtml");
    }
    [Route("/admin/category/{id:int?}")]
    public IActionResult adminCategoryDetail(int id)
    {
        return View("~/Views/dashmin/admin/product_detail.cshtml");
    }
}