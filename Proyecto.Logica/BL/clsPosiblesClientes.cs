using System;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
    public class clsPosiblesClientes
    {
        SqlConnection _SqlConnection = null;
        SqlParameter _SqlParameter = null;
        SqlDataAdapter _SqlDataAdapter = null;
        SqlCommand _SqlCommand = null;
        string stConexion = string.Empty;

        public clsPosiblesClientes()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }
    }
}
