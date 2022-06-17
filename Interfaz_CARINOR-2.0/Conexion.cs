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
        private SqlConnection Conecction = new SqlConnection("Server = (local); Database = CARINORT; Integrated Security = true");

        public SqlConnection AbrirConexion()
        {
            if (Conecction.State == ConnectionState.Closed)
                Conecction.Open();

            return Conecction;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conecction.State == ConnectionState.Open)
                Conecction.Close();

            return Conecction;
        }


    }
}
