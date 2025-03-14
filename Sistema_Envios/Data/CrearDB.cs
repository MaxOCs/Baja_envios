using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Drawing;


namespace Sistema_Envios.Data
{
    public class CrearDB
    {
        //private Conexion conexion = new Conexion();
        public string connectionString = "Data Source=LAPMAX\\LAPMAX;Initial Catalog=DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string CrearBaseDeDatos()
        {
            //string connectionString = "Data Source=LAPMAX\\LAPMAX;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string query = "CREATE DATABASE DB_PRACTICA";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                }

                return "Base de datos creada con éxito.";
            }
            catch (Exception ex)
            {
                return "Error al crear la base de datos: " + ex.Message;
            }
        }

        public string CreateTable()
        {
            string query = "Create Table Tabla1(CampoClave int not null,CampoString nvarchar(5) not null, CampoFechaHora DateTime not null, CampoDinero Money not null ,CampoPtoFlotante Float null)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.ExecuteNonQuery();
                    }
                }

                return "Tablas creadas con exito.";
            }
            catch (Exception ex)
            {
                return "Error al crear las tablas " + ex.Message;
            }


        }

        public string insertData()
        {
            string query = "Insert into Tabla1(CampoClave, CampoString, CampoFechaHora, CampoDinero,CampoPtoFlotante) Values (@CC, @CS, @CFH, @CD, @CPF)";
            int Cve = 1;
            string CS = "Hola";
            DateTime FH = DateTime.Now;
            float Dinero = 550.50F;//se pone como sufijo una F para indicar que es un float
            float Valor = 1.55F;//se pone como sufijo una F para indicar que es un float

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add("@CC", SqlDbType.Int).Value = Cve;
                        comando.Parameters.Add("@CS", SqlDbType.NVarChar).Value = CS;
                        comando.Parameters.Add("@CFH", SqlDbType.DateTime).Value = FH;
                        comando.Parameters.Add("@CD", SqlDbType.Money).Value = Dinero;
                        comando.Parameters.Add("@CPF", SqlDbType.Float).Value = Valor;
                        comando.ExecuteNonQuery();
                        conexion.Close();
                    }
                }

                return "Insert realizado con exito.";
            }
            catch (Exception ex)
            {
                return "Error al insertar" + ex.Message;
            }

        }

    }
}
