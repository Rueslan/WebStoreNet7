using Microsoft.AspNetCore.Mvc;
using WebStoreNet7.Data;
using WebStoreNet7.Models;
using WebStoreNet7.Services.Interfaces;

namespace WebStoreNet7.Controllers
{
	//[Route("Employees/[action]/{id?}")]
	//[Route("Staff/[action]/{id?}")]
    public class EmployeesController : Controller
    {
		private readonly IEmployeesData _EmployeesData;
		private readonly ILogger<EmployeesController> _Logger;

		public EmployeesController(IEmployeesData EmployeesData,ILogger<EmployeesController> Logger)
        {
			_EmployeesData = EmployeesData;
			_Logger = Logger;
		}
		//[Route("~/employees/all")]
		public IActionResult Index() => View(_EmployeesData.GetAll());

		//[Route("~/employees/info-{id}")]
		public IActionResult Details(int id)
        {
			var employee = _EmployeesData.GetById();
            if (employee is null) return NotFound(); 
            return View(employee);
        }
    }
}
