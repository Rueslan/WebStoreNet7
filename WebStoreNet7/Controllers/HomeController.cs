using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WebStoreNet7.Models;

namespace WebStoreNet7.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _employees = new()
        {
            new Employee { Id = 1, FirstName = "Алексей", LastName = "Дударь", Patronymic = "Васильевич", Age = 25},
            new Employee { Id = 2, FirstName = "Арсений", LastName = "Зайцев", Patronymic = "Сергеевич", Age = 12},
            new Employee { Id = 3, FirstName = "Екатерина", LastName = "Козлова", Patronymic = "Олеговна", Age = 36}
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction(string id)
        {
            return Content($"Second Action with parametr {id}");
        }
        public IActionResult Employees()
        {
            return View(_employees);
        }

        public string NoIndex()
        {
            return "Hello from NoIndex";
        }
    }
}
