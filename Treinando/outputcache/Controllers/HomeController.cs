using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace outputcache.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration=30)]
        public ActionResult Index()
        {

            //Session["teste"] = DateTime.Now.ToString();

            //var teste = Session["teste"]; 

            ViewBag.Message = DateTime.Now.ToString();

            return View();
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
    }
}