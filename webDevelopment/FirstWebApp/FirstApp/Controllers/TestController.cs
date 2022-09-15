using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class TestController : Controller
{
  public IActionResult Hello()
    {
        return View();

    }
    
}
