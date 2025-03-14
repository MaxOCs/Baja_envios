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
using Sistema_Envios.Views.ModalesProductos;

namespace Sistema_Envios.Views
{
    public partial class FomularioProductos : Form
    {
        private Repositorio _repositorio;
        private AlmacenServices _alamcenservices;
        private Dictionary<int, int> productoAlmacenDict = new Dictionary<int, int>();
        public FomularioProductos()
        {
            InitializeComponent();
            _repositorio = new Repositorio();
            _alamcenservices = new AlmacenServices();

            // Configurar el estilo del encabezado de las columnas
            dgvProductosCatalogo.EnableHeadersVisualStyles = false;

            // Cargar los productos y almacenes
            CargarProductos();
            CargarAlmacenes();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CargarProductos()
        {
            string consulta = "select P.Nombre as Nombre, P.Descripcion, P.Dimensiones, P.Precio, P.stock, A.Nombre as Almacen, A.ID_Almacen,P.ID_Producto FROM Producto P " +
                              "inner join Almacen A on P.ID_Almacen = A.ID_Almacen";
            DataTable dt = _repositorio.EjecutarConsulta(consulta);
            dgvProductosCatalogo.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {

                int rowIndex = dgvProductosCatalogo.Rows.Add();
                var producto = new Producto
                {
                    ID_Producto = row["ID_Producto"] == DBNull.Value ? 0 : Convert.ToInt32(row["ID_Producto"]),
                    Nombre = row["Nombre"] == DBNull.Value ? string.Empty : row["Nombre"].ToString(),
                    Descripcion = row["Descripcion"] == DBNull.Value ? string.Empty : row["Descripcion"].ToString(),
                    Dimensiones = row["Dimensiones"] == DBNull.Value ? string.Empty : row["Dimensiones"].ToString(),
                    Precio = row["Precio"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Precio"]),
                    stock = row["stock"] == DBNull.Value ? 0 : Convert.ToInt32(row["stock"]),
                    ID_Almacen = row["ID_Almacen"] == DBNull.Value ? 0 : Convert.ToInt32(row["ID_Almacen"])  // Aseguramos que no sea DBNull
                };

                dgvProductosCatalogo.Rows[rowIndex].Tag = producto;  // Guardamos el objeto en el Tag de la fila

                // Asignar los valores visibles en el DataGridView
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
            CargarProductos();
        }
      

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado al menos una celda
            if (dgvProductosCatalogo.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvProductosCatalogo.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;

                var producto = (Producto)dgvProductosCatalogo.Rows[rowIndex].Tag;

                // Verifica si el producto fue encontrado
                if (producto != null)
                {
                    ModalEditarProducto modal = new ModalEditarProducto();
                    modal.ItemId = producto.ID_Producto;  
                    modal.Almacen_id = producto.ID_Almacen;
                    modal.AbrirFormulario(); //Precarga los datos del producto
                    modal.CargarAlmacenes(); // carga la lista de almacenes  
                    modal.StartPosition = FormStartPosition.CenterParent;
                    modal.ProductoActualizado += CargarProductos;
                    modal.ShowDialog();  // Mostrar el modal
                    CargarProductos();

                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una celda para editar.");
            }
        }
    }
}
