using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Summerland.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			//routes.MapRoute(
			//	"TandC", // Route controllerName
			//	"CommonPath/{controller}/Terms-and-Conditions", // URL with parameters
			//	new { controller = "Home", action = "Terms_and_Conditions" } // Parameter defaults

			routes.MapRoute(
				"More Info",
				"more-info",
				new { controller = "MoreInfo", action = "Index" });

			routes.MapRoute(
				"More Info - Location",
				"more-info/location",
				new { controller = "MoreInfo", action = "Location" });

			routes.MapRoute(
				"More Info - Contact Us",
				"more-info/contact-us",
				new { controller = "MoreInfo", action = "Contact-Us" });

			routes.MapRoute(
				"More Info - Leave Feedback",
				"more-info/leave-feedback",
				new { controller = "MoreInfo", action = "Leave-Feedback" });

			routes.MapRoute(
				"More Info - Feedback",
				"more-info/feedback",
				new { controller = "MoreInfo", action = "Feedback" });

			//routes.MapRoute(
			//	"Contact Us",
			//	"contact-us",
			//	new { controller = "ContactUs", action = "Index" });

			routes.MapRoute(
				 name: "Default",
				 url: "{controller}/{action}/{id}",
				 defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);

			//routes.Add(
			//		  new SeoFriendlyRoute("{controller}/{action}/{id}",
			//				new RouteValueDictionary(
			//					 new { controller = "Home", action = "Index", id = "" }),
			//					 new HyphenatedRouteHandler())
			//	 );
			//);

		}
	}
}
