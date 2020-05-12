using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsEstadoTarea
    {
        SqlConnection _SqlConnection = null;
        SqlDataAdapter _SqlDataAdapter = null;
        SqlCommand _SqlCommand = null;
        string stConexion = string.Empty;

        public clsEstadoTarea()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// CONSULTA ESTADO TAREA
        /// </summary>
        /// <returns>REGISTROS ESTADO TAREA</returns>
        public DataSet getConsultarEstadoTareas()
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarEstadoTeras", _SqlConnection);
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
