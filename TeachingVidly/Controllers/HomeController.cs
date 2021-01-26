using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeachingVidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? page, int? sort)
        {
            int? sum = page + sort;
            ViewBag.hren = sum;
            return View();
        }

        

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return new ViewResult();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}