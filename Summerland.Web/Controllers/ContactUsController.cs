using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summerland.Web.Controllers
{
	public class ContactUsController : BaseController
	{
		/// <summary>
		/// GET: /contact-us/
		/// </summary>
		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// GET: /contact-us/contact-us
		/// </summary>
		[ActionName("contact-us")]
		public ActionResult ContactUs()
		{
			return View();
		}
	}
}
