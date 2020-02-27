using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TareaProg4.Controllers
{
    public class PelisCategoriasController : Controller
    {
        // GET: PelisCategorias
        public ActionResult Accion()
        {
            return View();
        }
        public ActionResult Aventura()
        {
            return View();
        }
        public ActionResult Drama()
        {
            return View();
        }
        public ActionResult Infantil()
        {
            return View();
        }
        public ActionResult Documental()
        {
            return View();
        }
    }
}