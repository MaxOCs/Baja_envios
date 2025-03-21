namespace Sistema_Envios.Views
{
    partial class Crud_Envios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnEditar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnAcualizarEnvio = new FontAwesome.Sharp.IconButton();
            this.dgvCatalogoEnvios = new System.Windows.Forms.DataGridView();
            this.ID_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dereccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado_Envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Estimada_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Real_Entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Guia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoEnvios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 35);
            this.panel1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Catalogo Envios";
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEditar.FlatAppearance.BorderSize = 2;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEditar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnEditar.IconColor = System.Drawing.Color.White;
            this.BtnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEditar.IconSize = 27;
            this.BtnEditar.Location = new System.Drawing.Point(25, 50);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnEditar.Size = new System.Drawing.Size(142, 39);
            this.BtnEditar.TabIndex = 28;
            this.BtnEditar.Text = "Detalles";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnEliminar.FlatAppearance.BorderSize = 2;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnEliminar.IconColor = System.Drawing.Color.White;
            this.BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnEliminar.IconSize = 27;
            this.BtnEliminar.Location = new System.Drawing.Point(402, 50);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BtnEliminar.Size = new System.Drawing.Size(150, 39);
            this.BtnEliminar.TabIndex = 27;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAcualizarEnvio
            // 
            this.BtnAcualizarEnvio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAcualizarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnAcualizarEnvio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAcualizarEnvio.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAcualizarEnvio.FlatAppearance.BorderSize = 2;
            this.BtnAcualizarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcualizarEnvio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcualizarEnvio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAcualizarEnvio.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.BtnAcualizarEnvio.IconColor = System.Drawing.Color.White;
            this.BtnAcualizarEnvio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAcualizarEnvio.IconSize = 27;
            this.BtnAcualizarEnvio.Location = new System.Drawing.Point(558, 50);
            this.BtnAcualizarEnvio.Name = "BtnAcualizarEnvio";
            this.BtnAcualizarEnvio.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BtnAcualizarEnvio.Size = new System.Drawing.Size(239, 39);
            this.BtnAcualizarEnvio.TabIndex = 26;
            this.BtnAcualizarEnvio.Text = "Iniciar / Actualizar Envio";
            this.BtnAcualizarEnvio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAcualizarEnvio.UseVisualStyleBackColor = false;
            this.BtnAcualizarEnvio.Click += new System.EventHandler(this.BtnAcualizarEnvio_Click);
            // 
            // dgvCatalogoEnvios
            // 
            this.dgvCatalogoEnvios.AllowUserToAddRows = false;
            this.dgvCatalogoEnvios.AllowUserToDeleteRows = false;
            this.dgvCatalogoEnvios.AllowUserToResizeRows = false;
            this.dgvCatalogoEnvios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogoEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogoEnvios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoEnvios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogoEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogoEnvios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Envio,
            this.Nombre,
            this.Tipo,
            this.Placa,
            this.Dereccion,
            this.Fecha_Envio,
            this.Estado_Envio,
            this.Fecha_Estimada_Entrega,
            this.Fecha_Real_Entrega,
            this.Numero_Guia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoEnvios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogoEnvios.Location = new System.Drawing.Point(25, 119);
            this.dgvCatalogoEnvios.Name = "dgvCatalogoEnvios";
            this.dgvCatalogoEnvios.ReadOnly = true;
            this.dgvCatalogoEnvios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalogoEnvios.RowHeadersVisible = false;
            this.dgvCatalogoEnvios.Size = new System.Drawing.Size(815, 272);
            this.dgvCatalogoEnvios.TabIndex = 25;
            this.dgvCatalogoEnvios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCatalogoEnvios_CellFormatting);
            // 
            // ID_Envio
            // 
            this.ID_Envio.HeaderText = "#Folio";
            this.ID_Envio.Name = "ID_Envio";
            this.ID_Envio.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Chofer";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Vehiculo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Dereccion
            // 
            this.Dereccion.HeaderText = "Dirección";
            this.Dereccion.Name = "Dereccion";
            this.Dereccion.ReadOnly = true;
            // 
            // Fecha_Envio
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Fecha_Envio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fecha_Envio.HeaderText = "Fecha Envio";
            this.Fecha_Envio.Name = "Fecha_Envio";
            this.Fecha_Envio.ReadOnly = true;
            // 
            // Estado_Envio
            // 
            this.Estado_Envio.HeaderText = "Estado";
            this.Estado_Envio.Name = "Estado_Envio";
            this.Estado_Envio.ReadOnly = true;
            // 
            // Fecha_Estimada_Entrega
            // 
            this.Fecha_Estimada_Entrega.HeaderText = "Fecha entrega estimada";
            this.Fecha_Estimada_Entrega.Name = "Fecha_Estimada_Entrega";
            this.Fecha_Estimada_Entrega.ReadOnly = true;
            // 
            // Fecha_Real_Entrega
            // 
            this.Fecha_Real_Entrega.HeaderText = "Fecha de Entrega";
            this.Fecha_Real_Entrega.Name = "Fecha_Real_Entrega";
            this.Fecha_Real_Entrega.ReadOnly = true;
            // 
            // Numero_Guia
            // 
            this.Numero_Guia.HeaderText = "Guia";
            this.Numero_Guia.Name = "Numero_Guia";
            this.Numero_Guia.ReadOnly = true;
            // 
            // Crud_Envios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAcualizarEnvio);
            this.Controls.Add(this.dgvCatalogoEnvios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crud_Envios";
            this.Text = "Crud_Envios";
            this.Load += new System.EventHandler(this.Crud_Envios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoEnvios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton BtnEditar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnAcualizarEnvio;
        private System.Windows.Forms.DataGridView dgvCatalogoEnvios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dereccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado_Envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Estimada_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Real_Entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_Guia;
    }
}