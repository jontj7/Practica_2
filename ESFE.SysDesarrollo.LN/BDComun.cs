using System;
using System.Data;
using System.Data.SqlClient;

namespace ESFE.SysDesarrollo.LN
{
    public class BDComun
    {
        public const string _stringCnn = @"Data Source=JONT\SQLEXPRESS;Initial Catalog=BDDesarrollo;Integrated Security=True";

        /// <summary>
        /// Método para obtener la conexión a la base de datos.
        /// </summary>
        /// <returns>Devuelve la conexión</returns>
        public static IDbConnection ObtenerConexion()
        {
            return new SqlConnection(_stringCnn);
        }

        /// <summary>
        /// Método para ejecutar un comando SQL que devuelve un IDataReader.
        /// </summary>
        /// <param name="pConexion">La conexión a la base de datos.</param>
        /// <param name="pSql">La consulta SQL a ejecutar.</param>
        /// <returns>IDataReader con los resultados.</returns>
        public static IDataReader ObtenerCommando(IDbConnection pConexion, string pSql)
        {
            try
            {
                SqlCommand _command = new SqlCommand(pSql, pConexion as SqlConnection);
                return _command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                throw; // Vuelve a lanzar la excepción si es necesario
            }
        }

        /// <summary>
        /// Método para ejecutar un comando SQL que no devuelve resultados.
        /// </summary>
        /// <param name="pSql">La consulta SQL a ejecutar.</param>
        /// <returns>El número de filas afectadas.</returns>
        public static int EjecutarComando(string pSql)
        {
            using (var conexion = ObtenerConexion())
            {
                using (var command = new SqlCommand(pSql, conexion as SqlConnection))
                {
                    try
                    {
                        conexion.Open();
                        return command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de excepciones
                        Console.WriteLine("Error al ejecutar el comando: " + ex.Message);
                        throw; // Vuelve a lanzar la excepción si es necesario
                    }
                }
            }
        }
    }
}
