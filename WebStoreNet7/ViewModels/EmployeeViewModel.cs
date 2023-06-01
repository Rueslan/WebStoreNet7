﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebStoreNet7.ViewModels
{
	public class EmployeeViewModel
	{
		[HiddenInput(DisplayValue =false)]	
		public int Id { get; set; }

		[Display(Name = "Имя")]
		public string? Name { get; set; }

        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }

        [Display(Name = "Отчество")]
        public string? Patronymic { get; set; }

        [Display(Name = "Возраст")]
        public int Age { get; set; }

        [Display(Name = "Дополнительно")]
        public string? Info { get; set; }
	}
}
