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
    public partial class ModalModificarEmpleado : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalModificarEmpleado()
        {
            InitializeComponent();
        }

        private void ModalModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Empleado.Nombre,Empleado.Licencia,Empleado.Telefono
                        From Empleado
                        Where Empleado.ID_Empleado = @ID_Empleado";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);


                    cmd.Parameters.AddWithValue("@ID_Empleado", txtID.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtLicencia.Text = reader["Licencia"].ToString();
                            txtTelefono.Text = reader["Telefono"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron registros para este ID de Empleado.");
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
            string query = @"UPDATE Empleado
                         SET Nombre = @Nombre,
                             Licencia = @Licencia,
                             Telefono = @Telefono
                         WHERE Empleado.ID_Empleado = @ID_Empleado";
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Asignar valores desde los controles del formulario
                    cmd.Parameters.AddWithValue("@ID_Empleado", txtID.Text);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Licencia", txtLicencia.Text);
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text);


                    // Ejecutar la consulta
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Empleado actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el Empleado.");
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
