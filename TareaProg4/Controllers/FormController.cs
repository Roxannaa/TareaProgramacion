using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TareaProg4.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Formulario()
        {
            return View();
        }

        public ActionResult Datos()
        {
            return View();
        }

    }
}