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
                string codigo = m.GenerarCodigo();
                string cuerpo = "Estimado/a " + usuario +
                "\n ¿Ha olvidado su contraseña?\n" +
                "Se genero un codigo para su restauración  de contraseña\n" +
                "Codigo: " + codigo +
                "\nSi no desea cambiar su contraseña o no ha solicitado este cambio, obvie y elimine este mensaje.\n" +
                "Gracias, \n" +
                "El equipo de cuentas de Apollo\n";                
                string asunto = "Restauración de la contraseña Sitio Banco Seguridad";

                m.InsertarCodigo(codigo, usuario);
                m.EnviarCorreo(usuario, asunto, cuerpo);

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

        public ActionResult Registro_Verificacion()
        {
            Metodos m = new Metodos();
            string mjs = "";

            string nombre = Request.Form["nombre"].ToString();
            string apellidos = Request.Form["apellidos"].ToString();
            string usuario = Request.Form["usuario"].ToString();
            string cedula = Request.Form["cedula"].ToString();
            string telefono = Request.Form["telefono"].ToString();
            string direccion = Request.Form["direccion"].ToString();
            string correo = Request.Form["correo"].ToString();
            string pregunta = Request.Form["pregunta"].ToString();
            string respuesta = Request.Form["respuesta"].ToString();
            string pass = Request.Form["pass"].ToString();


            //insertar
            mjs = m.Registrar(nombre, apellidos, usuario, cedula, telefono, direccion, correo, pregunta, respuesta, pass);

            
            TempData["usuario"] = usuario;

            if (mjs.Equals("Insertado"))
            {
                string codigo = m.GenerarCodigo();

                string asunto = "Nueva cuenta - Banco - Cuentas Apollo";
                string cuerpo = "Estimado/a " + usuario +
                "\n Se ha creado la cuenta para su uso\n" +
                "Se genero un código para la creación de la cuenta\n" +
                "Codigo: " + codigo +
                "\n Ingrese en codigo en su respectiva pagina y campo .\n" +
                "Gracias, \n" +
                "El equipo de cuentas de Apollo\n";

                m.InsertarCodigo(codigo, usuario);
                m.EnviarCorreo(usuario, asunto, cuerpo);

                return View();
            }
            else
            {
                return View("~/Views/Home/Registro.cshtml");
            }
        }

        public ActionResult Registro_completado()
        {

            Metodos m = new Metodos();
            string codigo = Request.Form["codigo"].ToString();
            string usuario = "";
            string mjs = "";

            if (TempData["usuario"] != null)
                usuario = TempData["usuario"] as string;

            //verificacion codigo
            mjs = m.Codigo(usuario, codigo);
            TempData.Keep();

           
            return View("~/Views/Home/Index.cshtml");

        }

    }
}