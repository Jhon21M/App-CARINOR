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
        private Conexion Coc = new Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        DataTable tabla = new DataTable();
        public DataTable MostrarDProduct()
        {
            comando.Connection = Coc.AbrirConexion();
            comando.CommandText = "Select * from PRODUCTO";
            leer= comando.ExecuteReader();
            tabla.Load(leer);
            Coc.CerrarConexion();
            return tabla;
        }
        
    }
}
