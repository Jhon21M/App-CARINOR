using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Interfaz_CARINOR_2._0
{
    public class MProductos
    {
        Conexion conx = new Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarP()
        {
            comando.Connection = conx.AbrirConexion();
            comando.CommandText = "Select * from PRODUCTO";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conx.CerrarConexion();
            return tabla;

        }

    }
}
