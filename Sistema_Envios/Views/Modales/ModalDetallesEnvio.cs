using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Envios.Models;
using System.Data.SqlClient;

namespace Sistema_Envios.Views.Modales
{
    public partial class ModalDetallesEnvio : Form
    {
        public Envio Envio { get; set; }
        private EmpleadoServices _empleadoServices;
        private Conexion _cone;
        private VehiculoServices _vehiculoServices;
        public ModalDetallesEnvio(Envio envio)
        {
            InitializeComponent();
            txtFolioPedido.TextAling = HorizontalAlignment.Center;
            _empleadoServices = new EmpleadoServices();
            _vehiculoServices = new VehiculoServices();
            _cone = new Conexion();
            dgvConceptosPedido.EnableHeadersVisualStyles = false;
            dgvConceptosPedido.RowTemplate.Height = 30;
            this.Envio = envio; // Asignar el objeto Envio
            this.Precargar_info(); // Precargar la información

        }

        public void Precargar_info()
        {
            CargarEmpleados();
            CargarVehiculos();
            CargarInformacion();

            txtDireccion.Texts = this.Envio.Direccion;
            cbEmpleados.SelectedValue = this.Envio.ID_Empleado;
            cbVehiculos.SelectedValue = this.Envio.ID_Vehiculo;
            txtFolioPedido.Texts = this.Envio.ID_Pedido.ToString();
           
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

        public void CargarInformacion()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("GenerarTicketPedido", _cone.AbrirConexion()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Pedido", this.Envio.ID_Pedido);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtCliente.Texts = reader["Cliente"].ToString(); // Asigna el nombre del cliente
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Envio envio = new Envio
            {
                ID_Envio = this.Envio.ID_Envio,
                ID_Vehiculo = this.Envio.ID_Vehiculo,
                ID_Empleado = this.Envio.ID_Empleado,
            };

            // Llamar al método para actualizar
            response respuesta = Envio.Actuzalizar(envio);

            if (respuesta.Success)
            {
                MessageBox.Show(respuesta.Message);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ocurrio un erro:" + respuesta.Message);
            }
            
        }
    }
}
