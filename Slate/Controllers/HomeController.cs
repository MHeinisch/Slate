using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Slate.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A start-up based in Milwaukee, WI creating revolutionary software for small and local restaurants and bars,";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact JIM B, the creators of Slate.";

            return View();
        }

    }
}