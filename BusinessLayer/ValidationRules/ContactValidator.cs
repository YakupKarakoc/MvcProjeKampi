using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ContactValidator : AbstractValidator<Contact>
	{
		public ContactValidator()
		{
			RuleFor(x => x.UserMail).NotEmpty().WithMessage("Bu alanı boş bırakamazsınız."); 
			RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu adını boş bırakamazsınız.");
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş bırakamazsınız.");
			RuleFor(x => x.UserMail).MinimumLength(3).WithMessage("mailiniz 3 harften az olamaz.");
			RuleFor(x => x.UserMail).MaximumLength(30).WithMessage("mailiniz 30 harften fazla olamaz.");
		}
	}
}
