using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using FluentValidation.Results;
using BusinessLayer.ValidationRules;

namespace MvcProjeKampi.Controllers
{
	public class WriterPanelController : Controller
	{
		// GET: WriterPanel
		HeadingManager hm = new HeadingManager(new EfHeadingDal());
		WriterManager wm = new WriterManager(new EfWriterDal());
		CategoryManager cm = new CategoryManager(new EfCategoryDal());
		Context c = new Context();
		WriterValidator writervalidator = new WriterValidator();


		[HttpGet]
		public ActionResult WriterProfile(int id=0)
		{
			string p = (string)Session["WriterMail"];
			id = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
			var writervalue = wm.GetByID(id);
			return View(writervalue);
		}

		[HttpPost]
		public ActionResult WriterProfile(Writer p)
		{
			ValidationResult results = writervalidator.Validate(p);
			if (results.IsValid)
			{
				wm.WriterUpdate(p);
				return RedirectToAction("AllHeading");

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
		//[AllowAnonymous]//Bu eylem ile anonim erişim sağlanabilir.
		public ActionResult MyHeading(string p)
		{

			p = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
			var values = hm.GetListByWriter(writeridinfo);
			return View(values);
		}
		[HttpGet]
		public ActionResult NewHeading()
		{

			List<SelectListItem> valuecategory = (from x in cm.GetList()
												  select new SelectListItem
												  {
													  Text = x.CategoryName,
													  Value = x.CategoryID.ToString()
												  }).ToList();
			ViewBag.vlc = valuecategory;
			return View();
		}

		[HttpPost]
		public ActionResult NewHeading(Heading p)
		{
			string writermailinfo = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == writermailinfo).Select(y => y.WriterID).FirstOrDefault();
			p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.WriterID = writeridinfo;
			p.HeadingStatus = true;
			hm.HeadingAdd(p);
			return RedirectToAction("MyHeading", "WriterPanel");
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
			return RedirectToAction("MyHeading", "WriterPanel");
		}

		public ActionResult DeleteHeading(int id)
		{
			var HeadingValue = hm.GetByID(id);
			hm.HeadingDelete(HeadingValue);
			return RedirectToAction("MyHeading", "WriterPanel");
		}

		public ActionResult AllHeading(int p=1)
		{
			var headings = hm.GetList().ToPagedList(p,4);
			return View(headings);
		}

		public ActionResult ToDoList()
		{
			return View();
		}
	}
}