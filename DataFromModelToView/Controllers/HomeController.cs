using DataFromModelToView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataFromModelToView.Controllers
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
            //EmployeeModel employee = new EmployeeModel()
            //{
            //    Id=1,Name="Hamza"
            //};
            //ViewData["empdata"]=employee;
            List<EmployeeModel> employees = new List<EmployeeModel>()
            {
                new EmployeeModel { Id = 1,Name="Hamza"}, new EmployeeModel { Id = 2,Name="Ali"},
                new EmployeeModel { Id = 3,Name="Ahmed"}, new EmployeeModel { Id = 4,Name="Raza"}

            };
            ViewData["empdata"]=employees;
            return View();
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