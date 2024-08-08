using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class WriterController : Controller
	{
		WriterManager wm = new WriterManager(new EfWriterDal());
		WriterValidator writervalidator = new WriterValidator();
		// GET: Writer
		public ActionResult Index()
		{
			var writerValues = wm.GetList();

			return View(writerValues);
		}

		[HttpGet]
		public ActionResult AddWriter()
		{
			return View();
		}

		[HttpPost]
		public ActionResult AddWriter(Writer p)
		{

			ValidationResult results = writervalidator.Validate(p);
			if (results.IsValid)
			{
				wm.WriterAdd(p);

			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}
			return RedirectToAction("Index", "Writer");

		}

		[HttpGet]
		public ActionResult EditWriter(int id)
		{
			var valueWriter = wm.GetByID(id);
			return View(valueWriter);
		}



		[HttpPost]
		public ActionResult EditWriter(Writer p)
		{

			Console.WriteLine(p.WriterTitle);
			WriterValidator writervalidator = new WriterValidator();
			ValidationResult results = writervalidator.Validate(p);
			if (results.IsValid)
			{
				wm.WriterUpdate(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}

			}
			return View();



		}
	}
}