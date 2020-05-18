using System;
using System.Collections.Generic;

namespace Proyecto.Web.Views.Eventos
{
    public partial class Eventos : System.Web.UI.Page
    {
        #region Metodos y Funciones
        void getEventos()
        {
            try
            {
                Controllers.EventosController obEventosController = new Controllers.EventosController();
                List<Logica.Models.clsEventos> lstclsEventos = obEventosController.getEventosController();

                if (lstclsEventos.Count > 0)
                {
                    gvwDatos.DataSource = lstclsEventos;
                }
                else
                {
                    gvwDatos.DataSource = null;
                }
                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["sessionEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
                getEventos();
            }
        }
        #endregion
    }
}