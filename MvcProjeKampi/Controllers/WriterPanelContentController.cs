using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class WriterPanelContentController : Controller
	{
		ContentManager cm = new ContentManager(new EfContentDal());
		// GET: WriterPanelContent
		public ActionResult MyContent(string p)
		{

			Context c = new Context();
			p = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
			var contentvalues = cm.GetListByWriter(writeridinfo);
			return View(contentvalues);

		}
		[HttpGet]
		public ActionResult AddContent(int id)
		{
			ViewBag.d = id;
			return View();
		}

		[HttpPost]
		public ActionResult AddContent(Content p)
		{
			Context c = new Context();
			string mail= (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterID).FirstOrDefault();
			p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.WriterID = writeridinfo;
			cm.ContentAdd(p);
			p.ContentStatus = true;
			return RedirectToAction("MyContent");
		}
	}
}