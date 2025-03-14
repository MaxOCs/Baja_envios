using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Sistema_Envios.Models;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_Envios.Views
{
    public partial class FomularioProductos : Form
    {
        private Repositorio _repositorio;
        private AlmacenServices _alamcenservices;
        public FomularioProductos()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            _alamcenservices = new AlmacenServices();

            // Configurar el estilo del encabezado de las columnas
            dgvProductosCatalogo.EnableHeadersVisualStyles = false;

            // Crear columna de botones para las acciones (Actualizar y Eliminar)
            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.HeaderText = "Actualizar";
            updateButtonColumn.Name = "updateButton";
            updateButtonColumn.Text = "Actualizar";
            updateButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewImageColumn deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Name = "deleteButton";

            // Agregar las columnas de botones al DataGridView
            dgvProductosCatalogo.Columns.Add(updateButtonColumn);
            dgvProductosCatalogo.Columns.Add(deleteButtonColumn);


            // Cargar los productos y almacenes
            CargarProdutos();
            CargarAlmacenes();

            foreach (DataGridViewRow row in dgvProductosCatalogo.Rows)
            {
                // Crear un botón de FontAwesome
                var icon = IconChar.Trash;  // Icono de "papelera de reciclaje"
                var iconImage = CreateIconImage(icon, 16); // 16 es el tamaño del icono, puedes ajustarlo

                // Asignar el icono a la celda correspondiente
                row.Cells["deleteButton"].Value = iconImage;  // Asignamos el icono a la celda de la columna de imagen
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CargarProdutos()
        {
            string consulta = "select P.Nombre as Nombre, P.Descripcion, P.Dimensiones,P.Precio,P.stock,A.Nombre as Almacen FROM Producto P\r\ninner join Almacen A on P.ID_Almacen = A.ID_Almacen";
            DataTable dt = _repositorio.EjecutarConsulta(consulta);
            // Mostrar los datos en un DataGridView (por ejemplo)

            // Recorrer las filas del DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Crear un nuevo índice de fila en el DataGridView
                int rowIndex = dgvProductosCatalogo.Rows.Add();

                // Asignar los valores manualmente a cada celda
                dgvProductosCatalogo.Rows[rowIndex].Cells["Nombre"].Value = row["Nombre"];
                dgvProductosCatalogo.Rows[rowIndex].Cells["Descripcion"].Value = row["Descripcion"];
                dgvProductosCatalogo.Rows[rowIndex].Cells["Dimensiones"].Value = row["Dimensiones"];
                dgvProductosCatalogo.Rows[rowIndex].Cells["Precio"].Value = row["Precio"];
                dgvProductosCatalogo.Rows[rowIndex].Cells["stock"].Value = row["stock"];
                dgvProductosCatalogo.Rows[rowIndex].Cells["Almacen"].Value = row["Almacen"];
            }
        }


        private void InserProduct()
        {
            // Verificar que haya un almacén seleccionado
            if (cbAlmacenes.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un almacén antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que ningún campo esté vacío
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Texts) ||
                string.IsNullOrWhiteSpace(txtDescription.Texts) ||
                string.IsNullOrWhiteSpace(txtDimenciones.Texts) ||
                string.IsNullOrWhiteSpace(txtCantidad.Texts) ||
                string.IsNullOrWhiteSpace(txtPrecio.Texts))
            {
                MessageBox.Show("Rellena todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Producto newproducto = new Producto
                {
                    ID_Almacen = Convert.ToInt32(cbAlmacenes.SelectedValue),
                    Nombre = txtNombreProducto.Texts,
                    Descripcion = txtDescription.Texts,
                    Dimensiones = txtDimenciones.Texts,
                    stock = Convert.ToInt32(txtCantidad.Texts),
                    Precio = Convert.ToDecimal(txtPrecio.Texts),
                };

                // Capturar la respuesta del método Agregar
                response respuesta = Producto.Agregar(newproducto);

                // Mostrar el mensaje de respuesta
                MessageBox.Show(respuesta.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Verifica que los campos de cantidad y precio sean valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarAlmacenes()
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los almacenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            InserProduct();
            CargarProdutos();
        }

        private void dgvProductosCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Verificar que no sea un encabezado
            {
                if (dgvProductosCatalogo.Columns[e.ColumnIndex].Name == "updateButton")
                {
                    // Obtener el ID del producto (o cualquier otra propiedad que necesites)
                    var productoId = dgvProductosCatalogo.Rows[e.RowIndex].Cells[0].Value;
                    MessageBox.Show("Actualizar producto con ID: " + productoId);
                    // Aquí puedes poner la lógica para actualizar el producto
                }
                else if (dgvProductosCatalogo.Columns[e.ColumnIndex].Name == "deleteButton")
                {
                    // Obtener el ID del producto
                    var productoId = dgvProductosCatalogo.Rows[e.RowIndex].Cells[0].Value;
                    MessageBox.Show("Eliminar producto con ID: " + productoId);
                    // Aquí puedes poner la lógica para eliminar el producto
                }
            }
        }
    }
}
