using Sistema_Envios.Data;
using Sistema_Envios.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Envios.Views
{
    public partial class Crud_Envios : Form
    {
        Repositorio repositorio = new Repositorio();
        public Crud_Envios()
        {
            InitializeComponent();
            dgvCatalogoEnvios.EnableHeadersVisualStyles = false;
            dgvCatalogoEnvios.RowTemplate.Height = 30;
            Cargar_Envios();
        }

        private void Crud_Envios_Load(object sender, EventArgs e)
        {

        }

        private void Cargar_Envios()
        {
            // Consulta SQL
            string consulta = @"
        SELECT 
            E.ID_Envio AS Folio,
            EM.Nombre AS Nombre_Empleado,
            V.Tipo AS Tipo_Vehiculo,
            V.Placa,
            Cli.Direccion AS Direccion_Cliente,
            E.Fecha_Envio,
            E.Estado_Envio,
            E.Fecha_Estimada_Entrega,
            E.Fecha_Real_Entrega,
            E.Numero_Guia
        FROM 
            Envio E
        INNER JOIN 
            Empleado EM ON E.ID_Empleado = EM.ID_Empleado
        INNER JOIN 
            Vehiculo V ON V.ID_Vehiculo = E.ID_Vehiculo
        INNER JOIN 
            Pedido Pd ON Pd.ID_Pedido = E.ID_Pedido
        INNER JOIN 
            Cliente Cli ON Cli.ID_Cliente = Pd.ID_Cliente;
    ";

            // Ejecutar la consulta y obtener los resultados en un DataTable
            DataTable dt = repositorio.EjecutarConsulta(consulta);

            // Limpiar el DataGridView
            dgvCatalogoEnvios.Rows.Clear();

            // Recorrer cada fila del DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Agregar una nueva fila al DataGridView
                int rowIndex = dgvCatalogoEnvios.Rows.Add();

                // Crear el objeto Envio con los campos necesarios
                var envio = new Envio
                {
                    ID_Envio = row["Folio"] == DBNull.Value ? 0 : Convert.ToInt32(row["Folio"]),
                    Numero_Guia = row["Numero_Guia"] == DBNull.Value ? string.Empty : row["Numero_Guia"].ToString(),
                    Estado_Envio = row["Estado_Envio"] == DBNull.Value ? string.Empty : row["Estado_Envio"].ToString(),
                    Fecha_envio = row["Fecha_Envio"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Fecha_Envio"]),
                    Fecha_Estimada_Entrega = row["Fecha_Estimada_Entrega"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Fecha_Estimada_Entrega"]),
                    Fecha_Real_Entrega = row["Fecha_Real_Entrega"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(row["Fecha_Real_Entrega"])
                };

                // Asignar el objeto Envio al Tag de la fila
                dgvCatalogoEnvios.Rows[rowIndex].Tag = envio;

                // Asignar los valores de la consulta a las celdas del DataGridView
                dgvCatalogoEnvios.Rows[rowIndex].Cells["ID_Envio"].Value = envio.ID_Envio;
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Nombre"].Value = row["Nombre_Empleado"].ToString();
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Tipo"].Value = row["Tipo_Vehiculo"].ToString();
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Placa"].Value = row["Placa"].ToString();
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Dereccion"].Value = row["Direccion_Cliente"].ToString();
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Fecha_Envio"].Value = envio.Fecha_envio.ToString("yyyy-MM-dd");
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Estado_Envio"].Value = envio.Estado_Envio;
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Fecha_Estimada_Entrega"].Value = envio.Fecha_Estimada_Entrega == DateTime.MinValue ? "" : envio.Fecha_Estimada_Entrega.ToString("yyyy-MM-dd");
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Fecha_Real_Entrega"].Value = envio.Fecha_Real_Entrega == DateTime.MinValue ? "" : envio.Fecha_Real_Entrega.ToString("yyyy-MM-dd");
                dgvCatalogoEnvios.Rows[rowIndex].Cells["Numero_Guia"].Value = envio.Numero_Guia;
            }
        }
    }
}
