using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;

                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    stMensaje += "Ingrese email, ";
                }

                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    stMensaje += " Ingrese password,";
                }

                if (!string.IsNullOrEmpty(stMensaje))
                {
                    throw new Exception(stMensaje.TrimEnd(','));
                }

                //Defino objeto con propiedades
                Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                {
                    stLogin = txtEmail.Text,
                    stPassword = txtPassword.Text
                };

                //Instalcio controlador
                Controllers.LoginControllers obloginController = new Controllers.LoginControllers();
                bool blBandera = obloginController.getValidarUsuariosController(obclsUsuarios);

                //Valido respuesta
                if (blBandera)
                {
                    Response.Redirect("../Index/Index.aspx");
                }
                else
                {
                    throw new Exception("Email o Password incorrexto");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + ex.Message + "', 'error')</script>");
            }
        }
    }
}