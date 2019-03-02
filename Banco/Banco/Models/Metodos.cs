using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace Banco.Models
{
    public class Metodos
    {
        BancoDataContext b = new BancoDataContext();

        public string Cuenta(string usuario, string pass)
        {
            string mjs = "";

            try
            {
                b.buscar_credencial(usuario, pass,ref mjs);
            }
            catch (Exception e)
            {
                
            }
            return mjs;
        }

        public string Pregunta(string usuario)
        {
            string mjs = "";
            string pregunta = "";
            

            try
            {
                b.buscar_pregunta(usuario,ref mjs,ref pregunta);
               
            }
            catch (Exception e)
            {

            }
            return pregunta;
        }

        public string Respuesta(string usuario, string respuesta)
        {
            string mjs = "";

            try
            {
                b.buscar_resp(usuario, respuesta, ref mjs);

            }
            catch (Exception e)
            {

            }
            return mjs;
        }

        public string Codigo(string usuario, string codigo)
        {
            string mjs = "";

            try
            {
                b.buscar_codigo(usuario, codigo, ref mjs);

            }
            catch (Exception e)
            {

            }
            return mjs;
        }

        public string Contra(string usuario, string pass)
        {
            string mjs = "";

            try
            {
                b.nueva_pass(usuario, pass, ref mjs);

            }
            catch (Exception e)
            {

            }
            return mjs;
        }

        public string Correo(string usuario)
        {
            string mjs = "";

            try
            {
                b.buscar_correo(usuario, ref mjs);

            }
            catch (Exception e)
            {

            }
            return mjs;
        }

        public string GenerarCodigo()
        {
            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            var seed = int.Parse(justNumbers.Substring(0, 8));

            return seed.ToString();
        }

        public void InsertarCodigo(string codigo, string usuario)
        {
            try
            {
                b.insertar_codigo(usuario, codigo);

            }
            catch (Exception e)
            {

            }
        }

        public void EnviarCorreo(string usuario)
        {

            string codigo = GenerarCodigo();
            string correo = Correo(usuario);

            InsertarCodigo(codigo,usuario);
           
            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress("bsandovalmora@gmail.com"));
            msg.From = new MailAddress("bsandovalmora@gmail.com");
            msg.Subject = "Restauración de la contraseña Sitio Banco Seguridad";
            msg.Body = "Estimado/a " + usuario +
                "\n ¿Ha olvidado su contraseña?\n" +
                "Se genero un codigo para su restauración  de contraseña\n" +
                "Codigo: " + codigo +
                "\nSi no desea cambiar su contraseña o no ha solicitado este cambio, obvie y elimine este mensaje.\n" +
                "Gracias, \n" +
                "El equipo de cuentas de Apollo\n";
            msg.Priority = MailPriority.High;

            SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com");
            clienteSmtp.Port = 25;
            clienteSmtp.Credentials = new NetworkCredential("bsandovalmora@gmail.com", "200742967");
            clienteSmtp.EnableSsl = true;

            try
            {
                clienteSmtp.Send(msg);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.ReadLine();
            }
        }
    }
}