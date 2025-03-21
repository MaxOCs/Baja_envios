using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Envios.Views.Modales;
using Sistema_Envios.Data;
using Sistema_Envios.Models;
using Sistema_Envios.Views.ModalesProductos;

namespace Sistema_Envios.Views
{
    public partial class Crud_Pedidos : Form
    {
        Repositorio repositorio = new Repositorio();
        public Crud_Pedidos()
        {
            InitializeComponent();

            // Configurar el estilo del encabezado de las columnas
            dgvCatalogoPedidos.EnableHeadersVisualStyles = false;
            dgvCatalogoPedidos.RowTemplate.Height = 30;
            CargarCatalogo();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
          ModalRegistrarPedido modal = new ModalRegistrarPedido();
            modal.StartPosition = FormStartPosition.CenterParent;
            // Mostrar el modal y verificar si se cerró con OK
            if (modal.ShowDialog() == DialogResult.OK)
            {
                // Si se cierra con OK, ejecutar CargarCatalogo()
                CargarCatalogo();
            }
        }

        public void CargarCatalogo()
        {
            string consulta = "select P.ID_Pedido, C.Nombre , C.Telefono , P.Estado_Pedido AS Estado, P.Total, P.Fecha_Pedido from Pedido P inner join Cliente C on P.ID_Cliente  = C.ID_Cliente;";
            DataTable dt = repositorio.EjecutarConsulta(consulta);
            dgvCatalogoPedidos.Rows.Clear();


            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvCatalogoPedidos.Rows.Add();

                var pedido = new Pedido
                {
                    ID_Pedido = row["ID_Pedido"] == DBNull.Value ? 0 : Convert.ToInt32(row["ID_Pedido"]),
                    Nombre_cliente = row["Nombre"] == DBNull.Value ? string.Empty : row["Nombre"].ToString(),
                    telefono = row["Telefono"] == DBNull.Value ? string.Empty : row["Telefono"].ToString(),
                    Estado_Pedido = row["Estado"] == DBNull.Value ? string.Empty : row["Estado"].ToString(),
                    Total = row["Total"] == DBNull.Value ? 0 : Convert.ToDecimal(row["Total"]),
                    Fecha_pedido = row["Fecha_Pedido"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Fecha_Pedido"])  // Asignación de fecha
                };

                dgvCatalogoPedidos.Rows[rowIndex].Tag = pedido; // Almacena el objeto en la fila

                // Asignación a las celdas
                dgvCatalogoPedidos.Rows[rowIndex].Cells["ID_Pedido"].Value = pedido.ID_Pedido;
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Cliente"].Value = pedido.Nombre_cliente;
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Telefono"].Value = pedido.telefono;
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Estado"].Value = pedido.Estado_Pedido;
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Total"].Value = pedido.Total;
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Fecha"].Value = pedido.Fecha_pedido == DateTime.MinValue ? "" : pedido.Fecha_pedido.ToString("yyyy-MM-dd"); // Formateo de fecha
            }
        }

        private void dgvCatalogoPedidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCatalogoPedidos.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                string estado = e.Value.ToString();
                switch (estado)
                {
                    case "En Proceso":
                        e.CellStyle.BackColor = Color.FromArgb(23, 47, 122);
                        break;
                    case "Pendiente":
                        e.CellStyle.BackColor = Color.FromArgb (134, 25, 40);
                        break;
                    case "Completado":
                        e.CellStyle.BackColor = Color.FromArgb(20, 93, 24);
                        break;
                    default:
                        e.CellStyle.BackColor = Color.White;
                        break;
                }
            }
        }

        private void Crud_Pedidos_Load(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de mensaje con las opciones "Sí" y "No"
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar este pedido?",
                                                     "Confirmación de eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Si el usuario hace clic en "Sí", ejecutamos la acción de eliminar
            if (resultado == DialogResult.Yes)
            {
                if (dgvCatalogoPedidos.SelectedCells.Count > 0)
                {
                    DataGridViewCell selectedCell = dgvCatalogoPedidos.SelectedCells[0];

                    int rowIndex = selectedCell.RowIndex;

                    var pedido = (Pedido)dgvCatalogoPedidos.Rows[rowIndex].Tag;

                    // Verifica si el producto fue encontrado
                    if (pedido != null)
                    {
                        EliminarPedido(pedido.ID_Pedido);
                        CargarCatalogo();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el pedido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una celda para editar.");
                }
            }
        }
        public void EliminarPedido(int id)
        {
            Pedido.EliminarPedido(id);
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya seleccionado al menos una celda
            if (dgvCatalogoPedidos.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvCatalogoPedidos.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;

                var pedido  = (Pedido)dgvCatalogoPedidos.Rows[rowIndex].Tag;

                // Verifica si el producto fue encontrado
                if (pedido != null)
                {

                    ModalActualizarEstadoPedido modal = new ModalActualizarEstadoPedido();
                    modal.ID_Pedido = pedido.ID_Pedido;  
                    modal.StartPosition = FormStartPosition.CenterParent;
                    modal.CargarInformacion();
                    if (modal.ShowDialog() == DialogResult.OK)
                    {
                        CargarCatalogo();
                    }

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

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (dgvCatalogoPedidos.SelectedCells.Count > 0)
            {
                DataGridViewCell selectedCell = dgvCatalogoPedidos.SelectedCells[0];

                int rowIndex = selectedCell.RowIndex;

                var pedido = (Pedido)dgvCatalogoPedidos.Rows[rowIndex].Tag;

                if (pedido != null)
                {
                    ModalDetallesPedido modal = new ModalDetallesPedido(pedido);
                    modal.StartPosition = FormStartPosition.CenterParent;
                    modal.CargarInformacion();
                    if (modal.ShowDialog() == DialogResult.OK)
                    {
                        CargarCatalogo();
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un envío válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
