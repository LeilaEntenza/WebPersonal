using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebPersonal.Models;

namespace WebPersonal.Controllers;

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

    public IActionResult IronMaiden()
    {
        return View();
    }

    public IActionResult Nirvana()
    {
        return View();
    }
    public IActionResult PierceTheVeil()
    {
        return View();
    }

    public IActionResult Bathory()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
