﻿using DataAccessLayer.Concrete;
using EntityLayer.Concreate;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjeKampi.Controllers
{
	//[AllowAnonymous]
	public class LoginController : Controller
	{	
		
		// GET: Login 
		[HttpGet]
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Index(Admin p)
		{
			Context c = new Context();
			var adminuserinfo = c.Admins.FirstOrDefault(x => x.AdminName == p.AdminName && x.AdminPassword == p.AdminPassword);
			if (adminuserinfo != null)
			{
				FormsAuthentication.SetAuthCookie(adminuserinfo.AdminName, false);
				Session["AdminName"] = adminuserinfo.AdminName;
				return RedirectToAction("Index", "AdminCategory");
			}
			else
			{
				return RedirectToAction("Index");
			}
			return View(p);
		}

		[HttpGet]
		public ActionResult WriterLogin()
		{
			return View();
		}

		[HttpPost]
		public ActionResult WriterLogin(Writer p)
		{
			Context c = new Context();
			var writeruserinfo = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
			if (writeruserinfo != null)
			{
				FormsAuthentication.SetAuthCookie(writeruserinfo.WriterMail, false);
				Session["WriterMail"] = writeruserinfo.WriterMail;
				return RedirectToAction("MyContent", "WriterPanelContent");
			}
			else
			{
				return RedirectToAction("WriterLogin");
			}


		}

		//public ActionResult LogOut()
		//{
		//	FormsAuthentication.SignOut();
		//	Session.Abandon();
		//	return RedirectToAction("Headings", "Default");
		//}
	}
}