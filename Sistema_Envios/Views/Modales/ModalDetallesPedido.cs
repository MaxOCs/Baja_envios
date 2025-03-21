using Sistema_Envios.Data;
using Sistema_Envios.Models;
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
using static Sistema_Envios.Views.Modales.ModalAgregarConcepto;

namespace Sistema_Envios.Views.Modales
{
    public partial class ModalDetallesPedido : Form
    {
        private ClienteServices clienteServices;
        private Conexion _cone;
        public Pedido pedido { get; set; } 
        private int id_cliente;
        private decimal total = 0;
        public ModalDetallesPedido(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
            clienteServices = new ClienteServices();
            dgvConceptosPedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _cone = new Conexion();
            dgvConceptosPedido.EnableHeadersVisualStyles = false;
            dgvConceptosPedido.RowTemplate.Height = 30;
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
                    cmd.Parameters.AddWithValue("@ID_Pedido", this.pedido.ID_Pedido);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBuscarClientes.Texts = reader["Cliente"].ToString();// Asigna el nombre del cliente
                            txtTotal.Texts= reader["Total"].ToString();
                            txtFolioPedido.Texts = this.pedido.ID_Pedido.ToString();
                            total +=Convert.ToDecimal(reader["Total"].ToString());
                        }

                        // Si hay más registros, los agregamos a la tabla
                        dgvConceptosPedido.Rows.Clear();
                        do
                        {
                            if (reader["Producto"] != DBNull.Value)
                            {
                                // Obtener los valores del reader
                                int idProducto = Convert.ToInt32(reader["ID_Producto"]);
                                string producto = reader["Producto"].ToString();
                                int cantidad = Convert.ToInt32(reader["Cantidad"]);
                                decimal precio = Convert.ToDecimal(reader["Precio"]);

                                // Calcular el total (cantidad * precio)
                                decimal total = cantidad * precio;

                                // Agregar la fila al DataGridView
                                dgvConceptosPedido.Rows.Add(
                                    idProducto.ToString(),
                                    producto,
                                    cantidad.ToString(),
                                    precio.ToString(), // Formato de moneda
                                    total.ToString()    // Formato de moneda
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

        private void txtBuscarClientes__TextChanged(object sender, EventArgs e)
        {

            string query = txtBuscarClientes.Texts.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LbClientes.Visible = false;
                txtDireccion.Texts = "";
                txtTelefono.Texts = "";
                LbClientes.Items.Clear();
                return;
            }
            LbClientes.Visible = true;
            // Llamamos a la función para realizar la búsqueda en la base de datos
            var clientes = clienteServices.BuscarClientes(query);

            // Limpiamos el ListBox y agregamos los resultados
            LbClientes.Items.Clear();
            foreach (var cliente in clientes)
            {
                LbClientes.Items.Add(cliente.Nombre);
            }

            if (LbClientes.Items.Count == 1)
            {
                // Seleccionar el único elemento en el ListBox
                LbClientes.SelectedIndex = 0;

                // Obtener el cliente seleccionado
                string clienteSeleccionado = LbClientes.SelectedItem.ToString();
                Cliente cliente = clienteServices.BuscarClientePorNombre(clienteSeleccionado);

                // Precargar los datos del cliente
                txtBuscarClientes.Texts = cliente.Nombre.ToString();
                id_cliente = cliente.ID_Cliente;
                txtDireccion.Texts = cliente.Direccion.ToString();
                txtTelefono.Texts = cliente.Telefono.ToString();
                LbClientes.Visible = false; // Ocultar el ListBox después de seleccionar
            }
        }

        private void LbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbClientes.SelectedItem != null)
            {
                string clienteSeleccionado = LbClientes.SelectedItem.ToString();
                Cliente cliente = clienteServices.BuscarClientePorNombre(clienteSeleccionado);
                txtBuscarClientes.Texts = cliente.Nombre.ToString();
                id_cliente = cliente.ID_Cliente;
                txtDireccion.Texts = cliente.Direccion.ToString();
                txtTelefono.Texts = cliente.Telefono.ToString();
                LbClientes.Visible = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Obtener los detalles del DataGridView
            List<Parametro> parametros = ObtenerDetallesDesdeDataGridView(dgvConceptosPedido);

            // Agregar otros parámetros si es necesario
            parametros.Add(new Parametro(
               nombre: "@ID_Pedido",
               valor: this.pedido.ID_Pedido,
               tipo: SqlDbType.Int,
               direccion: ParameterDirection.Input));

            parametros.Add(new Parametro(
                nombre: "@ID_Cliente",
                valor: id_cliente,
                tipo: SqlDbType.Int,
                direccion: ParameterDirection.Input));

            parametros.Add(new Parametro(
                nombre: "@Fecha_Pedido",
                valor: DateTime.Now,
                tipo: SqlDbType.DateTime,
                direccion: ParameterDirection.Input));

            parametros.Add(new Parametro(
                nombre: "@Estado_Pedido",
                valor: "Pendiente",
                tipo: SqlDbType.VarChar,
                direccion: ParameterDirection.Input));

            // Ejecutar el procedimiento almacenado
            var respuesta = Repositorio.EjecutarProcedimiento("ActualizarPedidoConDetalles", parametros);

            // Verificar si la ejecución fue exitosa
            if (respuesta.Success)
            {
                MessageBox.Show("Pedido actuzalizado exitosamente");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al crear el pedido: " + respuesta.Message);
            }
        }
        public List<Parametro> ObtenerDetallesDesdeDataGridView(DataGridView dgv)
        {
            var detalles = new List<Parametro>();

            // Crear una tabla en memoria para los detalles
            DataTable dtDetalles = new DataTable();
            dtDetalles.Columns.Add("ID_Producto", typeof(int));
            dtDetalles.Columns.Add("Cantidad", typeof(int));
            dtDetalles.Columns.Add("Subtotal", typeof(decimal));

            // Recorrer las filas del DataGridView
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue; // Ignorar la fila nueva (vacía)

                // Crear una nueva fila para la tabla en memoria
                DataRow dr = dtDetalles.NewRow();
                dr["ID_Producto"] = row.Cells[0].Value; // Nombre del producto
                dr["Cantidad"] = row.Cells[2].Value; // Cantidad
                dr["Subtotal"] = row.Cells[4].Value; // Subtotal
                dtDetalles.Rows.Add(dr);
            }

            // Crear un parámetro para el procedimiento almacenado
            Parametro parametroDetalles = new Parametro(
                nombre: "@DetallesPedido", // El nombre del parámetro
                valor: dtDetalles, // La tabla con los detalles
                tipo: SqlDbType.Structured, // Tipo tabla
                direccion: ParameterDirection.Input // Dirección Input
            );

            detalles.Add(parametroDetalles);

            return detalles;
        }

        private void btnEliminarConcepto_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvConceptosPedido.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvConceptosPedido.SelectedRows[0];

                // Obtener el valor de la columna "Total" de la fila seleccionada
                if (selectedRow.Cells["Total"].Value != null && !string.IsNullOrEmpty(selectedRow.Cells["Total"].Value.ToString()))
                {
                    // Obtener el valor de la celda como cadena
                    string totalFilaStr = selectedRow.Cells["Total"].Value.ToString();

                    // Eliminar caracteres no numéricos (como símbolos de moneda o comas)
                    totalFilaStr = totalFilaStr.Replace("$", "").Replace(",", "").Trim();

                    // Convertir a decimal
                    if (decimal.TryParse(totalFilaStr, out decimal totalFila))
                    {
                        // Restar el valor de la fila eliminada del total
                        total -= totalFila;

                        // Actualizar el TextBox que muestra el total (si es necesario)
                        txtTotal.Text = total.ToString("C"); // Formato de moneda
                    }
                    else
                    {
                        MessageBox.Show("El valor de la columna 'Total' no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Eliminar la fila
                dgvConceptosPedido.Rows.Remove(selectedRow);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ModalAgregarConcepto modal = new ModalAgregarConcepto();
            modal.StartPosition = FormStartPosition.CenterParent;
            if (modal.ShowDialog() == DialogResult.OK)
            {
                ProductoSeleccionado producto = modal.Producto;

                // Agregar el producto al DataGridView
                dgvConceptosPedido.Rows.Add(producto.id, producto.Nombre, producto.Cantidad, producto.Precio, producto.Precio * producto.Cantidad);
                total += (producto.Cantidad * producto.Precio);
                txtTotal.Texts = "$" + total.ToString();
            };
        }
    }
}
