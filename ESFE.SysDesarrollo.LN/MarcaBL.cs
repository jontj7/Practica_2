using ESFE.SysDesarrollo.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.SysDesarrollo.LN
{
    public class MarcaBL
    {
        public int InsertarMarca(Marca pMarca)
        {
            // Verifica que los datos de la marca no sean nulos o vacíos
            if (pMarca == null || string.IsNullOrWhiteSpace(pMarca.Nombre))
            {
                throw new ArgumentException("Los datos de la marca no pueden ser nulos o vacíos.");
            }

            // Inserta una nueva marca en la base de datos
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();

                using (SqlCommand _command = new SqlCommand("InsertarMarca", _conn as SqlConnection))
                {
                    _command.CommandType = CommandType.StoredProcedure;

                    // Agrega los parámetros al comando
                    _command.Parameters.Add(new SqlParameter("@Nombre", pMarca.Nombre));
                    _command.Parameters.Add(new SqlParameter("@Descripcion", pMarca.Descripcion ?? (object)DBNull.Value));
                    _command.Parameters.Add(new SqlParameter("@RegMarca", pMarca.RegMarca));

                    // Ejecuta el comando y obtiene el número de filas afectadas
                    int resultado = _command.ExecuteNonQuery();
                    return resultado;
                }
            }
        }


        //otro metodo Seleccionar todo
        public List<Marca> ObtenerMarcas()
        {
            List<Marca> _marcas = new List<Marca>();


            //la lista es para tener todos los valores necesitamos que devuelva todo lo que esta en la tabla
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("SELECT * FROM Marca", _conn as SqlConnection);
                SqlDataReader _reader = _command.ExecuteReader();//esto se lo se usa con el select

                while (_reader.Read())
                {
                    Marca _marca = new Marca
                    {

                        //esto es un casteo esto pasar parametros al tipo de datos que va a leer
                        IdMarca = (int)_reader.GetSqlInt32(0),
                        Nombre = _reader.GetString(1),
                        Descripcion = _reader.GetString(2),
                        RegMarca = (int)_reader.GetSqlInt32(3)
                    };

                    _marcas.Add(_marca);
                }

                _reader.Close();
                _conn.Close();
                return _marcas;
                
            }
        }

        //Buscar por nombre
        public List<Marca> ObtenerMarcaNombre(string pNombre)
        {
            List<Marca> _marcas = new List<Marca>();


            //la lista es para tener todos los valores necesitamos que devuelva todo lo que esta en la tabla
            using (IDbConnection _conn = BDComun.ObtenerConexion())
            {
                _conn.Open();
                SqlCommand _command = new SqlCommand("BuscarMarcaNombre", _conn as SqlConnection);
                _command.CommandType = CommandType.StoredProcedure;

                _command.Parameters.Add(new SqlParameter("@Nombre", pNombre));

                SqlDataReader _reader = _command.ExecuteReader();//esto se lo se usa con el select

                while (_reader.Read())
                {
                    Marca _marca = new Marca
                    {

                        //esto es un casteo esto pasar parametros al tipo de datos que va a leer
                        IdMarca = (int)_reader.GetSqlInt32(0),
                        Nombre = _reader.GetString(1),
                        Descripcion = _reader.GetString(2),
                        RegMarca = (int)_reader.GetSqlInt32(3)
                    };

                    _marcas.Add(_marca);
                }

                _reader.Close();
                _conn.Close();
                return _marcas;

            }
        }

        //metodo actualizar 
        public int ActualizarMarca(Marca pMarca)
        {
            try
            {
                using (IDbConnection _conn = BDComun.ObtenerConexion())
                {
                    _conn.Open();
                    SqlCommand _command = new SqlCommand("ActualizarMarca", _conn as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.Add(new SqlParameter("@IdMarca", pMarca.IdMarca));
                    _command.Parameters.Add(new SqlParameter("@Nombre", pMarca.Nombre));
                    _command.Parameters.Add(new SqlParameter("@Descripcion", pMarca.Descripcion));
                    _command.Parameters.Add(new SqlParameter("@RegMarca", pMarca.RegMarca));

                    SqlParameter returnParameter = _command.Parameters.Add("ReturnValue", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    _command.ExecuteNonQuery();

                    int result = (int)returnParameter.Value;

                    _conn.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrarla o mostrar un mensaje de error)
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Retornar un valor negativo para indicar error
            }
        }

        public int EliminarMarca(int idMarca)
        {
            try
            {
                using (IDbConnection _conn = BDComun.ObtenerConexion())
                {
                    _conn.Open();
                    SqlCommand _command = new SqlCommand("EliminarMarca", _conn as SqlConnection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.Add(new SqlParameter("@IdMarca", idMarca));

                    SqlParameter returnParameter = _command.Parameters.Add("ReturnValue", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;

                    _command.ExecuteNonQuery();

                    int result = (int)returnParameter.Value;

                    _conn.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (por ejemplo, registrarla o mostrar un mensaje de error)
                Console.WriteLine("Error: " + ex.Message);
                return -1; // Retornar un valor negativo para indicar error
            }
        }
    }
}
