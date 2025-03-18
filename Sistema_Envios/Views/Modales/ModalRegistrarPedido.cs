﻿using System;
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
        private int id_cliente;
        private decimal total = 0;
        private int id_producto;
        public ModalRegistrarPedido()
        {
            InitializeComponent();
            clienteServices = new ClienteServices();
            LbClientes.Visible = false;
            dgvConceptosPedido.RowTemplate.Height = 30;
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
                id_cliente = cliente.ID_Cliente;
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
                dgvConceptosPedido.Rows.Add(producto.id, producto.Nombre, producto.Cantidad ,producto.Precio , producto.Precio * producto.Cantidad);
                total += (producto.Cantidad * producto.Precio);
                txtTotal.Texts = total.ToString();
            };
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Obtener los detalles del DataGridView
            List<Parametro> parametros = ObtenerDetallesDesdeDataGridView(dgvConceptosPedido);

            // Agregar otros parámetros si es necesario
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
            var respuesta = Repositorio.EjecutarProcedimiento("CrearPedidoConDetalles", parametros);

            // Verificar si la ejecución fue exitosa
            if (respuesta.Success)
            {
                MessageBox.Show("Pedido creado exitosamente");
                this.DialogResult= DialogResult.OK;
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


    }
}
