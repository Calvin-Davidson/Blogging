using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blogging.Models;

namespace Blogging.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHttpContextAccessor _httpContext;

    public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContext)
    {
        _httpContext = httpContext;
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}