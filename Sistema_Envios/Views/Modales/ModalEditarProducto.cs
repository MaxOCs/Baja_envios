using System;
using Sistema_Envios.Data;
using Sistema_Envios.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Envios.Views.ModalesProductos
{
    public partial class ModalEditarProducto : Form
    {
        private ProductosServices productos = new ProductosServices();
        private AlmacenServices _alamcenservices;
        public int ItemId { get; set; }
        public int Almacen_id { get; set; }
        public event Action ProductoActualizado;  // Evento para notificar que el producto ha sido actualizado

        public ModalEditarProducto()
        {
            InitializeComponent();
            _alamcenservices = new AlmacenServices();
        }

        // Método que se llama después de que se ha asignado el ItemId
        public void CargarDatosProducto()
        {
            try
            {
                // Obtener los datos del producto usando el ItemId
                Producto productoEdit = productos.ObtenerProductoPorId(ItemId);

                if (productoEdit != null)
                {
                    // Cargar los datos en los controles del formulario
                    txtNombreProducto.Texts = productoEdit.Nombre;
                    txtDescription.Texts = productoEdit.Descripcion;
                    txtCantidad.Texts = productoEdit.stock.ToString();
                    txtDimenciones.Texts = productoEdit.Dimensiones;
                    txtPrecio.Texts = productoEdit.Precio.ToString();
                }
                else
                {
                    MessageBox.Show("El producto no se pudo cargar.");
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones en caso de error al obtener los datos
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        // Este método puede ser llamado cuando sea necesario para cargar almacenes, si es necesario
        public void CargarAlmacenes()
        {
            try
            {
                var almacenes = _alamcenservices.ObtenerAlmacenes();

                // Validar que la lista no esté vacía o nula
                if (almacenes == null || almacenes.Count == 0)
                {
                    MessageBox.Show("No hay almacenes disponibles.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Asignar la lista al ComboBox
                cbAlmacenes.DataSource = almacenes;
                cbAlmacenes.DisplayMember = "Nombre";
                cbAlmacenes.ValueMember = "ID_Almacen";
                cbAlmacenes.SelectedValue = Almacen_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los almacenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AbrirFormulario()
        {
            // Llamamos a CargarDatos para llenar los campos cuando el formulario se abre
            CargarDatosProducto();
        }

        private void Actualizar()
        {
            try
            {
                Producto newproducto = new Producto
                {
                    ID_Producto = ItemId,
                    ID_Almacen = Convert.ToInt32(cbAlmacenes.SelectedValue),
                    Nombre = txtNombreProducto.Texts,
                    Descripcion = txtDescription.Texts,
                    Dimensiones = txtDimenciones.Texts,
                    stock = Convert.ToInt32(txtCantidad.Texts),
                    Precio = Convert.ToDecimal(txtPrecio.Texts),
                };

                // Capturar la respuesta del método Agregar
                response respuesta = Producto.Editar(newproducto);

                // Mostrar el mensaje de respuesta
                MessageBox.Show(respuesta.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que los campos de cantidad y precio sean valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Actualizar ();
            ProductoActualizado.Invoke();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalEditarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
