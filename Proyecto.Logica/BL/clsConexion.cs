using System.Configuration;

namespace Proyecto.Logica.BL
{
    public class clsConexion
    {
        /// <summary>
        /// OBTIENE CONEXION A BD        
        /// </summary>
        /// <returns>CADENA DE CONEXION</returns>
        public string getConexion()
        {
            return ConfigurationManager.ConnectionStrings["Cnx"].ToString();
        }
    }
}
