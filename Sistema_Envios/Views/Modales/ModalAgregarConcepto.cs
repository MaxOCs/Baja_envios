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

namespace Sistema_Envios.Views.Modales
{
    public partial class ModalAgregarConcepto : Form
    {
        private ProductosServices producto_services;
        public class ProductoSeleccionado
        {
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
        }
        public ProductoSeleccionado Producto { get; private set; }

        public ModalAgregarConcepto()
        {
            InitializeComponent();
            nudCantidad.AutoSize = false;
            nudCantidad.Height = 37;
            producto_services= new ProductosServices();
            LbProductos.Visible = false;
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Texts))
            {
                txtNombreProducto.Texts = "Ingrese nombre de porducto"; // Texto de placeholder
                txtNombreProducto.ForeColor = Color.Gray; // Color del placeholder
            }
        }

        private void RemovePlaceholder()
        {
            if (txtNombreProducto.Texts == "Ingrese nombre de porducto")
            {
                txtNombreProducto.Texts = "";
                txtNombreProducto.ForeColor = Color.Black; // Color del texto normal
            }
        }

        private void txtNombreProducto_Enter(object sender, EventArgs e)
        {
            RemovePlaceholder();
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(nudCantidad.Value > 0 || txtNombreProducto.Texts == "")
            {
                Producto = new ProductoSeleccionado
                {
                    Nombre = txtNombreProducto.Texts,
                    Precio = Convert.ToDecimal(txtPrecio.Texts),
                    Cantidad = Convert.ToInt32(nudCantidad.Value)
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione un concepto");
            }
            
        }

        private void LbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LbProductos.SelectedItem != null)
            {
                string productoSeleccionado = LbProductos.SelectedItem.ToString();
                Producto producto = producto_services.BuscarProductoPorNombre(productoSeleccionado);
                txtNombreProducto.Texts = producto.Nombre.ToString();
                txtPrecio.Texts = producto.Precio.ToString();
                LbProductos.Visible = false;
            }
        }

        private void txtNombreProducto__TextChanged(object sender, EventArgs e)
        {
            string query = txtNombreProducto.Texts.Trim();

            if (string.IsNullOrEmpty(query))
            {
                LbProductos.Visible = false;
                txtPrecio.Texts = "";
                txtNombreProducto.Texts = "";
                LbProductos.Items.Clear();
                return;
            }
            LbProductos.Visible = true;
            // Llamamos a la función para realizar la búsqueda en la base de datos
            var produtos = producto_services.BuscarProcuto(query);

            // Limpiamos el ListBox y agregamos los resultados
            LbProductos.Items.Clear();
            foreach (var producto in produtos)
            {
                LbProductos.Items.Add(producto.Nombre);
            }
        }
    }
}
