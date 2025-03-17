using System;
using Sistema_Envios.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_Envios.Data
{
    public class ProductosServices
    {
        private Repositorio _repositorio;
        private Conexion _cone;
        public ProductosServices()
        {

            _repositorio = new Repositorio();
            _cone = new Conexion();
        }

        public Producto ObtenerProductoPorId(int idProducto)
        {
            string consulta = "SELECT * FROM producto WHERE ID_Producto = @ID";
            Repositorio repo = new Repositorio();
            Producto producto = repo.GetById<Producto>(consulta, idProducto);
            return producto;
        }

        public Producto BuscarProductoPorNombre(string nombre)
        {
            Producto producto = null;

            string sqlQuery = "SELECT P.ID_Producto , P.Nombre as Producto, P.Precio from Producto P WHERE P.Nombre = @nombre";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _cone.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@nombre", nombre);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            producto = new Producto
                            {
                                ID_Producto = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Precio = reader.GetDecimal(2),
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener cliente: " + ex.Message);
                }
            }


            return producto;
        }

        public List<Producto> BuscarProcuto(string query)
        {
            var productos = new List<Producto>();
            // Consulta SQL para buscar clientes
            string sqlQuery = "SELECT P.ID_Producto , P.Nombre as Producto, P.Precio from Producto P WHERE P.Nombre LIKE @query";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, _cone.AbrirConexion()))
            {
                // Usamos un parámetro para evitar inyección de SQL
                cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var producto = new Producto
                            {
                                ID_Producto = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Precio = reader.GetDecimal(2),

                            };
                            productos.Add(producto);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar clientes: " + ex.Message);
                }
            }

            return productos;
        }


    }
}
