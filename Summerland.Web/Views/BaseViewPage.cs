using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summerland.Web.Views
{
	/// <summary>
	/// Base class for all page Views.
	/// </summary>
	public abstract class BaseViewPage : WebViewPage
	{

	}

	/// <summary>
	/// Base class for all page Views that have a strongly-typed @Model directive.
	/// </summary>
	public abstract class BaseViewPage<TModel> : WebViewPage<TModel>
	{

	}
}
