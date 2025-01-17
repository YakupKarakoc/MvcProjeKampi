﻿using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
	public class WritePanelMessageController : Controller
	{
		// GET: WritePanelMessage
		MessageManager mm = new MessageManager(new EfMessageDal());
		MessageValidator messagevalidator = new MessageValidator();
		Context c = new Context();
		public ActionResult Inbox()
		{
			string p = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
			var messagelist = mm.GetListInbox(p);
			return View(messagelist);
		}
		public ActionResult SendBox()
		{
			string p = (string)Session["WriterMail"];
			var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterID).FirstOrDefault();
			var messagelist = mm.GetListSendbox(p);
			return View(messagelist);
		}

		public PartialViewResult MessageListMenu()
		{
			return PartialView();
		}

		public ActionResult GetInBoxMessageDetails(int id)
		{
			var values = mm.GetByID(id);
			return View(values);
		}

		public ActionResult GetSendBoxMessageDetails(int id)
		{
			var values = mm.GetByID(id);
			return View(values);
		}

		[HttpGet]
		public ActionResult NewMessage()
		{
			return View();
		}

		[HttpPost]
		public ActionResult NewMessage(Message p)
		{
			string sender = (string)Session["WriterMail"];
			ValidationResult results = messagevalidator.Validate(p);
			if (results.IsValid)
			{

				p.SenderMail = sender;
				p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				mm.MessageAdd(p);
				return RedirectToAction("SendBox");
			}
			else
			{
				foreach (var item in results.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
				return View();
			}


		}


	}
}