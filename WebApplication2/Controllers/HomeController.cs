using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

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
    
    // action metode som håndterer POST forespørsel og viser Registreringsform.cshtml view
    [HttpGet]

    public ViewResult RegistrationForm()
    {
        return View();
    }
    
    // action metode som håndterer POST forespørsel og viser RegistrationForm.cshtml view
    [HttpPost]
    public ViewResult RegistrationForm(UserData userData)
    {
        return View("Overview", userData);
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