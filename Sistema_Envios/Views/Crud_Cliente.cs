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
    public partial class Crud_Cliente : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        private int filaSeleccionada = -1;
        public Crud_Cliente()
        {
            InitializeComponent();
        }

        private void Crud_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM Cliente";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvCatalogoClientes.AutoGenerateColumns = true;
                    dgvCatalogoClientes.DataSource = dt;
                    dgvCatalogoClientes.Refresh();
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
                MessageBox.Show("Debe seleccionar un cliente de la primera columna antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del cliente desde la primera columna de la fila seleccionada
            int idCliente;
            if (!int.TryParse(dgvCatalogoClientes.Rows[filaSeleccionada].Cells[0].Value?.ToString(), out idCliente))
            {
                MessageBox.Show("El ID del cliente seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult result = MessageBox.Show($"¿Está seguro de que desea eliminar el cliente con ID {idCliente}?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Conexión a la base de datos
                using (SqlConnection conn = new SqlConnection(CD_Conexion))
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand("EXEC spDelete_Cliente @ID_Cliente", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvCatalogoClientes.Rows.RemoveAt(filaSeleccionada); // Eliminar la fila del DataGridView
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

        private void dgvCatalogoClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                filaSeleccionada = e.RowIndex;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
          ModalRegistrarCliente form = new ModalRegistrarCliente();
          form.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            ModalModificarCliente form = new ModalModificarCliente();
            form.Show();
        }
    }
}
