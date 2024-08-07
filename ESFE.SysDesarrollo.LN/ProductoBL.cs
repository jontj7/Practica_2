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
    public class ProductoBL
    {
        public int InsertarProducto(Producto pProducto)
        {
            using (IDbConnection _Conn = BDComun.ObtenerConexion())
            {
                _Conn.Open();
                SqlCommand _Command = new SqlCommand("InsertarProducto", _Conn as SqlConnection);
                _Command.CommandType = CommandType.StoredProcedure;

                _Command.Parameters.Add(new SqlParameter("@Nombre", pProducto.Nombre));
                _Command.Parameters.Add(new SqlParameter("@Descripcion", pProducto.Descripcion));
                _Command.Parameters.Add(new SqlParameter("@Precio", pProducto.Precio));
                _Command.Parameters.Add(new SqlParameter("@Existencia", pProducto.Existencia));

                int _resultado = _Command.ExecuteNonQuery();
                _Conn.Close();
                return _resultado;
            }
        }
    }
}
