using Microsoft.AspNetCore.Mvc;
using SchoolManagement.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SchoolManagement.Controllers
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
            //use ADO.NET to fetch all data from DB
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=Testdb;Integrated Security=True";
            SqlConnection con = new(connectionString);

            string query = "select * from student";
            SqlCommand cmd = new SqlCommand(query, con);
            List<(int Id, String Name, String Address)> students =
                new List<(int Id, String Name, String Address)>();
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                   
                       students.Add((Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString()));
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message) ;
            }
            finally
            {
                con.Close();
            }

            return View(students);
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
}