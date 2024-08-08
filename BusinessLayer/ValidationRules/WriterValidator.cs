using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class WriterValidator : AbstractValidator<Writer>
	{
		public WriterValidator()
		{
			RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız.");
			RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız.");
			RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Yazar hakkındayı boş bırakamazsınız.");
			RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Yazar adı 3 harften az olamaz.");
			RuleFor(x => x.WriterImage).MinimumLength(3).WithMessage("Yazar adı 3 harften az olamaz.");
			RuleFor(x => x.WriterMail).MinimumLength(3).WithMessage("Yazar adı 3 harften az olamaz.");
			RuleFor(x => x.WriterTitle).MinimumLength(3).WithMessage("Yazar adı 3 harften az olamaz.");
			RuleFor(x => x.WriterName).MaximumLength(22).WithMessage("Kategori adı 22 harften fazla olamaz.");
		}
	}
}
