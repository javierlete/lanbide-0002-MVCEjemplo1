using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemplo1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(long numero, string mensaje)
        {
            ViewBag.NumeroVeces = numero;
            ViewBag.Mensaje = mensaje;
            return View();
        }
    }
}