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

namespace Sistema_Envios.Views
{
    public partial class Crud_Pedidos : Form
    {
        public Crud_Pedidos()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
          ModalRegistrarPedido modal = new ModalRegistrarPedido();
            modal.StartPosition = FormStartPosition.CenterParent;
            modal.ShowDialog();   
        }
    }
}
