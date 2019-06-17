using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Datos
{
        public class Metodos
        {
            string ConsultaSQL;

            public void SetConsultaSQL(string consulta)
            {
                ConsultaSQL = consulta;
            }
            //CREAR COMANDO 
            public static SqlCommand createCommand()
            {
                string _cadena = Connection.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadena;

                SqlCommand _comando = new SqlCommand();
                _comando = _conexion.CreateCommand();
                _comando.CommandType = CommandType.Text;
                return _comando;
            }
            public static SqlCommand createProcedure(string proc)
            {
                string _cadena = Connection.CadenaConexion;
                SqlConnection _conexion = new SqlConnection(_cadena);

                SqlCommand _comando = new SqlCommand(proc,_conexion);
                _comando.CommandType = CommandType.StoredProcedure;
                return _comando;
            }
            //EJECUTAR COMANDOS
            public static int ejecutarComando(SqlCommand _comando)
            {
                try
                {
                    _comando.Connection.Open();
                    return _comando.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
                finally
                {
                    _comando.Connection.Dispose();
                    _comando.Connection.Close();
                }
            }
            //EJECUTAR CONSULTA
            public static DataTable ejecutarConsulta(SqlCommand _comando)
            {
                DataTable _tabla = new DataTable();
                try
                {
                    _comando.Connection.Open();
                    SqlDataAdapter _adaptador = new SqlDataAdapter();
                    _adaptador.SelectCommand = _comando;
                    _adaptador.Fill(_tabla);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    _comando.Connection.Close();
                }
                return _tabla;
            }
        }
}
