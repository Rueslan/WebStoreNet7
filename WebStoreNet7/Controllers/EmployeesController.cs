﻿using Microsoft.AspNetCore.Mvc;
using WebStoreNet7.Models;

namespace WebStoreNet7.Controllers
{
    public class EmployeesController : Controller
    {
        private static readonly List<Employee> _employees = new()
        {
            new Employee { Id = 1, FirstName = "Алексей", LastName = "Дударь", Patronymic = "Васильевич", Age = 25, Info = "Бездельник"},
            new Employee { Id = 2, FirstName = "Арсений", LastName = "Зайцев", Patronymic = "Сергеевич", Age = 12, Info = "Микро-стажёр"},
            new Employee { Id = 3, FirstName = "Екатерина", LastName = "Козлова", Patronymic = "Олеговна", Age = 36, Info = "Волонтёр"}
        };

        public IActionResult Index() => View(_employees);
    }
}
