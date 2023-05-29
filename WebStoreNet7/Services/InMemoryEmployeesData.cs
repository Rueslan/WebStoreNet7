using WebStoreNet7.Data;
using WebStoreNet7.Models;
using WebStoreNet7.Services.Interfaces;

namespace WebStoreNet7.Services
{
	public class InMemoryEmployeesData : IEmployeesData
	{
		private readonly ILogger<InMemoryEmployeesData> _Logger;

		private int _CurrentMaxId;

		public InMemoryEmployeesData(ILogger<InMemoryEmployeesData> Logger)
        {
			_Logger = Logger;
			_CurrentMaxId = TestData.Employees.Max(e => e.Id);
		}
        public int Add(Employee employee)
		{
			if (employee is null) throw new ArgumentNullException(nameof(employee));

			if (TestData.Employees.Contains(employee)) return employee.Id;

			employee.Id = ++_CurrentMaxId;
			TestData.Employees.Add(employee);
			return employee.Id;
		}

		public bool Delete(int id)
		{
			var db_employee = GetById(id);
			if (db_employee is null) return false;

			TestData.Employees.Remove(db_employee); 
			return true;
		}

		public IEnumerable<Employee> GetAll()
		{
			return TestData.Employees;
		}

		public Employee GetById(int id)
		{
			return TestData.Employees.SingleOrDefault(e => e.Id == id);
		}

		public void Update(Employee employee)
		{
			if (employee is null) throw new ArgumentNullException(nameof(employee));

			if (TestData.Employees.Contains(employee)) return;

			var db_employee = GetById(employee.Id);
			if (db_employee is null) return;

			db_employee.FirstName = employee.FirstName;
			db_employee.LastName = employee.LastName;
			db_employee.Patronymic = employee.Patronymic;
			db_employee.Age = employee.Age;
			db_employee.Info = employee.Info;
		}
	}
}
