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

namespace Sistema_Envios.Views
{
    public partial class Crud_Almacen : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        private int filaSeleccionada = -1;
        public Crud_Almacen()
        {
            InitializeComponent();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM Almacen";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCatalogoAlmacen.AutoGenerateColumns = true;
                    dgvCatalogoAlmacen.DataSource = dt;
                    dgvCatalogoAlmacen.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Debe seleccionar un Almacen de la primera columna antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del cliente desde la primera columna de la fila seleccionada
            int idAlmacen;
            if (!int.TryParse(dgvCatalogoAlmacen.Rows[filaSeleccionada].Cells[0].Value?.ToString(), out idAlmacen))
            {
                MessageBox.Show("El ID del Almacen seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el Almacen con ID {idAlmacen}?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Conexión a la base de datos
                using (SqlConnection conn = new SqlConnection(CD_Conexion))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("EXEC spDelete_Almacen @ID_Almacen", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID_Cliente", idAlmacen);
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Almacen eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvCatalogoAlmacen.Rows.RemoveAt(filaSeleccionada); // Eliminar la fila del DataGridView
                                filaSeleccionada = -1; // Resetear la selección
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
