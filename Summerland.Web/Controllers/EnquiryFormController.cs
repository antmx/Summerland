using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Summerland.BL;
using System.Net.Mail;
using System.Collections.Specialized;
using System.Configuration;

namespace Summerland.Web.Controllers
{
	public class EnquiryFormController : BaseController
	{
		//
		// GET: /EnquiryForm/
		public ActionResult Index()
		{
			return View(new Enquiry());
		}

		[HttpPost]
		public ActionResult Index(Enquiry model)
		{
			//return Content(str, "text/html");

			// Validate contact info is provided
			if (string.IsNullOrWhiteSpace(model.TelNum) && !StringUtil.IsEmailAddress(model.Email))
			{
				ModelState.AddModelError("ValidationError", new ApplicationException("Please provide Phone number and/or Email"));

				var errorModel = "Please provide Phone number and/or Email";
				var msgHtml = RenderPartialViewToString("_EnquiryFormError", errorModel);

				return Json(new { error = true, message = msgHtml });
			}

			// Set enquiry date
			model.Date = DateTime.Now;

			// Build MailSettings
			var mailSettings = new MailSettings(
				SmtpDeliveryMethod.Network,
				ConfigurationManager.AppSettings["Website-FromAddress"],
				ConfigurationManager.AppSettings["Website-FromName"],
				null,
				0,
				false,
				null);

			// Build template replacements
			var replacements = new ListDictionary();
			replacements.Add("@@Date", model.Date.ToString());
			replacements.Add("@@FirstName", model.FirstName);
			replacements.Add("@@Surname", model.Surname);
			replacements.Add("@@TelNum", model.TelNum);
			replacements.Add("@@Email", model.Email);
			replacements.Add("@@Message", model.Message);

			// Send template email
			Mailer.SendTemplateMail(
				mailSettings,
				ConfigurationManager.AppSettings["Website-ToAddress"],
				ConfigurationManager.AppSettings["Website-ToName"],
				ConfigurationManager.AppSettings["Website-CCAddresses"],
				ConfigurationManager.AppSettings["Website-BCCAddresses"],
				ConfigurationManager.AppSettings["Enquiry-Subject"],
				Server.MapPath("~/Content/EmailTemplates/Enquiry.html"),
				replacements,
				"/Content/EmailTemplates/",
				"/",
				Server.MapPath("~/Content/EmailTemplates/Wrapper.html"),
				true);

			//Mailer.SendMail(
			//	mailSettings,
			//	"anthony@netricity.co.uk",
			//	"Anthony",
			//	null,
			//	null,
			//	"Website Enquiry",
			//	"Details of enquiry",
			//	false);

			return PartialView("_EnquiryFormThanks", model);
		}
	}
}
