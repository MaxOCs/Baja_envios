namespace Sistema_Envios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.BtnAlmacen = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.BtnVehiculos = new FontAwesome.Sharp.IconButton();
            this.BtnProducts = new FontAwesome.Sharp.IconButton();
            this.BtnPedidos = new FontAwesome.Sharp.IconButton();
            this.btnEnvios = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelNameDev = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panelMenu.Controls.Add(this.panelButtons);
            this.panelMenu.Controls.Add(this.PanelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 681);
            this.panelMenu.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.BtnAlmacen);
            this.panelButtons.Controls.Add(this.iconButton5);
            this.panelButtons.Controls.Add(this.BtnVehiculos);
            this.panelButtons.Controls.Add(this.BtnProducts);
            this.panelButtons.Controls.Add(this.BtnPedidos);
            this.panelButtons.Controls.Add(this.btnEnvios);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButtons.Location = new System.Drawing.Point(0, 150);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(250, 415);
            this.panelButtons.TabIndex = 1;
            // 
            // BtnAlmacen
            // 
            this.BtnAlmacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BtnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlmacen.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlmacen.ForeColor = System.Drawing.Color.White;
            this.BtnAlmacen.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.BtnAlmacen.IconColor = System.Drawing.Color.White;
            this.BtnAlmacen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAlmacen.Location = new System.Drawing.Point(0, 300);
            this.BtnAlmacen.Name = "BtnAlmacen";
            this.BtnAlmacen.Size = new System.Drawing.Size(250, 60);
            this.BtnAlmacen.TabIndex = 15;
            this.BtnAlmacen.Text = "Almacen";
            this.BtnAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlmacen.UseVisualStyleBackColor = false;
            this.BtnAlmacen.Click += new System.EventHandler(this.BtnAlmacen_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(0, 240);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(250, 60);
            this.iconButton5.TabIndex = 14;
            this.iconButton5.Text = "Clientes";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // BtnVehiculos
            // 
            this.BtnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BtnVehiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVehiculos.FlatAppearance.BorderSize = 0;
            this.BtnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVehiculos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVehiculos.ForeColor = System.Drawing.Color.White;
            this.BtnVehiculos.IconChar = FontAwesome.Sharp.IconChar.TruckFront;
            this.BtnVehiculos.IconColor = System.Drawing.Color.White;
            this.BtnVehiculos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVehiculos.Location = new System.Drawing.Point(0, 180);
            this.BtnVehiculos.Name = "BtnVehiculos";
            this.BtnVehiculos.Size = new System.Drawing.Size(250, 60);
            this.BtnVehiculos.TabIndex = 13;
            this.BtnVehiculos.Text = "Vehiculos";
            this.BtnVehiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVehiculos.UseVisualStyleBackColor = false;
            this.BtnVehiculos.Click += new System.EventHandler(this.BtnVehiculos_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.BtnProducts.IconColor = System.Drawing.Color.White;
            this.BtnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnProducts.Location = new System.Drawing.Point(0, 120);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(250, 60);
            this.BtnProducts.TabIndex = 12;
            this.BtnProducts.Text = "Productos";
            this.BtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProducts.UseVisualStyleBackColor = false;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click_1);
            // 
            // BtnPedidos
            // 
            this.BtnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.BtnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPedidos.FlatAppearance.BorderSize = 0;
            this.BtnPedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPedidos.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPedidos.ForeColor = System.Drawing.Color.White;
            this.BtnPedidos.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.BtnPedidos.IconColor = System.Drawing.Color.White;
            this.BtnPedidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPedidos.Location = new System.Drawing.Point(0, 60);
            this.BtnPedidos.Name = "BtnPedidos";
            this.BtnPedidos.Size = new System.Drawing.Size(250, 60);
            this.BtnPedidos.TabIndex = 11;
            this.BtnPedidos.Text = "Pedidos";
            this.BtnPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPedidos.UseVisualStyleBackColor = false;
            this.BtnPedidos.Click += new System.EventHandler(this.BtnPedidos_Click);
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnEnvios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnvios.FlatAppearance.BorderSize = 0;
            this.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvios.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ForeColor = System.Drawing.Color.White;
            this.btnEnvios.IconChar = FontAwesome.Sharp.IconChar.TruckFast;
            this.btnEnvios.IconColor = System.Drawing.Color.White;
            this.btnEnvios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEnvios.Location = new System.Drawing.Point(0, 0);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(250, 60);
            this.btnEnvios.TabIndex = 10;
            this.btnEnvios.Text = "Envios";
            this.btnEnvios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnvios.UseVisualStyleBackColor = false;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(250, 150);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.labelNameDev);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(250, 651);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 30);
            this.panel2.TabIndex = 5;
            // 
            // labelNameDev
            // 
            this.labelNameDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameDev.AutoSize = true;
            this.labelNameDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameDev.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNameDev.Location = new System.Drawing.Point(326, 3);
            this.labelNameDev.Name = "labelNameDev";
            this.labelNameDev.Size = new System.Drawing.Size(167, 20);
            this.labelNameDev.TabIndex = 0;
            this.labelNameDev.Text = "Maximiliano Ortiz 2025";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.LightGray;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1014, 651);
            this.panelChildForm.TabIndex = 6;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Sistema Envios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Componentes.RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton btnEnvios;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton BtnVehiculos;
        private FontAwesome.Sharp.IconButton BtnProducts;
        private FontAwesome.Sharp.IconButton BtnPedidos;
        private System.Windows.Forms.Label labelNameDev;
        private FontAwesome.Sharp.IconButton BtnAlmacen;
    }
}

