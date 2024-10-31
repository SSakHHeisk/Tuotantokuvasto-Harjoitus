using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TuotekuvastoApp.Models;
using Newtonsoft.Json;

namespace TuotekuvastoApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    // Tuotejuttuja
    public IActionResult Product()
    {
        var products = GetProducts();
        return View(products);
    }

    private List<Product> GetProducts()
    {
        var json = System.IO.File.ReadAllText("wwwroot/products.json");
        return JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
