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
	public class AdminCategoryController : Controller
	{

		// GET: AdminCategory
		CategoryManager cm = new CategoryManager(new EfCategoryDal());


		//[Authorize(Roles = "B")]
		public ActionResult Index()
		{
			var categoryvalues = cm.GetList();
			return View(categoryvalues);
		}

		[HttpGet]
		public ActionResult AddCategory()
		{
			return View();
		}

		public ActionResult AddCategory(Category p)
		{
			CategoryValidator categoryValidator = new CategoryValidator();
			ValidationResult results = categoryValidator.Validate(p);
			if (results.IsValid)
            {
				cm.CategoryAdd(p);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}

		public ActionResult DeleteCategory(int id)
		{
			var categoryValue = cm.GetByID(id);
			cm.CategoryDelete(categoryValue);
			
			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult UpdateCategory(int id)
		{
			var categoryValue = cm.GetByID(id);

			return View(categoryValue);
			
		}

		[HttpPost]
		public ActionResult UpdateCategory(Category p)
		{
			cm.CategoryUpdate(p);
			return RedirectToAction("Index");

		}
	}
}