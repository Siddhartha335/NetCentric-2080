using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BookStore.Models;

namespace BookStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(string name,int age)
    {
        // return Content("This is me Sid!");
        // var responseObject = new 
        //     {
        //         Message = "This is me Sid!",
        //         Success = true
        //     };
        // return Json(responseObject);
        var queryResponse = new {
            Name = name,
            Age = age
        };
        return View(queryResponse);
    }

    public IActionResult Privacy()
    {
        var responseObject = new 
            {
                Message = "This is me Sid!",
                Success = true
            };
        return Json(responseObject);
    }
    public IActionResult Test()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
