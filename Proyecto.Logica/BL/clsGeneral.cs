using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace Proyecto.Logica.BL
{
    public class clsGeneral
    {
        public void setEmail(Models.clsCorreo obclsCorreo)
        {
            try
            {
                //objeto de correo
                System.Net.Mail.MailMessage Mail = new System.Net.Mail.MailMessage();

                Mail.From = new System.Net.Mail.MailAddress(obclsCorreo.stFrom);
                Mail.To.Add(obclsCorreo.stTo);
                Mail.Subject = obclsCorreo.stAsunto;
                Mail.Body = obclsCorreo.stMensaje;

                if(obclsCorreo.inTipo == 0)Mail.IsBodyHtml = false;
                else if(obclsCorreo.inTipo == 1) Mail.IsBodyHtml = true;                

                if (obclsCorreo.inPrioridad == 2) Mail.Priority = System.Net.Mail.MailPriority.High;
                if (obclsCorreo.inPrioridad == 1) Mail.Priority = System.Net.Mail.MailPriority.Low;
                if (obclsCorreo.inPrioridad == 0) Mail.Priority = System.Net.Mail.MailPriority.Normal;

                AlternateView htmlview = AlternateView.CreateAlternateViewFromString(obclsCorreo.stMensaje,
                                                                                        Encoding.UTF8, 
                                                                                        MediaTypeNames.Text.Html);

                //incrustando una imagen
                LinkedResource img = new LinkedResource(obclsCorreo.stImagen, MediaTypeNames.Image.Gif);
                img.ContentId = obclsCorreo.stIdImagen;
                htmlview.LinkedResources.Add(img);

                Mail.AlternateViews.Add(htmlview);

                //c liente de servidor de correo
                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
                smtp.Host = obclsCorreo.stServidor;

                if (obclsCorreo.blAutenticacion) smtp.Credentials = new System.Net.NetworkCredential(obclsCorreo.stUsuario, obclsCorreo.stPassword);
                if (obclsCorreo.stPuerto.Length > 0) smtp.Port = Convert.ToInt32(obclsCorreo.stPuerto);

                smtp.EnableSsl = obclsCorreo.blAutenticacion;
                smtp.Send(Mail);
            }
            catch(Exception ex){ throw ex; }
        }

        public string Log(string message)
        {
            message = message.Replace("'", "")
                             .Replace("$", "")
                             .Replace("Ñ", "N")
                             .Replace("ñ", "n")
                             .Replace("%", "")
                             .Replace("á", "a")
                             .Replace("é", "e")
                             .Replace("í", "i")
                             .Replace("ó", "o")
                             .Replace("ú", "u")
                             .Replace("Á", "A")
                             .Replace("É", "E")
                             .Replace("Í", "I")
                             .Replace("Ó", "O")
                             .Replace("Ú", "U")
                             .Replace("{", "")
                             .Replace("}", "")
                             .Replace(".", " ")
                             .Replace("\r\n", " ");
            
            return message;            
        }

    }
}
