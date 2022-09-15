using Microsoft.AspNetCore.Mvc;
using SchoolManagementSys.Data;
using SchoolManagementSys.Models;

namespace SchoolManagementSys.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult List()
        {
            SchoolContext db = new SchoolContext();
            var student = db.Students.ToList(); //select * from Student

            return View(student);
        }
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(Student student)
        {
            return View();
        }
    }
}
