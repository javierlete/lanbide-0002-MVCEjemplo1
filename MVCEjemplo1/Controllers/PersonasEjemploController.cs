using MVCEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemplo1.Controllers
{
    public class PersonasEjemploController : Controller
    {
        private static readonly IDictionary<long, Persona> personas = new Dictionary<long, Persona>()
        {
            {1L, new Persona() { Id = 1L, Nombre = "Javier", FechaNacimiento = DateTime.Now } },
            {2L, new Persona() { Id = 2L, Nombre = "Pepe", FechaNacimiento = DateTime.Now } },
            {3L, new Persona() { Id = 3L, Nombre = "Juan", FechaNacimiento = DateTime.Now } }
        };
        // GET: Personas
        public ActionResult Index()
        {
            return View(new Persona() { Id = 1L, Nombre = "Javier", FechaNacimiento = DateTime.Now });
        }

        public ActionResult Listado()
        {
            return View(personas.Values);
        }
    }
}