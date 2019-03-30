using html_helper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html_helper.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Persona objecto = new Persona();
            objecto.Cedula = Convert.ToInt32(Request.Form["Cedula"]);
            objecto.Nombre = (Request.Form["Nombre"]).ToString();
            objecto.Apellido = (Request.Form["Apellido"]).ToString();
            objecto.Edad = Convert.ToInt32(Request.Form["Edad"]);
            objecto.Telefono = Convert.ToInt32(Request.Form["Telefono"]);
            objecto.Correo = (Request.Form["Correo"]).ToString();
            objecto.Genero = (Request.Form["Genero"]).ToString();
            objecto.EstadoCivil = (Request.Form["EstadoCivil"]).ToString();
            objecto.Hobbys = (Request.Form["Hobbys"]).ToString();
            return View(objecto);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}