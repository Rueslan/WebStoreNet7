using Microsoft.AspNetCore.Mvc;
using WebStoreNet7.Models;
using WebStoreNet7.Services.Interfaces;
using WebStoreNet7.ViewModels;

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
			var employee = _EmployeesData.GetById(id);
            if (employee is null) return NotFound(); 
            return View(employee);
        }

		public IActionResult Create() 
		{ 
			return View("Edit", new EmployeeViewModel());
		}
		
        #region Edit
        public IActionResult Edit(int? id)
		{
			if (id is null) return View(new EmployeeViewModel());
			var employee = _EmployeesData.GetById((int)id);
			if (employee is null) return NotFound();

			var model = new EmployeeViewModel
			{
				Id = employee.Id,
				Name = employee.FirstName,
				LastName = employee.LastName,
				Patronymic = employee.Patronymic,
				Age = employee.Age,
				Info = employee.Info,
			};

			return View(model);
		}
		[HttpPost]
		public IActionResult Edit(EmployeeViewModel model)
		{
			if (model.Name == "Асама" && model.LastName == "Бин" && model.Patronymic == "Ладан")
			{
				ModelState.AddModelError("","Террористов не берём");
			}

			if (!ModelState.IsValid)
                return View(model);                

            var employee = new Employee
            {
                Id = model.Id,
                FirstName = model.Name,
                LastName = model.LastName,
                Patronymic = model.Patronymic,
                Age = model.Age,
                Info = model.Info,
            };

            if (employee.Id == 0)
                _EmployeesData.Add(employee);
            else
                _EmployeesData.Update(employee);

            return RedirectToAction(nameof(Index));

        }
        #endregion

        #region Delete
        public IActionResult Delete(int id) 
		{
			if (id < 0) return BadRequest();
            var employee = _EmployeesData.GetById(id);
            if (employee is null) return NotFound();

			return View(new EmployeeViewModel
			{
                Id = employee.Id,
                Name = employee.FirstName,
                LastName = employee.LastName,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
                Info = employee.Info,
            });
        }

		[HttpPost]
        public IActionResult DeleteConfirmed(int id)
		{
			_EmployeesData.Delete(id);
			return RedirectToAction(nameof(Index));
		}

        #endregion
    }
}
