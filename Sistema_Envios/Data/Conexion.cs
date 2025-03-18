using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class Conexion
    {
        private SqlConnection CD_Conexion = new SqlConnection("SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True"); //CADENA DE CONEXIÓN (cambiar de ser necesario)
        public SqlConnection AbrirConexion()
        {
            if (CD_Conexion.State == ConnectionState.Closed)
                CD_Conexion.Open();
            return CD_Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (CD_Conexion.State == ConnectionState.Open)
                CD_Conexion.Close();
            return CD_Conexion;
        }
    }
}
