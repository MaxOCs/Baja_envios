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
using Sistema_Envios.Views.Modales;
using Sistema_Envios.Data;
namespace Sistema_Envios.Views
{
    public partial class Curd_Vehiculos : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        private int filaSeleccionada = -1;
        public Curd_Vehiculos()
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
                    string query = @"SELECT * FROM Vehiculo";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCatalogoVehiculos.AutoGenerateColumns = true;
                    dgvCatalogoVehiculos.DataSource = dt;
                    dgvCatalogoVehiculos.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void dgvCatalogoVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Debe seleccionar un Vehiculo de la primera columna antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del cliente desde la primera columna de la fila seleccionada
            int idVehiculo;
            if (!int.TryParse(dgvCatalogoVehiculos.Rows[filaSeleccionada].Cells[0].Value?.ToString(), out idVehiculo))
            {
                MessageBox.Show("El ID del Almacen seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el Almacen con ID {idVehiculo}?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Conexión a la base de datos
                using (SqlConnection conn = new SqlConnection(CD_Conexion))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("EXEC spDelete_Vehiculo @ID_Vehiculo", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID_Vehiculo", idVehiculo);
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Vehiculo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvCatalogoVehiculos.Rows.RemoveAt(filaSeleccionada); // Eliminar la fila del DataGridView
                                filaSeleccionada = -1; // Resetear la selección
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el Vehiculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Vehiculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ModalRegistrarVehiculo form = new ModalRegistrarVehiculo();
            form.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ModalModificarVehiculo mod = new ModalModificarVehiculo();
            mod.Show();

        }
    }
}
