using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summerland.Web.Controllers
{
	public class AboutController : BaseController
	{
		//
		// GET: /About/

		public ActionResult Index()
		{
			return View();
		}

		/// <summary>
		/// GET: /About/terms-and-conditions
		/// </summary>
		[ActionName("terms-and-conditions")]
		public ActionResult Terms()
		{
			return View();
		}
	}
}
