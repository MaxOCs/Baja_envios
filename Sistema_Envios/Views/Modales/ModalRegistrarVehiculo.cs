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
    public partial class ModalRegistrarVehiculo : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalRegistrarVehiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Tipo = txtTipo.Text;
            string Placa = txtPlaca.Text;
            string Estado = txtEstado.Text;


            if (string.IsNullOrEmpty(Tipo) || string.IsNullOrEmpty(Placa) || string.IsNullOrEmpty(Estado))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsert_Vehiculo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text.Trim());
                        cmd.Parameters.AddWithValue("@Placa", txtPlaca.Text.Trim());
                        cmd.Parameters.AddWithValue("@Estado", txtEstado.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Almacen insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txtTipo.Clear();
                        txtPlaca.Clear();
                        txtEstado.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
