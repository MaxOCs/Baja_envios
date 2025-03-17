using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Envios.Data
{
    
    public class ClienteServices
    {
        private Repositorio _repositorio;
        private Conexion _cone;

        public ClienteServices()
        {
            _repositorio = new Repositorio();
            _cone= new Conexion();
        }


        //metodo para buscar los clientes 

        public Cliente BuscarClientePorNombre(string nombre)
        {
            Cliente cliente = null;
      
                string sqlQuery = "SELECT ID_Cliente, Nombre, Direccion,Telefono FROM Cliente WHERE Nombre = @nombre";

                using (SqlCommand cmd = new SqlCommand(sqlQuery, _cone.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cliente = new Cliente
                                {
                                    ID_Cliente = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Direccion= reader.GetString(2),
                                    Telefono = reader.GetString(3)
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener cliente: " + ex.Message);
                    }
                }
            

            return cliente;
        }

        public List<Cliente> BuscarClientes(string query)
        {
            var clientes = new List<Cliente>();
                // Consulta SQL para buscar clientes
                string sqlQuery = "SELECT ID_Cliente, Nombre, Direccion, Telefono FROM Cliente WHERE Nombre LIKE @query";

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
                            var cliente = new Cliente
                            {
                                ID_Cliente = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                Direccion= reader.GetString(2),
                                Telefono = reader.GetString(3)
                                
                            };
                            clientes.Add(cliente);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar clientes: " + ex.Message);
                }
            }

            return clientes;
        }
    }
}
