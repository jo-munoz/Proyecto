using System;
using System.IO;

namespace Proyecto.Web.Views.CrearCuenta
{
    public partial class CrearCuenta : System.Web.UI.Page
    {
        #region Metodos y Funciones
        /// <summary>
        /// LIMPIA LOS CAMPOS
        /// </summary>
        private void LimpiarCampos()
        {
            txtLogin.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmarPassword.Text = string.Empty;
        }
        #endregion

        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                //validamos la seleccion de una imagen
                if (fulImagen.HasFile)
                {
                    if (!Path.GetExtension(fulImagen.FileName).Equals(".jpg")) throw new Exception("Solo se admiten formatos .JPG");

                    //guardo imagen en carpeta temporal
                    string stRuta = Server.MapPath(@"~\tmp\") + fulImagen.FileName; //ruta temporal
                    fulImagen.PostedFile.SaveAs(stRuta); //guardo el archivo dentro del proyecto

                    string stRutaDestino = Server.MapPath(@"~\Images\") + txtLogin.Text + Path.GetExtension(fulImagen.FileName); //ruta destino + nombre archivo + extension

                    if (File.Exists(stRutaDestino))
                    {
                        File.SetAttributes(stRutaDestino, FileAttributes.Normal);
                        File.Delete(stRutaDestino);
                    }

                    File.Copy(stRuta, stRutaDestino);
                    File.SetAttributes(stRuta, FileAttributes.Normal);
                    File.Delete(stRuta);

                    Logica.Models.clsUsuarios obclsUsuarios = new Logica.Models.clsUsuarios
                    {
                        stLogin = txtLogin.Text,
                        stPassword = txtPassword.Text,
                        stImagen = stRutaDestino
                    };

                    Controllers.CrearCuentaController obCrearCuentaController = new Controllers.CrearCuentaController();
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Mensaje!', '" + obCrearCuentaController.setCrearCuentaController(obclsUsuarios, 1) + "', 'success') </script>");
                    LimpiarCampos();
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