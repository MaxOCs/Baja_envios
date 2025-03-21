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
    public partial class ModalInicialEnvio : Form
    {
        public int ID_Envio { get; set; }
        public DateTime fecha_estimada { get; set; }
        public ModalInicialEnvio()
        {
            InitializeComponent();
           

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void precargar_fecha()
        {
            if(fecha_estimada == DateTime.MinValue)
            {
                fecha_estimada = DateTime.Now;
            }
            else
            {
                dtpFechaEstimada.Value = fecha_estimada;
            }
          
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Iniciar_Envio();

        }

        private void Iniciar_Envio()
        {
            // Verificar que el valor de dtpFechaEstimada no sea nulo
            if (dtpFechaEstimada.Value == null)
            {
                MessageBox.Show("La fecha estimada de entrega no puede estar vacía.");
                return;
            }

            // Crear el objeto Envio
            Envio newEnvio = new Envio
            {
                ID_Pedido = ID_Envio,
                Estado_Envio = cbEstados.Text.ToString(),
                Fecha_Estimada_Entrega = dtpFechaEstimada.Value, // Usar directamente el valor del DateTimePicker
            };

            MessageBox.Show("el id envio es " + ID_Envio);

            // Enviar el pedido
            response respuesta = Envio.Enviar_Pedido(newEnvio);
            // Verificar si la operación fue exitosa
            if (respuesta.Success) // Asumiendo que la clase "response" tiene una propiedad "Success"
            {
                Envio.GenerarGuia(ID_Envio);
                MessageBox.Show(respuesta.Message);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error al enviar el pedido: " + respuesta.Message);
            }
        }
    }
}
