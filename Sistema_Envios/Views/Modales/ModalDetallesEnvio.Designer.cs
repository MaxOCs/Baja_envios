namespace Sistema_Envios.Views.Modales
{
    partial class ModalDetallesEnvio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new Sistema_Envios.Componentes.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmpleados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVehiculos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolioPedido = new Sistema_Envios.Componentes.RJTextBox();
            this.dgvConceptosPedido = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new Sistema_Envios.Componentes.RJButton();
            this.btnActualizar = new Sistema_Envios.Componentes.RJButton();
            this.txtCliente = new Sistema_Envios.Componentes.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(672, 35);
            this.panel1.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detalle Pedido";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(551, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "#Folio Pedio";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDireccion.BorderSize = 1;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(273, 85);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(386, 31);
            this.txtDireccion.TabIndex = 68;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(269, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 67;
            this.label2.Text = "Dirección Envio";
            // 
            // cbEmpleados
            // 
            this.cbEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEmpleados.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpleados.FormattingEnabled = true;
            this.cbEmpleados.Location = new System.Drawing.Point(29, 173);
            this.cbEmpleados.Name = "cbEmpleados";
            this.cbEmpleados.Size = new System.Drawing.Size(219, 28);
            this.cbEmpleados.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Chofer";
            // 
            // cbVehiculos
            // 
            this.cbVehiculos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVehiculos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculos.FormattingEnabled = true;
            this.cbVehiculos.Location = new System.Drawing.Point(273, 170);
            this.cbVehiculos.Name = "cbVehiculos";
            this.cbVehiculos.Size = new System.Drawing.Size(243, 28);
            this.cbVehiculos.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(269, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Vehiculo";
            // 
            // txtFolioPedido
            // 
            this.txtFolioPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolioPedido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFolioPedido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtFolioPedido.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtFolioPedido.BorderSize = 1;
            this.txtFolioPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolioPedido.ForeColor = System.Drawing.Color.Black;
            this.txtFolioPedido.Location = new System.Drawing.Point(556, 170);
            this.txtFolioPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolioPedido.Multiline = false;
            this.txtFolioPedido.Name = "txtFolioPedido";
            this.txtFolioPedido.Padding = new System.Windows.Forms.Padding(7);
            this.txtFolioPedido.PasswordChar = false;
            this.txtFolioPedido.ReadOnly = true;
            this.txtFolioPedido.Size = new System.Drawing.Size(103, 31);
            this.txtFolioPedido.TabIndex = 70;
            this.txtFolioPedido.Texts = "";
            this.txtFolioPedido.UnderlinedStyle = false;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConceptosPedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConceptosPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConceptosPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad,
            this.Subtotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptosPedido.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConceptosPedido.Location = new System.Drawing.Point(29, 267);
            this.dgvConceptosPedido.Name = "dgvConceptosPedido";
            this.dgvConceptosPedido.ReadOnly = true;
            this.dgvConceptosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConceptosPedido.RowHeadersVisible = false;
            this.dgvConceptosPedido.Size = new System.Drawing.Size(630, 145);
            this.dgvConceptosPedido.TabIndex = 72;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Detalles";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(396, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 38);
            this.btnCancel.TabIndex = 74;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnActualizar.BorderRadius = 15;
            this.btnActualizar.BorderSize = 0;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(539, 439);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(120, 38);
            this.btnActualizar.TabIndex = 73;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.White;
            this.txtCliente.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtCliente.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCliente.BorderSize = 1;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.Location = new System.Drawing.Point(29, 85);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCliente.Multiline = false;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Padding = new System.Windows.Forms.Padding(7);
            this.txtCliente.PasswordChar = false;
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(219, 31);
            this.txtCliente.TabIndex = 76;
            this.txtCliente.Texts = "";
            this.txtCliente.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Cliente";
            // 
            // ModalDetallesEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(672, 507);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvConceptosPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFolioPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVehiculos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "ModalDetallesEnvio";
            this.Text = "ModalDetallesEnvio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private Componentes.RJTextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVehiculos;
        private System.Windows.Forms.Label label5;
        private Componentes.RJTextBox txtFolioPedido;
        private System.Windows.Forms.DataGridView dgvConceptosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label4;
        private Componentes.RJButton btnCancel;
        private Componentes.RJButton btnActualizar;
        private Componentes.RJTextBox txtCliente;
        private System.Windows.Forms.Label label7;
    }
}