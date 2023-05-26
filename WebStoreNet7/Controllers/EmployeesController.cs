using Microsoft.AspNetCore.Mvc;
using WebStoreNet7.Data;
using WebStoreNet7.Models;

namespace WebStoreNet7.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEnumerable<Employee> _Employees;
        public EmployeesController()
        {
            _Employees = TestData.Employees;
        }
        public IActionResult Index() => View(_Employees);
    }
}
