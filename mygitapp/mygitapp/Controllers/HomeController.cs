using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mygitapp.Models;

namespace mygitapp.Controllers;
//Class home controller
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    /// <summary>
    /// This is home page
    /// </summary>
    /// <returns></returns>
    public IActionResult Index()
    {
        return View();
    }
    /// <summary>
    /// Privacy one two three
    /// </summary>
    /// <returns></returns>
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
