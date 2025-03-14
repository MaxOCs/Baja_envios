using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Envios.Data
{
    public class Repositorio
    {
        private Conexion _conexion;

        public Repositorio()
        {
            _conexion = new Conexion();
        }

        // Método para ejecutar una consulta y devolver un DataTable
        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, _conexion.AbrirConexion()))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (puedes logearla o lanzarla)
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
            return dt;
        }

        // Método para ejecutar una consulta que no devuelve resultados (INSERT, UPDATE, DELETE)
        public int EjecutarNonQuery(string consulta)
        {
            int filasAfectadas = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand(consulta, _conexion.AbrirConexion()))
                {
                    filasAfectadas = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                _conexion.CerrarConexion();
            }
            return filasAfectadas;
        }
        public static response EjecutarProcedimiento(string ProcedureName, List<Parametro> Parametros, string conexion = "")
        {
            try
            {
                // Si no se proporciona una cadena de conexión, usa una por defecto
                if (string.IsNullOrEmpty(conexion))
                {
                    conexion = "Data Source=LAPMAX;Initial Catalog=ENVIOS_DB;Integrated Security=True";
                }

                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(ProcedureName, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Agregar parámetros al comando
                        if (Parametros != null)
                        {
                            foreach (var parametro in Parametros)
                            {
                                cmd.Parameters.Add(new SqlParameter
                                {
                                    ParameterName = parametro.Nombre,
                                    SqlDbType = parametro.Tipo,
                                    Direction = parametro.Direccion,
                                    Value = parametro.Valor ?? DBNull.Value // Manejo de valores nulos
                                });
                            }
                        }

                        // Ejecutar el procedimiento almacenado
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Leer los resultados si es necesario
                            var result = new List<Dictionary<string, object>>();
                            while (reader.Read())
                            {
                                var row = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    row.Add(reader.GetName(i), reader.GetValue(i));
                                }
                                result.Add(row);
                            }

                            // Devolver una respuesta exitosa con los datos
                            return new response(true, "Procedimiento ejecutado correctamente", result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Devolver una respuesta de error
                return new response(false, $"Error al ejecutar el procedimiento: {ex.Message}");
            }
        }
        // Método genérico para ejecutar consultas y retornar una lista de objetos
        public List<T> ObtenerLista<T>(string query, Func<IDataReader, T> mapper)
        {
            List<T> lista = new List<T>();

            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _conexion.AbrirConexion()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Usa el delegado "mapper" para convertir el IDataReader en un objeto T
                            lista.Add(mapper(reader));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción (puedes logearla o lanzarla)
                throw new Exception("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                _conexion.CerrarConexion();
            }

            return lista;
        }
    }
}

