using System;
using System.Data;
using System.Data.SqlClient;
namespace Proyecto.Logica.BL
{
    public class clsPrioridad
    {
        SqlConnection _SqlConnection = null;
        SqlDataAdapter _SqlDataAdapter = null;
        SqlCommand _SqlCommand = null;
        string stConexion = string.Empty;

        public clsPrioridad()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// CONSULTA PRIORIDAD
        /// </summary>
        /// <returns>REGISTROS PRIORIDAD</returns>
        public DataSet getConsultarPrioridad()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarPrioridad", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                return dsConsulta;
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlCommand.Clone(); }
        }
    }
}
