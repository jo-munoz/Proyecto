using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.Tareas
{
    public partial class Tareas : System.Web.UI.Page
    {
        #region Metodos y Funciones
        /// <summary>
        /// OBTIENE ESTADO TAREAS
        /// </summary>
        void getEstadoTareas()
        {
            Controllers.TareasControllers obTareasControllers = new Controllers.TareasControllers();
            DataSet dsConsultaEstadoTareas = obTareasControllers.getConsultarEstadoTareasController();

            //Asigno origen de datos
            ddlEstadoTarea.DataSource = dsConsultaEstadoTareas;
            ddlEstadoTarea.DataValueField = "estaCodigo";//lo que equivale
            ddlEstadoTarea.DataTextField = "estaDescripcion";//lo que se muestra
            ddlEstadoTarea.DataBind();//acepte los cambios
        }

        /// <summary>
        /// OBTIENE PRIORIDAD
        /// </summary>
        void getPrioridad()
        {
            Controllers.TareasControllers obTareasControllers = new Controllers.TareasControllers();
            DataSet dsConsultaPrioridad = obTareasControllers.getConsultarPrioridadController();

            //Asigno origen de datos
            ddlPrioridad.DataSource = dsConsultaPrioridad;
            ddlPrioridad.DataValueField = "prioCodigo";//lo que equivale
            ddlPrioridad.DataTextField = "prioDescripcion";//lo que se muestra
            ddlPrioridad.DataBind();//acepte los cambios
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
                getEstadoTareas();
                getPrioridad();
            }
        }
        #endregion
    }
}