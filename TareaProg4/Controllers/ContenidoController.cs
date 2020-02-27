using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TareaProg4.Controllers
{
    public class ContenidoController : Controller
    {
        // GET: Contenido
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Peliculas()
        {
            return View();
        }
        public ActionResult Musica()
        {
            return View();
        }
    }
}