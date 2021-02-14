using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace webdotnet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;
            ViewBag.menu = new List<string>()
            {
                "Home",
                "Mas datos"
            };

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            return View();
        }

        public ActionResult more()
        {
            ViewBag.menu = new List<string>()
            {
                "Home",
                "Mas datos"
            };
            return View();
        }
    }
}
