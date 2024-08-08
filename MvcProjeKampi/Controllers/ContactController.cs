using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        // GET: Contact

       
        public ActionResult Index()
        {
            var contactValues = cm.GetList();
            return View(contactValues);
        }


        public ActionResult GetContactDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var contactvalues = cm.GetByID(id.Value);
            if (contactvalues == null)
            {
                return HttpNotFound();
            }

            return View(contactvalues);
        }
        
        public PartialViewResult ContactPartial()
		{
            return PartialView();
		}
    }
}