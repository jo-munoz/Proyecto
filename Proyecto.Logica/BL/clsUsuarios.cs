using System;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto.Logica.BL
{
    public class clsUsuarios
    {
        SqlConnection _SqlConnection = null;
        SqlParameter _SqlParameter = null;
        SqlDataAdapter _SqlDataAdapter = null;
        SqlCommand _SqlCommand = null;
        string stConexion = string.Empty;

        public clsUsuarios()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        /// <summary>
        /// VALIDAR USUARIO
        /// </summary>
        /// <param name="obclsUsuarios">OBJETO USUARIO</param>
        /// <returns>CONFIRMACION</returns>
        public bool getValidarUsuarios(Logica.Models.clsUsuarios obclsUsuarios)
        {
            try
            {
                DataSet dsConsulta = new DataSet();

                _SqlConnection = new SqlConnection(stConexion);
                _SqlConnection.Open();

                _SqlCommand = new SqlCommand("spConsultarUsuario", _SqlConnection);
                _SqlCommand.CommandType = CommandType.StoredProcedure;

                _SqlCommand.Parameters.Add(new SqlParameter("@cLogin", obclsUsuarios.stLogin));
                _SqlCommand.Parameters.Add(new SqlParameter("@cPassword", obclsUsuarios.stPassword));

                _SqlCommand.ExecuteNonQuery();

                _SqlDataAdapter = new SqlDataAdapter(_SqlCommand);
                _SqlDataAdapter.Fill(dsConsulta);

                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { _SqlCommand.Clone(); }
        }
    }
}
