using System;

namespace Proyecto.Web.Recursos.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] stEmail = null;

                if (Session["sessionEmail"] != null)
                {
                    stEmail = Session["sessionEmail"].ToString().Split('@');
                    lblUsuario.Text = stEmail[0];
                }
                else
                {
                    Response.Redirect("../../Views/Login/Login.aspx");
                }

                //ALT + 126
                imgUsuario.ImageUrl = "~/Images/" + Session["sessionEmail"].ToString() + ".jpg";
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../Views/Login/Login.aspx");
        }
        #endregion
    }
}