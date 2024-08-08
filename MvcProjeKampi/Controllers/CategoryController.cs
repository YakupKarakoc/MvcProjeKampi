using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class CategoryController : Controller
	{
		// GET: Category
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult GetCategoryList()
		{
			var categoryValues = cm.GetList();
			return View(categoryValues);
		}

		[HttpGet]

		public ActionResult AddCategory()
		{
			return View();
		}
		[HttpPost]
		public ActionResult AddCategory(Category p)
		{
			CategoryValidator categoryValidator = new CategoryValidator();
			ValidationResult results = categoryValidator.Validate(p);
			if(results.IsValid)
			{
				cm.CategoryAdd(p);
				return RedirectToAction("GetCategoryList");		
			}
			else
			{
				foreach(var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
			//cm.CategoryAddBL(p); 
			return RedirectToAction("GetCategoryList");
		}
	}
}