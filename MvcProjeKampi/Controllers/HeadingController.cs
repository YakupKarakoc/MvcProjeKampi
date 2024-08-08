 using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class HeadingController : Controller
	{
		HeadingManager hm = new HeadingManager(new EfHeadingDal());
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		WriterManager wm = new WriterManager(new EfWriterDal());
		// GET: Heading


		public ActionResult Index()
		{

			var headingValues = hm.GetList();
			return View(headingValues);
		}

		public ActionResult HeadingReport()
		{
			var headingValues = hm.GetList();
			return View(headingValues);
		}
		[HttpGet]
		public ActionResult AddHeading()
		{
			List<SelectListItem> valuecategory = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.vlc = valuecategory;

			List<SelectListItem> valuewriter = (from x in wm.GetList()
												select new SelectListItem
												{
													Text = x.WriterName,
													Value = x.WriterID.ToString()
												}).ToList();
			ViewBag.vlw = valuewriter;
			return View();
		}
		[HttpPost]
		public ActionResult AddHeading(Heading p)
		{
			p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			hm.HeadingAdd(p);
			return RedirectToAction("Index");
		}
		[HttpGet] 
		public ActionResult EditHeading(int id)
		{
			List<SelectListItem> valuecategory = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.vlc = valuecategory;
			var headingvalue = hm.GetByID(id);

			return View(headingvalue);
		}
		[HttpPost]
		public ActionResult EditHeading(Heading p)
		{
			hm.HeadingUpdate(p);
			return RedirectToAction("Index"); 
		}

		public ActionResult DeleteHeading(int id)
		{ 
			var HeadingValue = hm.GetByID(id);
			hm.HeadingDelete(HeadingValue);
			return RedirectToAction("Index");
		}

		
	}
}