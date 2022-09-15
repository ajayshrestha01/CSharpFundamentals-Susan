using Microsoft.AspNetCore.Mvc;
using SchoolManagementSys.Data;
using SchoolManagementSys.Models;
using System.Diagnostics;

namespace SchoolManagementSys.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            SchoolContext db = new SchoolContext();
            var students = db.Students.ToList();
           

        

            return View(students);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}