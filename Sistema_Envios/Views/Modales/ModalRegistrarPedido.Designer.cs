namespace Sistema_Envios.Views.Modales
{
    partial class ModalRegistrarPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.dgvConceptosPedido = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.LbClientes = new System.Windows.Forms.ListBox();
            this.txtBuscarClientes = new Sistema_Envios.Componentes.RJTextBox();
            this.txtTotal = new Sistema_Envios.Componentes.RJTextBox();
            this.rjButton1 = new Sistema_Envios.Componentes.RJButton();
            this.txtTelefono = new Sistema_Envios.Componentes.RJTextBox();
            this.txtDireccion = new Sistema_Envios.Componentes.RJTextBox();
            this.btnEdit = new Sistema_Envios.Componentes.RJButton();
            this.btnEliminarConcepto = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(797, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Dirección";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(762, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.BtnAgregar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnAgregar.IconColor = System.Drawing.Color.White;
            this.BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregar.IconSize = 23;
            this.BtnAgregar.Location = new System.Drawing.Point(839, 185);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAgregar.Size = new System.Drawing.Size(123, 37);
            this.BtnAgregar.TabIndex = 50;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.id,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConceptosPedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConceptosPedido.Location = new System.Drawing.Point(32, 272);
            this.dgvConceptosPedido.Name = "dgvConceptosPedido";
            this.dgvConceptosPedido.ReadOnly = true;
            this.dgvConceptosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConceptosPedido.RowHeadersVisible = false;
            this.dgvConceptosPedido.Size = new System.Drawing.Size(930, 220);
            this.dgvConceptosPedido.TabIndex = 51;
            // 
            // id
            // 
            this.id.HeaderText = "Codigo";
            this.id.Name = "id";
            this.id.ReadOnly = true;
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
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(763, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Total";
            // 
            // LbClientes
            // 
            this.LbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbClientes.FormattingEnabled = true;
            this.LbClientes.ItemHeight = 20;
            this.LbClientes.Location = new System.Drawing.Point(27, 154);
            this.LbClientes.Name = "LbClientes";
            this.LbClientes.Size = new System.Drawing.Size(334, 24);
            this.LbClientes.TabIndex = 55;
            this.LbClientes.SelectedIndexChanged += new System.EventHandler(this.LbClientes_SelectedIndexChanged);
            // 
            // txtBuscarClientes
            // 
            this.txtBuscarClientes.BackColor = System.Drawing.SystemColors.Window;
            this.txtBuscarClientes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtBuscarClientes.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBuscarClientes.BorderSize = 1;
            this.txtBuscarClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarClientes.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarClientes.Location = new System.Drawing.Point(27, 123);
            this.txtBuscarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarClientes.Multiline = false;
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscarClientes.PasswordChar = false;
            this.txtBuscarClientes.ReadOnly = false;
            this.txtBuscarClientes.Size = new System.Drawing.Size(334, 31);
            this.txtBuscarClientes.TabIndex = 54;
            this.txtBuscarClientes.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarClientes.Texts = "";
            this.txtBuscarClientes.UnderlinedStyle = false;
            this.txtBuscarClientes._TextChanged += new System.EventHandler(this.txtBuscarClientes__TextChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtTotal.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTotal.BorderSize = 1;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(829, 529);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 31);
            this.txtTotal.TabIndex = 53;
            this.txtTotal.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = false;
            // 
            // rjButton1
            // 
            this.rjButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(7)))), ((int)(((byte)(19)))));
            this.rjButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.rjButton1.BorderRadius = 15;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(719, 593);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(120, 38);
            this.rjButton1.TabIndex = 49;
            this.rjButton1.Text = "Cancelar";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTelefono.BorderSize = 1;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(801, 123);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(161, 31);
            this.txtTelefono.TabIndex = 42;
            this.txtTelefono.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlinedStyle = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.txtDireccion.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDireccion.BorderSize = 1;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(392, 123);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(357, 31);
            this.txtDireccion.TabIndex = 41;
            this.txtDireccion.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnEdit.BorderRadius = 15;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(862, 593);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 38);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Registrar";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEliminarConcepto
            // 
            this.btnEliminarConcepto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarConcepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.btnEliminarConcepto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarConcepto.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEliminarConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarConcepto.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnEliminarConcepto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarConcepto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarConcepto.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminarConcepto.IconColor = System.Drawing.Color.White;
            this.btnEliminarConcepto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarConcepto.IconSize = 23;
            this.btnEliminarConcepto.Location = new System.Drawing.Point(697, 185);
            this.btnEliminarConcepto.Name = "btnEliminarConcepto";
            this.btnEliminarConcepto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarConcepto.Size = new System.Drawing.Size(123, 37);
            this.btnEliminarConcepto.TabIndex = 56;
            this.btnEliminarConcepto.Text = "Eliminar";
            this.btnEliminarConcepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarConcepto.UseVisualStyleBackColor = false;
            this.btnEliminarConcepto.Click += new System.EventHandler(this.btnEliminarConcepto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 35);
            this.panel1.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Registrar pedido";
            // 
            // ModalRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminarConcepto);
            this.Controls.Add(this.LbClientes);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConceptosPedido);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalRegistrarPedido";
            this.Text = "Registrar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Componentes.RJTextBox txtTelefono;
        private Componentes.RJTextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private Componentes.RJButton btnEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Componentes.RJButton rjButton1;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private System.Windows.Forms.DataGridView dgvConceptosPedido;
        private System.Windows.Forms.Label label2;
        private Componentes.RJTextBox txtTotal;
        private Componentes.RJTextBox txtBuscarClientes;
        private System.Windows.Forms.ListBox LbClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconButton btnEliminarConcepto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}