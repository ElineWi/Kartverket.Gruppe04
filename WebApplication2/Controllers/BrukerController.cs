using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers;

public class BrukerController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}