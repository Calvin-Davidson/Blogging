using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Blogging.Models;

namespace Blogging.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FileController _fileController;
    
    public HomeController(ILogger<HomeController> logger, FileController fileController)
    {
        _logger = logger;
        _fileController = fileController;
    }

    public IActionResult Index()
    {
        var okResult = (OkObjectResult)_fileController.GetFiles().Result.Result!;
        List<MarkdownFile> files = (List<MarkdownFile>) okResult.Value!;
        return View(files);
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