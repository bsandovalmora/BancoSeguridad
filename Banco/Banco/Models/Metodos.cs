using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using System.IO;

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

        public string Registrar(string nombre, string apellidos, string usuario, string cedula, string telefono, string direccion, string correo, string pregunta, string respuesta, string pass)
        {
            string mjs = "";

            try
            {
                b.registrar(nombre, apellidos, usuario, Convert.ToInt32(cedula), Convert.ToInt32(telefono), direccion, correo, pregunta, respuesta, pass,ref mjs);

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

        public void EnviarCorreo(string usuario, string asunto, string cuerpo)
        {
    
            string correo = Correo(usuario);  

            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress(correo));
            msg.From = new MailAddress("bsandovalmora@gmail.com");
            msg.Subject = asunto;
            msg.Body = cuerpo;
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