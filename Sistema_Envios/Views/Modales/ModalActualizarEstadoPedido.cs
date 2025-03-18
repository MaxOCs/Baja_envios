using Sistema_Envios.Models;
using Sistema_Envios.Data;
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
    public partial class ModalActualizarEstadoPedido : Form
    {
        public int ID_Pedido { get; set; }
        private Conexion _cone;
        private EmpleadoServices _empleadoServices;
        private VehiculoServices _vehiculoServices;
        public ModalActualizarEstadoPedido()
        {
            InitializeComponent();
            _cone= new Conexion();
            _empleadoServices= new EmpleadoServices();
            _vehiculoServices= new VehiculoServices();
            // Configurar el estilo del encabezado de las columnas
            dgvConceptosPedido.EnableHeadersVisualStyles = false;
            dgvConceptosPedido.RowTemplate.Height = 30;
            CargarEmpleados();
            CargarVehiculos();
        }

        private void ModalActualizarEstadoPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarInformacion()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GenerarTicketPedido", _cone.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pedido", ID_Pedido);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombreCliente.Texts = reader["Cliente"].ToString(); // Asigna el nombre del cliente
                        }

                        // Si hay más registros, los agregamos a la tabla
                        dgvConceptosPedido.Rows.Clear();
                        do
                        {
                            if (reader["Producto"] != DBNull.Value)
                            {
                                dgvConceptosPedido.Rows.Add(
                                    reader["Producto"].ToString(),
                                    reader["Cantidad"].ToString(),
                                    reader["Subtotal"].ToString()
                                );
                            }
                        } while (reader.Read());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información: " + ex.Message);
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                var empleados = _empleadoServices.ObtenerEmpleados();

                // Validar que la lista no esté vacía o nula
                if (empleados == null || empleados.Count == 0)
                {
                    MessageBox.Show("No hay almacenes disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la lista al ComboBox
                cbEmpleados.DataSource = empleados;
                cbEmpleados.DisplayMember = "Nombre";
                cbEmpleados.ValueMember = "ID_Empleado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los almacenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVehiculos()
        {
            try
            {
                var vehiculos = _vehiculoServices.ObtenerVehiculos();

                // Validar que la lista no esté vacía o nula
                if (vehiculos == null || vehiculos.Count == 0)
                {
                    MessageBox.Show("No hay almacenes disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la lista al ComboBox
                cbVehiculos.DataSource = vehiculos;
                cbVehiculos.DisplayMember = "DisplayText";
                cbVehiculos.ValueMember = "ID_Vehiculo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los almacenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrarEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                Envio newEnvio = new Envio
                {
                    ID_Pedido = ID_Pedido,
                    ID_Empleado = Convert.ToInt32(cbEmpleados.SelectedValue),
                    ID_Vehiculo = Convert.ToInt32(cbVehiculos.SelectedValue),
                };

                // Capturar la respuesta del método Agregar
                response respuesta = Envio.AgregarEnvio(newEnvio);

                // Mostrar el mensaje de respuesta
                MessageBox.Show(respuesta.Message);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que los campos de cantidad y precio sean valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
