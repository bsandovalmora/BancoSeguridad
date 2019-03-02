using Banco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banco.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Verificacion()
        {
            string usuario = Request.Form["usuario"].ToString();
            string pass = Request.Form["pass"].ToString();
            Metodos m = new Metodos();
            string mjs = m.Cuenta(usuario,pass);

            if(mjs.Equals("Usuario encontrado")){     
                return View();
            }
            else
            {
                ViewBag.showSuccessAlert = true;
                return View("~/Views/Home/Index.cshtml");
            }
            
        }

        public ActionResult Recuperar()
        {
                return View();
                                
        }

        public ActionResult Codigo_Recuperacion()
        {
            string usuario = "";
            string pregunta;
            

            Metodos m = new Metodos();
            if (TempData["usuario"] != null) { 
                usuario = TempData["usuario"] as string;
            }
            else { 
                usuario = Request.Form["usu"].ToString();
                TempData["usuario"] = usuario;
            }

            TempData.Keep();
            pregunta = m.Pregunta(usuario);

            if (pregunta.Equals("")) {
                return View("~/Views/Home/Recuperar.cshtml");
            }
            else
            {
                if (TempData["pregunta"] != null)
                    pregunta = TempData["pregunta"] as string;
                else
                    TempData["pregunta"] = pregunta;

                ViewData["pregunta"] = pregunta;
             
                return View();
            }
            

        }

        public ActionResult Verificacion_codigo()
        {
            Metodos m = new Metodos();

            string usuario = "";
            string resp = Request.Form["respuesta"].ToString();
            string mjs = "";

            if (TempData["usuario"] != null)
                usuario = TempData["usuario"] as string;

            mjs = m.Respuesta(usuario, resp);
            TempData.Keep();

            if (mjs.Equals("Respesta incorrecta") || mjs.Equals(""))
            {
                return View("~/Views/Home/Recuperar.cshtml");
            }
            else
            {
                m.EnviarCorreo(usuario);
                return View();
            }       

        }

        public ActionResult Restaurada()
        {

            Metodos m = new Metodos();
            string codigo = Request.Form["codigo"].ToString();
            string usuario = "";
            string mjs = "";

            if (TempData["usuario"] != null)
                usuario = TempData["usuario"] as string;

            //verificacion codigo
            mjs = m.Codigo(usuario,codigo);
            TempData.Keep();

            if (mjs.Equals("Incorrecta"))
            {
                return View("~/Views/Home/Index.cshtml");
            }
            else
            {
                return View();
            }          

        }

        public ActionResult NuevaContra()
        {
            Metodos m = new Metodos();
            string pass = Request.Form["pass"].ToString();
            string usuario = "";
            string mjs = "";

            if (TempData["usuario"] != null)
                usuario = TempData["usuario"] as string;

            //actualizar contraseña
            mjs = m.Contra(usuario, pass);
            TempData.Keep();

            return View("~/Views/Home/Index.cshtml");

        }

        public ActionResult Registro()
        {
           
            return View();

        }

    }
}