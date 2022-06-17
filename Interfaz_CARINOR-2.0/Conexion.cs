using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace Interfaz_CARINOR_2._0
{
    public class Conexion
    {
        private SqlConnection conx = new SqlConnection("Server = (local); DataBase= CARINORT; Integrated Security= true");

        public SqlConnection AbrirConexion()
        {
            if (conx.State == ConnectionState.Closed)
                conx.Open();
            return conx;
        }

        public SqlConnection CerrarConexion()
        {
            if (conx.State == ConnectionState.Open)
                conx.Close();
            return conx;
        }
    }
}
