using Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ajax.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public JsonResult NovoComentario(Comentario comentario)
        {
            //Insere o comentário no banco

            return Json(comentario, JsonRequestBehavior.AllowGet);
        }

        [OutputCache(Duration=30)]
        public ActionResult Index()
        {
            ViewBag.Message = DateTime.Now.ToString();

            return View();
        }

        public ActionResult Iframe()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

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
