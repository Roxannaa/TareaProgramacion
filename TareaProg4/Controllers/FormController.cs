using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TareaProg4.Models;

namespace TareaProg4.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Formulario()
        {
            return View();
        }
    

    [HttpPost]
    public ActionResult Datos(Campos formu, HttpPostedFileBase imagen, HttpPostedFileBase cv)
    {
        if (ModelState.IsValid)
        {
            string nombreFoto = imagen.FileName;
            imagen.SaveAs(Server.MapPath("/img/" + nombreFoto));

            string curriculum = cv.FileName;
            cv.SaveAs(Server.MapPath("/img/" + curriculum));

            ViewBag.foto = nombreFoto;
            ViewBag.cv = curriculum;
            return View(formu);
        }
        else
        {
            return View("Formulario");
        }
    }

  }

}