using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summerland.Web.Controllers
{
	public class MoreInfoController : BaseController
	{
		/// <summary>
		/// GET: /more-info/
		/// </summary>
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// GET: /more-info/location
		/// </summary>
		public ActionResult Location()
		{
			return View();
		}

		/// <summary>
		/// GET: /more-info/contact-us
		/// </summary>
		[ActionName("contact-us")]
		public ActionResult ContactUs()
		{
			return View();
		}

		/// <summary>
		/// GET: /more-info/feedback
		/// </summary>
		[ActionName("feedback")]
		public ActionResult Feedback()
		{
			return View();
		}

		/// <summary>
		/// GET: /more-info/leave-feedback
		/// </summary>
		[ActionName("leave-feedback")]
		public ActionResult LeaveFeedback()
		{
			return View();
		}
	}
}
