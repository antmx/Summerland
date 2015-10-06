using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Summerland.Web
{
	public class LowercaseRouteConstraint : IRouteConstraint
	{
		#region IRouteConstraint Members

		public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
		{
			//throw new NotImplementedException();
			var path = httpContext.Request.Url.AbsolutePath;
			return path.Equals(path.ToLowerInvariant(), StringComparison.InvariantCulture);
		}

		#endregion
	}
}
