using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomerMapApp.Models;

namespace CustomerMapApp.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

}
