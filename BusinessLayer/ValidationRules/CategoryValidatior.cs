using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concreate;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class CategoryValidator : AbstractValidator<Category>
	{
		public CategoryValidator()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş bırakamazsınız.");
			RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklamasını boş bırakamazsınız.");
			RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori adı 3 harften az olamaz.");
			RuleFor(x => x.CategoryName).MaximumLength(22).WithMessage("Kategori adı 22 harften fazla olamaz.");
		}

		
	}
}
