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
            modal.ShowDialog();   
        }

        public void CargarCatalogo()
        {
            string consulta = "select P.ID_Pedido, C.Nombre , C.Telefono , P.Estado_Pedido AS Estado, P.Total, P.Fecha_Pedido from Pedido P inner join Cliente C on P.ID_Cliente  = C.ID_Cliente;";
            DataTable dt = repositorio.EjecutarConsulta(consulta);
            dgvCatalogoPedidos.Rows.Clear();

            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvCatalogoPedidos.Rows.Add();
                dgvCatalogoPedidos.Rows[rowIndex].Cells["ID_Pedido"].Value = row["ID_Pedido"];
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Cliente"].Value = row["Nombre"];
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Telefono"].Value = row["Telefono"];
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Estado"].Value = row["Estado"];
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Total"].Value = row["Total"];
                dgvCatalogoPedidos.Rows[rowIndex].Cells["Fecha"].Value = row["Fecha_Pedido"];
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
    }
}
