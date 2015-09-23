using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sandbox.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{

			var s1a = System.Web.HttpContext.Current.Request.ServerVariables["SERVER_NAME"];
			var s1b = System.Web.HttpContext.Current.Request.ServerVariables["SERVER_PORT"];

			var s2a = this.HttpContext.Request.Url.Host;
			var s2b = this.HttpContext.Request.Url.Authority;
			var s2c = this.HttpContext.Request.Url.Scheme;

			ViewBag.Message = string.Format("ServerVariables: {0} | {1} || Request: {2} | {3} | {4}", s1a, s1b, s2a, s2b, s2c);

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your app description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}
