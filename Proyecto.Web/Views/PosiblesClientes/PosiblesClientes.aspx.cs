using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Proyecto.Web.Views.PosiblesClientes
{
    public partial class PosiblesClientes : System.Web.UI.Page
    {
        #region Metodos y Funciones
        /// <summary>
        /// OBTIENE CONSULTA POSIBLES CLIENTES
        /// </summary>
        void getPosiblesClientess()
        {
            try
            {
                Controllers.PosiblesClientesControllers obposiblesClientesControllers = new Controllers.PosiblesClientesControllers();
                DataSet dsConsulta = obposiblesClientesControllers.getConsultarPosiblesClientesController();

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    gvwDatos.DataSource = dsConsulta;
                }
                else
                {
                    gvwDatos.DataSource = null;
                }
                gvwDatos.DataBind();
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + ex.Message + "', 'error')</script>");
            }
        }

        /// <summary>
        /// LIMPIA LOS CAMPOS DESPUES DE UNA ACCION
        /// </summary>
        void LimpiaCampos()
        {
            lblOpcion.Text = string.Empty;
            txtIdentificacion.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtPrimerNombre.Text = string.Empty;
            txtSegundoNombre.Text = string.Empty;
            txtPrimerApellido.Text = string.Empty;
            txtSegundoApellido.Text = string.Empty;
            txtDirecion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Session["sessionEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
                getPosiblesClientess();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;

                if (string.IsNullOrEmpty(txtIdentificacion.Text))
                {
                    stMensaje += "Ingrese identificación, ";
                }

                if (!string.IsNullOrEmpty(stMensaje))
                {
                    throw new Exception(stMensaje.TrimEnd(','));
                }

                Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                {
                    lnIdentificacion = Convert.ToInt64(txtIdentificacion.Text),
                    stEmpresa = txtEmpresa.Text,
                    stPrimerNombre = txtPrimerNombre.Text,
                    stSegundoNombre = txtSegundoNombre.Text,
                    stPrimerApellido = txtPrimerApellido.Text,
                    stSegundoApellido = txtSegundoApellido.Text,
                    stDireccion = txtDirecion.Text,
                    stTelefono = txtTelefono.Text,
                    stCorreo = txtCorreo.Text
                };

                Controllers.PosiblesClientesControllers obposiblesClientesControllers = new Controllers.PosiblesClientesControllers();

                if (string.IsNullOrEmpty(lblOpcion.Text))
                {
                    lblOpcion.Text = "1";
                }

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Mensaje!', '" + obposiblesClientesControllers.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(lblOpcion.Text)) + "', 'success')</script>");                

                getPosiblesClientess();
                LimpiaCampos();
                txtIdentificacion.Enabled = true;
            }
            catch (Exception ex)
            {
                Logica.BL.clsGeneral obclsGeneral = new Logica.BL.clsGeneral();
                string stError = obclsGeneral.Log(ex.Message.ToString());
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + stError + "', 'error')</script>");
            }
        }

        protected void gvwDatos_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            try
            {
                int inIndice = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName.Equals("Editar"))
                {
                    lblOpcion.Text = "2";
                    txtIdentificacion.Enabled = false;

                    //ACCEDE A UN CONTROL WEB DENTRO DE UN GRID
                    txtIdentificacion.Text = ((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text;

                    //ACCEDE A UNA CELDE DENTRO DE UN GRID
                    txtEmpresa.Text = gvwDatos.Rows[inIndice].Cells[1].Text.Replace("&nbsp;","");
                    txtPrimerNombre.Text = gvwDatos.Rows[inIndice].Cells[2].Text.Replace("&nbsp;", "");
                    txtSegundoNombre.Text = gvwDatos.Rows[inIndice].Cells[3].Text.Replace("&nbsp;", "");
                    txtPrimerApellido.Text = gvwDatos.Rows[inIndice].Cells[4].Text.Replace("&nbsp;", "");
                    txtSegundoApellido.Text = gvwDatos.Rows[inIndice].Cells[5].Text.Replace("&nbsp;", "");
                    txtDirecion.Text = gvwDatos.Rows[inIndice].Cells[6].Text.Replace("&nbsp;", "");
                    txtTelefono.Text = gvwDatos.Rows[inIndice].Cells[7].Text.Replace("&nbsp;", "");
                    txtCorreo.Text = gvwDatos.Rows[inIndice].Cells[8].Text.Replace("&nbsp;", "");
                }
                else if (e.CommandName.Equals("Eliminar"))
                {
                    lblOpcion.Text = "3";

                    Logica.Models.clsPosiblesClientes obclsPosiblesClientes = new Logica.Models.clsPosiblesClientes
                    {
                        lnIdentificacion = Convert.ToInt64(((Label)gvwDatos.Rows[inIndice].FindControl("lblIdentificacion")).Text),
                        stEmpresa = string.Empty,
                        stPrimerNombre = string.Empty,
                        stSegundoNombre = string.Empty,
                        stPrimerApellido = string.Empty,
                        stSegundoApellido = string.Empty,
                        stDireccion = string.Empty,
                        stTelefono = string.Empty,
                        stCorreo = string.Empty
                    };

                    Controllers.PosiblesClientesControllers obposiblesClientesControllers = new Controllers.PosiblesClientesControllers();

                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Mensaje!', '" + obposiblesClientesControllers.setAdministrarPosiblesClientesController(obclsPosiblesClientes, Convert.ToInt32(lblOpcion.Text)) + "', 'success')</script>");                    

                    getPosiblesClientess();
                    LimpiaCampos();
                    txtIdentificacion.Enabled = true;
                }
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
                LimpiaCampos();
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