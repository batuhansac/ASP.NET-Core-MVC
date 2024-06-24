using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index", DateTime.Now);
        }

        public ViewResult Index2()
        {
            var model = new string[] { "Alice", "Bob", "Joe"};
            return View(model);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Alice", LastName = "Sunderland" },
                new Employee { Id = 2, FirstName = "Bob", LastName = "Jones" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Doe" }
            };
            return View("Index3", list);
        }
    }
}