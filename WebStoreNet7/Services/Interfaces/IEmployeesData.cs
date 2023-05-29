using System.Collections;
using WebStoreNet7.Models;

namespace WebStoreNet7.Services.Interfaces
{
	public interface IEmployeesData
	{
		IEnumerable<Employee> GetAll();

		Employee GetById(int id);

		int Add(Employee employee);

		void Update(Employee employee);

		bool Delete(int id);
	}
}
