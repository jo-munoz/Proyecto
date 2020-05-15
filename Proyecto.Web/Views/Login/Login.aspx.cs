using System;
using System.Web;

namespace Proyecto.Web.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.Cookies["cookieEmail"] != null)
                {
                    txtEmail.Text = Request.Cookies["cookieEmail"].Value.ToString();
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingrese email, ";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += " Ingrese password,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

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
                    Session["sessionEmail"] = txtEmail.Text;

                    if (chkRecordar.Checked)
                    {
                        //creo un objetocookie
                        HttpCookie cookie = new HttpCookie("cookieEmail",txtEmail.Text);
                        //adicciono el tiempo de vida
                        cookie.Expires = DateTime.Now.AddDays(2);
                        //agrego a la coleccion de cookies
                        Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("cookieEmail", txtEmail.Text);
                        //la cookie expira el dia de ayer
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies.Add(cookie);
                    }
                    
                    Response.Redirect("../Index/Index.aspx");
                }
                else
                {
                    throw new Exception("Email o Password incorrecto");
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