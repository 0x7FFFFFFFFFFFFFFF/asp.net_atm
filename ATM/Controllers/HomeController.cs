using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexNoLayout()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            if (letterCase == "lower")
            {
                return Content("aspdotnetmvc5");
            }
            if (letterCase == "upper")
            {
                // return Content("ASPDOTNETMVC5");
                // If we don't provide the upper case version serial number, we can
                // return a http status code
                return new HttpStatusCodeResult(403);
            }
            return Content("ASPDOTNETMVC5");
        }

        // Use the following URL to test
        // Get /home/testjson
        public ActionResult TestJson()
        {
            return Json(new {name = "Edde", age = 35}, JsonRequestBehavior.AllowGet);
        }
    }
}