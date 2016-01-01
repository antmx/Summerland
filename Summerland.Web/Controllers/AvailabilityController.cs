using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summerland.Web.Controllers
{
	public class AvailabilityController : BaseController
	{
		/// <summary>
		/// GET: /Availability/
		/// </summary>
		public ActionResult Index()
		{
			// Return view for current year
			var year = DateTime.Now.Year.ToString();
			return View(year);
		}

		/// <summary>
		/// GET: /Availability/2013
		/// </summary>
		[ActionName("2013")]
		public ActionResult Y2013()
		{
			return View();
		}

		/// <summary>
		/// GET: /Availability/2014
		/// </summary>
		[ActionName("2014")]
		public ActionResult Y2014()
		{
			return View();
		}

		/// <summary>
		/// GET: /Availability/2015
		/// </summary>
		[ActionName("2015")]
		public ActionResult Y2015()
		{
			return View();
		}

		/// <summary>
		/// GET: /Availability/2016
		/// </summary>
		[ActionName("2016")]
		public ActionResult Y2016()
		{
			return View();
		}

		/// <summary>
		/// GET: /Availability/2017
		/// </summary>
		[ActionName("2017")]
		public ActionResult Y2017()
		{
			return View();
		}

      /// <summary>
      /// GET: /Availability/2018
      /// </summary>
      [ActionName("2018")]
      public ActionResult Y2018()
      {
         return View();
      }
   }
}
