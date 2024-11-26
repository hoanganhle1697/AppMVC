using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IWebHostEnvironment env;
    private readonly ShopDbContext context;

    public HomeController(ILogger<HomeController> logger,IWebHostEnvironment _env,ShopDbContext _context)
    {
        _logger = logger;
        env=_env;
        context=_context;
        
    }

    public IActionResult Index()
    {
        var products=context.GetProducts();

        return View(products);
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
}
