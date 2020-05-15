using System;
using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// LIMPIA LOS CAMPOS DESPUES DE UNA ACCION
        /// </summary>
        void LimpiarCampos()
        {
            txtCodigo.Text = string.Empty;
            txtTitularTarea.Text = string.Empty;
            txtAsunto.Text = string.Empty;
            txtFechaVencimiento.Text = string.Empty;
            txtContacto.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            ddlEstadoTarea.SelectedValue = "1";
            ddlPrioridad.SelectedValue = "1";
            chkEnviarMensaje.Checked = false;
            chkRepetir.Checked = false;
            txtDescripcion.Text = string.Empty;
        }

        /// <summary>
        /// OBTIENE CONSULTA TODAS LAS TAREAS
        /// </summary>
        void getTareas()
        {
            try
            {
                Controllers.TareasControllers obTareasControllers = new Controllers.TareasControllers();
                List<Logica.Models.clsTareas> lstclsTareas = obTareasControllers.getTareasController();

                if (lstclsTareas.Count > 0)
                {
                    gvwDatos.DataSource = lstclsTareas;
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
                getEstadoTareas();
                getPrioridad();
                getTareas();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtCodigo.Text)) stMensaje += "Ingrese codigo, ";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                Logica.Models.clsTareas obclsTareas = new Logica.Models.clsTareas
                {
                    inCodigo = Convert.ToInt32(txtCodigo.Text),
                    stTitular = txtTitularTarea.Text,
                    stAsunto = txtAsunto.Text,
                    stFechaVencimiento = txtFechaVencimiento.Text,
                    stContacto = txtContacto.Text,
                    stCuenta = txtCuenta.Text,
                    obclsEstadoTareas = new Logica.Models.clsEstadoTareas
                    {
                        inCodigo = Convert.ToInt32(ddlEstadoTarea.SelectedValue),
                    },
                    obclsPrioridad = new Logica.Models.clsPrioridad
                    {
                        inCodigo = Convert.ToInt32(ddlPrioridad.SelectedValue)
                    },
                    stEnviarMensaje = chkEnviarMensaje.Checked ? "S" : "N",
                    stRepetir = chkRepetir.Checked ? "S" : "N",
                    stDescripcion = txtDescripcion.Text
                };

                Controllers.TareasControllers obTareasControllers = new Controllers.TareasControllers();
                if (string.IsNullOrEmpty(lblOpcion.Text))//adicionar
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Mensaje!', '" + obTareasControllers.addTareasController(obclsTareas) + "', 'success')</script>");
                else
                    ClientScript.RegisterStartupScript(this.GetType(), "Mensaje", "<script> swal('Mensaje','" + obTareasControllers.updateTareasController(obclsTareas) + "','success') </script>");
                LimpiarCampos();
                getTareas();
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarCampos();
                txtCodigo.Focus();
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }

        protected void gvwDatos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "2";
                    txtCodigo.Enabled = false;

                    //ACCEDE A UN CONTROL WEB DENTRO DE UN GRID
                    txtCodigo.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text;

                    //ACCEDE A UNA CELDE DENTRO DE UN GRID
                    txtTitularTarea.Text = gvwDatos.Rows[inIndice].Cells[1].Text.Replace("&nbsp;", "");
                    txtAsunto.Text = gvwDatos.Rows[inIndice].Cells[2].Text.Replace("&nbsp;", "");
                    txtFechaVencimiento.Text = gvwDatos.Rows[inIndice].Cells[3].Text.Replace("&nbsp;", "");
                    txtContacto.Text = gvwDatos.Rows[inIndice].Cells[4].Text.Replace("&nbsp;", "");
                    txtCuenta.Text = gvwDatos.Rows[inIndice].Cells[5].Text.Replace("&nbsp;", "");
                    ddlEstadoTarea.SelectedValue = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigoEstadoTarea")).Text;
                    ddlPrioridad.SelectedValue = ((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigoPrioridad")).Text;
                    chkEnviarMensaje.Checked = gvwDatos.Rows[inIndice].Cells[8].Text.Equals("S") ? true : false;
                    chkRepetir.Checked = gvwDatos.Rows[inIndice].Cells[9].Text.Equals("S") ? true : false;
                    txtDescripcion.Text = gvwDatos.Rows[inIndice].Cells[10].Text.Replace("&nbsp;", "");
                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    Logica.Models.clsTareas obclsTareas = new Logica.Models.clsTareas
                    {
                        inCodigo = Convert.ToInt32(((Label)gvwDatos.Rows[inIndice].FindControl("lblCodigo")).Text)
                    };

                    Controllers.TareasControllers obTareasControllers = new Controllers.TareasControllers();
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Mensaje!', '" + obTareasControllers.deleteTareasController(obclsTareas) + "', 'success')</script>");

                    LimpiarCampos();
                    getTareas();
                    txtCodigo.Enabled = true;
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