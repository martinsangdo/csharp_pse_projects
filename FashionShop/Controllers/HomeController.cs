using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FashionShop.Models;

namespace FashionShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    //about us
    public IActionResult About()
    {
        return View("~/Views/malefashion/about.cshtml");
    }
    //contact
    public IActionResult Contact()
    {
        return View("~/Views/malefashion/contact.cshtml");
    }
    //login
    public IActionResult Signin()
    {
        return View("~/Views/dashmin/signin.cshtml");
    }
    //register
    public IActionResult Signup()
    {
        return View("~/Views/dashmin/signup.cshtml");
    }
}
