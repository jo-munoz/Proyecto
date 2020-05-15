using System;
using System.Configuration;
using System.Data;

namespace Proyecto.Web.Views.RecuperarPassword
{
    public partial class RecuperarPassword : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //armo obojeto de tipo obclsUsuarios
                Controllers.RecuperarPasswordControllers obRecuperarPasswordControllers = new Controllers.RecuperarPasswordControllers();
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text
                };

                //envio el objeto obclsUsuarios como parametro de consultar                     
                DataSet dsConsulta = obRecuperarPasswordControllers.getConsultaPaswordController(obclsUsuarios);

                //valido si la consulta devuelve informacion
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    //capturo el nombre del usuario
                    string[] stLogin = dsConsulta.Tables[0].Rows[0]["usuaLogin"].ToString().Split('@');

                    //armo el cuerpo del correo
                    string stCuerpoHTML = "<!DOCTYPE html>";
                    stCuerpoHTML += "<html lang='es'>";
                    stCuerpoHTML += "<head>";
                    stCuerpoHTML += "<meta charset='utf - 8'>";
                    stCuerpoHTML += "<title>Recuperacion de correo</title>";
                    stCuerpoHTML += "</head>";
                    stCuerpoHTML += "<body style='background - color: black '>";
                    stCuerpoHTML += "<table style='max - width: 600px; padding: 10px; margin: 0 auto; border - collapse: collapse; '>	";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='padding: 0'>";
                    stCuerpoHTML += "<img style='padding: 0; display: block' src='cid:Fondo' width='100%' height='10%'>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='background - color: #ecf0f1'>";
                    stCuerpoHTML += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>";
                    stCuerpoHTML += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola " + stLogin[0] + "</h2>";
                    stCuerpoHTML += "<p style='margin: 2px; font - size: 15px'>";
                    stCuerpoHTML += "Hemos recibido una solicitud para restablecer el password de su cuenta asociada con ";
                    stCuerpoHTML += "esta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este ";
                    stCuerpoHTML += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "Su password es: " + dsConsulta.Tables[0].Rows[0]["usuaPassword"].ToString();
                    stCuerpoHTML += "</p>";
                    stCuerpoHTML += "<p style='color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0'>Copyright © CRM 2020</p>";
                    stCuerpoHTML += "</div>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "</table>";
                    stCuerpoHTML += "</body>";
                    stCuerpoHTML += "</html>";

                    //armo el objeto de tipo obclsCorreo
                    Logica.Models.clsCorreo obclsCorreo = new Logica.Models.clsCorreo
                    {
                        stServidor = ConfigurationManager.AppSettings["stServidor"].ToString(),
                        stUsuario = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stPassword = ConfigurationManager.AppSettings["stPassword"].ToString(),
                        stPuerto = ConfigurationManager.AppSettings["stPuerto"].ToString(),
                        blAutenticacion = true,
                        bolConexionSegura = true,
                        inPrioridad = 0, //prioridad normal
                        inTipo = 1, //html
                        stAsunto = "Recuperacion de password",
                        stFrom = ConfigurationManager.AppSettings["stUsuario"].ToString(),
                        stTo = txtEmail.Text,
                        stImagen = Server.MapPath("~") + @"\Resources\Images\Fondo.gif",
                        stIdImagen = "Fondo",
                        stMensaje = stCuerpoHTML
                    };

                    //envio el objeto de tipo obclsCorreo para el envio de correo
                    obRecuperarPasswordControllers.setEmailController(obclsCorreo);
                    txtEmail.Text = string.Empty;
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', 'Se realizo proceso con exito!', 'success') </script>");
                }
                else
                {
                    throw new Exception("No se encontro informacion asociada a esa direccion de correo");
                }
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }
        #endregion
    }
}