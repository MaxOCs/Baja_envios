using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Envios.Views.Modales
{
    public partial class ModalModificarVehiculo : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalModificarVehiculo()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Vehiculo.Tipo,Vehiculo.Placa,Vehiculo.Estado
                        From Vehiculo
                        Where Vehiculo.ID_Vehiculo = @ID_Vehiculo";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@ID_Vehiculo", txtID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtTipo.Text = reader["Tipo"].ToString();
                            txtPlaca.Text = reader["Placa"].ToString();
                            txtEstado.Text = reader["Estado"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para este ID de Vehiculo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Vehiculo
                         SET Tipo = @Tipo,
                             Placa = @Placa,
                             Estado = @Estado
                         WHERE Vehiculo.ID_Vehiculo = @ID_Vehiculo";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asignar valores desde los controles del formulario
                    cmd.Parameters.AddWithValue("@ID_Vehiculo", txtID.Text);
                    cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text);
                    cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text);
                    cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);


                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Vehiculo actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Vehiculo.");
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
