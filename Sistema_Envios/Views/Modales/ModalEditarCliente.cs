using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Envios.Views.Modales
{
    public partial class ModalEditarCliente : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalEditarCliente()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Cliente.Nombre,Cliente.Direccion,Cliente.Telefono
                            From Cliente
                            Where Cliente.ID_Cliente = @ID_Cliente";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@ID_Cliente", txtID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtDireccion.Text = reader["Direccion"].ToString();
                            txtTel.Text = reader["Telefono"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para este ID de Cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Cliente
                             SET Nombre = @Nombre,
                                 Direccion = @Direccion,
                                 Telefono = @Telefono
                             WHERE Cliente.ID_Cliente = @ID_Cliente";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asignar valores desde los controles del formulario
                    cmd.Parameters.AddWithValue("@ID_Cliente", txtID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTel.Text);
                    

                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Cliente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
