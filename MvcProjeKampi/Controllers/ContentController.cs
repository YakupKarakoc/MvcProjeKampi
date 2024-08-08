using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        ContentManager cm = new ContentManager(new EfContentDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentByHeading(int id)
        {
			var contentvalues = cm.GetListByHeadingID(id);
			return View(contentvalues);
            //var contentValues = cm.Nurcan(id);
        }

        Context c = new Context();
        public ActionResult GetAllContent(string p)
		{
            var contentvalue = from x in c.Contents select x;
            if(!string.IsNullOrEmpty(p) )
			{
                contentvalue = contentvalue.Where(y => y.ContentValue.Contains(p));
			}
            return View(contentvalue.ToList());
		}
    }   
}