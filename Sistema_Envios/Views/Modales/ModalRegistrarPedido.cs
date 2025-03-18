using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Envios.Data;
using Sistema_Envios.Models;
using static Sistema_Envios.Views.Modales;

namespace Sistema_Envios.Views.Modales.ModalAgregarConcepto
{
    public partial class ModalRegistrarPedido : Form
    {
        private ClienteServices clienteServices;
        public ModalRegistrarPedido()
        {
            InitializeComponent();
            clienteServices = new ClienteServices();
            LbClientes.Visible = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarClientes__TextChanged(object sender, EventArgs e)
        {
            string query = txtBuscarClientes.Texts.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LbClientes.Visible = false;
                txtDireccion.Texts= "";
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
        }

        private void LbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbClientes.SelectedItem != null)
            {
                string clienteSeleccionado = LbClientes.SelectedItem.ToString();
                Cliente cliente = clienteServices.BuscarClientePorNombre(clienteSeleccionado);
                txtBuscarClientes.Texts = cliente.Nombre.ToString();
                txtDireccion.Texts= cliente.Direccion.ToString();
                txtTelefono.Texts= cliente.Telefono.ToString();
                LbClientes.Visible = false;
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
                dgvConceptosPedido.Rows.Add(producto.Nombre, producto.Cantidad ,producto.Precio , producto.Precio * producto.Cantidad);
            };
        }

        private void ModalRegistrarPedido_Load(object sender, EventArgs e)
        {

        }
    }
}
