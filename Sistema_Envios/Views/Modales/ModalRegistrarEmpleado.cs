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
    public partial class ModalRegistrarEmpleado : Form
    {
        string CD_Conexion = "SERVER=localhost;Database=ENVIOS_DB;Integrated Security=True";
        public ModalRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void ModalRegistrarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string licencia = txtLicencia.Text;
            string telefono = txtTelefono.Text;


            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(licencia) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(CD_Conexion))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("spInsert_Empleado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Licencia", txtLicencia.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Empleado insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        txtNombre.Clear();
                        txtLicencia.Clear();
                        txtTelefono.Clear();
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
