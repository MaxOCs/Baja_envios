namespace Sistema_Envios.Views.Modales
{
    partial class ModalActualizarEstadoPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new Sistema_Envios.Componentes.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvConceptosPedido = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new Sistema_Envios.Componentes.RJButton();
            this.BtnRegistrarEnvio = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 35);
            this.panel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Iniciar pedido";
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehiculos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(388, 410);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(219, 28);
            this.cbVehiculos.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(384, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Vehiculo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Chofer";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmpleados.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(57, 410);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(219, 28);
            this.cbEmpleados.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(41, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtNombreCliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNombreCliente.BorderSize = 1;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCliente.Location = new System.Drawing.Point(44, 98);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Multiline = false;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Padding = new System.Windows.Forms.Padding(7);
            this.txtNombreCliente.PasswordChar = false;
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(245, 31);
            this.txtNombreCliente.TabIndex = 60;
            this.txtNombreCliente.Texts = "";
            this.txtNombreCliente.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Detalles";
            // 
            // dgvConceptosPedido
            // 
            this.dgvConceptosPedido.AllowUserToAddRows = false;
            this.dgvConceptosPedido.AllowUserToDeleteRows = false;
            this.dgvConceptosPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConceptosPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConceptosPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConceptosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptosPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConceptosPedido.Location = new System.Drawing.Point(45, 172);
            this.dgvConceptosPedido.Name = "dgvConceptosPedido";
            this.dgvConceptosPedido.ReadOnly = true;
            this.dgvConceptosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConceptosPedido.RowHeadersVisible = false;
            this.dgvConceptosPedido.Size = new System.Drawing.Size(596, 177);
            this.dgvConceptosPedido.TabIndex = 62;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(330, 465);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 38);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnRegistrarEnvio
            // 
            this.BtnRegistrarEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnRegistrarEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRegistrarEnvio.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistrarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarEnvio.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnRegistrarEnvio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrarEnvio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrarEnvio.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRegistrarEnvio.IconColor = System.Drawing.Color.White;
            this.BtnRegistrarEnvio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrarEnvio.IconSize = 23;
            this.BtnRegistrarEnvio.Location = new System.Drawing.Point(473, 465);
            this.BtnRegistrarEnvio.Name = "BtnRegistrarEnvio";
            this.BtnRegistrarEnvio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegistrarEnvio.Size = new System.Drawing.Size(173, 37);
            this.BtnRegistrarEnvio.TabIndex = 63;
            this.BtnRegistrarEnvio.Text = "Registar envio";
            this.BtnRegistrarEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrarEnvio.UseVisualStyleBackColor = false;
            this.BtnRegistrarEnvio.Click += new System.EventHandler(this.BtnRegistrarEnvio_Click);
            // 
            // ModalActualizarEstadoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(682, 515);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnRegistrarEnvio);
            this.Controls.Add(this.dgvConceptosPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalActualizarEstadoPedido";
            this.Text = "ModalActualizarEstadoPedido";
            this.Load += new System.EventHandler(this.ModalActualizarEstadoPedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label2;
        private Componentes.RJTextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvConceptosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private Componentes.RJButton btnCancelar;
        private FontAwesome.Sharp.IconButton BtnRegistrarEnvio;
    }
}