using Sistema_Envios.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Envios.Views;

namespace Sistema_Envios
{
    public partial class Form1 : Form
    {
        CrearDB creardb = new CrearDB();
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearDB_Click(object sender, EventArgs e)
        {
            string mensaje = creardb.CrearBaseDeDatos();
            MessageBox.Show(mensaje, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            string mensaje = creardb.CreateTable();
            MessageBox.Show(mensaje, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = creardb.insertData();
            MessageBox.Show(mensaje, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null; 
        private void openChildForm(Form ChildForm)
        {
            if (activeForm!=null)
               activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel= false;
            ChildForm.FormBorderStyle= FormBorderStyle.None;
            ChildForm.Dock= DockStyle.Fill;
            panelChildForm.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();
            
        }

        private void BtnProducts_Click_1(object sender, EventArgs e)
        {
            openChildForm(new FomularioProductos());
        }
    }
}
