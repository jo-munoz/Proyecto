using System;
using System.Collections.Generic;

namespace Proyecto.Web.Views.Eventos
{
    public partial class Eventos : System.Web.UI.Page
    {
        #region Metodos y Funciones
        void getEventosJson()
        {
            try
            {
                Controllers.EventosController obEventosController = new Controllers.EventosController();
                List<Logica.Models.clsEventos> lstclsEventos = obEventosController.getEventosJsonController();

                if (lstclsEventos.Count > 0)
                {
                    gvwDatosJson.DataSource = lstclsEventos;
                }
                else
                {
                    gvwDatosJson.DataSource = null;
                }
                gvwDatosJson.DataBind();
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }

        void getEventosXML()
        {
            try
            {
                Controllers.EventosController obEventosController = new Controllers.EventosController();
                var lstclsEventos = obEventosController.getEventosXMLController();

                if (lstclsEventos != null)
                {
                    gvwDatosXML.DataSource = lstclsEventos;
                }
                else
                {
                    gvwDatosXML.DataSource = null;
                }
                gvwDatosXML.DataBind();
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
                getEventosJson();
                getEventosXML();
            }
        }
        #endregion
    }
}