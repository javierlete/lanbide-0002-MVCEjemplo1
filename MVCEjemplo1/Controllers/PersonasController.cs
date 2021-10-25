using MVCEjemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEjemplo1.Controllers
{
    public class PersonasController : Controller
    {
        private static readonly IDictionary<long, Persona> personas = new SortedDictionary<long, Persona>()
        {
            {1L, new Persona() { Id = 1L, Nombre = "Javier", FechaNacimiento = DateTime.Now } },
            {2L, new Persona() { Id = 2L, Nombre = "Pepe", FechaNacimiento = DateTime.Now } },
            {3L, new Persona() { Id = 3L, Nombre = "Juan", FechaNacimiento = DateTime.Now } }
        };

        // GET: Personas
        public ActionResult Index()
        {
            return View(personas.Values);
        }

        // GET: Personas/Details/5
        public ActionResult Details(long id)
        {
            return View(personas[id]);
        }

        // GET: Personas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personas/Create
        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            try
            {
                long id = personas.Count > 0 ? personas.Keys.Last() + 1 : 1L;
                persona.Id = id;
                personas.Add(id, persona);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(persona);
            }
        }

        // GET: Personas/Edit/5
        public ActionResult Edit(long id)
        {
            return View(personas[id]);
        }

        // POST: Personas/Edit/5
        [HttpPost]
        public ActionResult Edit(long id, Persona persona)
        {
            try
            {
                personas[id] = persona;

                return RedirectToAction("Index");
            }
            catch
            {
                return View(persona);
            }
        }

        // GET: Personas/Delete/5
        public ActionResult Delete(long id)
        {
            return View(personas[id]);
        }

        // POST: Personas/Delete/5
        [HttpPost]
        public ActionResult Delete(long id, Persona persona)
        {
            try
            {
                personas.Remove(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(persona);
            }
        }
    }
}
