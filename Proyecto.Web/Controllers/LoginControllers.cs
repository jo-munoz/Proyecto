using System;

namespace Proyecto.Web.Controllers
{
    public class LoginControllers
    {
        /// <summary>
        /// VALIDA USUARIO        
        /// </summary>
        /// <param name="obclsUsuarios">OBJETO USUARIO</param>
        /// <returns>CONFIRMACION</returns>
        public bool getValidarUsuariosController(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                Logica.BL.clsUsuarios obclsUsuario = new Logica.BL.clsUsuarios();

                return obclsUsuario.getValidarUsuarios(obclsUsuarios);
            }
            catch (Exception ex) { throw ex; }
        }
    }
}