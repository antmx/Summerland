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
	public class FeedbackFormController : BaseController
	{
		//
		// GET: /FeedbackForm/
		public ActionResult Index()
		{
			return View(new Feedback());
		}

		[HttpPost]
		public ActionResult Index(Feedback model)
		{
			// Validate contact info is provided
			if (string.IsNullOrWhiteSpace(model.TelNum) && !StringUtil.IsEmailAddress(model.Email))
			{
				ModelState.AddModelError("ValidationError", new ApplicationException("Please provide Phone number and/or Email"));

				var errorModel = "Please provide Phone number and/or Email";
				var msgHtml = RenderPartialViewToString("_FeedbackFormError", errorModel);

				return Json(new { error = true, message = msgHtml });
			}

			// Set Feedback date
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
			replacements.Add("@@Rating", model.Rating.GetValueOrDefault().ToString());
			replacements.Add("@@Message", model.Message);

			// Send template email
			Mailer.SendTemplateMail(
				mailSettings,
				ConfigurationManager.AppSettings["Website-ToAddress"],
				ConfigurationManager.AppSettings["Website-ToName"],
				ConfigurationManager.AppSettings["Website-CCAddresses"],
				ConfigurationManager.AppSettings["Website-BCCAddresses"],
				ConfigurationManager.AppSettings["Feedback-Subject"],
				Server.MapPath("~/Content/EmailTemplates/Feedback.html"),
				replacements,
				"/Content/EmailTemplates/",
				"/",
				Server.MapPath("~/Content/EmailTemplates/Wrapper.html"),
				true);

			return PartialView("_FeedbackFormThanks", model);
		}
	}
}
