using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DagplejeMiriam.Models;

namespace DagplejeMiriam.Controllers;

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

    public IActionResult Kost()
    {
        return View();
    }

    public IActionResult Hverdag()
    {
        return View();
    }

    public IActionResult Mig()
    {
        return View();
    }

    public IActionResult Omgivelser()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
