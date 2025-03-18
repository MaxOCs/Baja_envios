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
    public partial class ModalModificarAlmacen : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalModificarAlmacen()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Almacen.Nombre,Almacen.Direccion,Almacen.Capacidad
                        From Almacen
                        Where Almacen.ID_Almacen = @ID_Almacen";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@ID_Almacen", txtID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtDireccion.Text = reader["Direccion"].ToString();
                            txtCapacidad.Text = reader["Capacidad"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para este ID de Almacen.");
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
            string query = @"UPDATE Almacen
                         SET Nombre = @Nombre,
                             Direccion = @Direccion,
                             Capacidad = @Capacidad
                         WHERE Almacen.ID_Almacen = @ID_Almacen";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asignar valores desde los controles del formulario
                    cmd.Parameters.AddWithValue("@ID_Almacen", txtID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@Capacidad", Convert.ToInt32(txtCapacidad.Text));


                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Almacen actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Almacen.");
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
