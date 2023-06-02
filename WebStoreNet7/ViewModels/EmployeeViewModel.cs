using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using System.ComponentModel.DataAnnotations;

namespace WebStoreNet7.ViewModels
{
	public class EmployeeViewModel : IValidatableObject
	{
		[HiddenInput(DisplayValue =false)]	
		public int Id { get; set; }

		[Display(Name = "Имя")]
        [Required(ErrorMessage ="Имя не указано")]
        [StringLength(200,MinimumLength =2,ErrorMessage = "Допустимое количество символов от 2 до 200")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат")]
		public string? Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия не указана")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Допустимое количество символов от 2 до 200")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Неверный формат")]
        public string? LastName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Допустимое количество символов от 2 до 200")]
        public string? Patronymic { get; set; }

        [Display(Name = "Возраст")]
        [Required(ErrorMessage = "Возраст не указан")]
        [Range(18, 80, ErrorMessage = "от 18 до 80")]
        public int Age { get; set; }

        [Display(Name = "Дополнительно")]
        public string? Info { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            switch (validationContext.MemberName)
            {
                default:
                    // return Enumerable.Empty<ValidationResult>();
                    return new[] { ValidationResult.Success };

                    case nameof(Age):
                    if (Age < 18 || Age > 80)
                    {
                        return new[] { new ValidationResult("Странный возраст", new[] { nameof(Age) })};
                    }
                    return new[] { ValidationResult.Success };
            }
        }
    }
}
