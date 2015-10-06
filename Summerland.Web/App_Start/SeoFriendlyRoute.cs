using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Summerland.Web
{
	public class SeoFriendlyRoute : Route
	{
		public SeoFriendlyRoute(string url, RouteValueDictionary defaults, HyphenatedRouteHandler routeHandler)
			: base(url, defaults, routeHandler)
		{

		}

		public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
		{
			var path = base.GetVirtualPath(requestContext, values);

			if (path != null)
			{
				var indexes = new List<int>();
				var charArray = path.VirtualPath.Split('?')[0].ToCharArray();
				for (int index = 0; index < charArray.Length; index++)
				{
					var c = charArray[index];
					if (index > 0 && char.IsUpper(c) && charArray[index - 1] != '/')
						indexes.Add(index);
				}

				indexes.Reverse();
				indexes.Remove(0);
				foreach (var index in indexes)
					path.VirtualPath = path.VirtualPath.Insert(index, "-");

				path.VirtualPath = path.VirtualPath.ToLowerInvariant();
			}

			return path;
		}
	}
}
