namespace Sistema_Envios.Views.Modales
{
    partial class ModalDetallesPedido
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
            this.btnEliminarConcepto = new FontAwesome.Sharp.IconButton();
            this.LbClientes = new System.Windows.Forms.ListBox();
            this.txtBuscarClientes = new Sistema_Envios.Componentes.RJTextBox();
            this.txtTotal = new Sistema_Envios.Componentes.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConceptosPedido = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new Sistema_Envios.Componentes.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new Sistema_Envios.Componentes.RJTextBox();
            this.txtDireccion = new Sistema_Envios.Componentes.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new Sistema_Envios.Componentes.RJButton();
            this.txtFolioPedido = new Sistema_Envios.Componentes.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(974, 35);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Detalles Pedido";
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
            this.btnEliminarConcepto.Location = new System.Drawing.Point(672, 197);
            this.btnEliminarConcepto.Name = "btnEliminarConcepto";
            this.btnEliminarConcepto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEliminarConcepto.Size = new System.Drawing.Size(123, 37);
            this.btnEliminarConcepto.TabIndex = 84;
            this.btnEliminarConcepto.Text = "Eliminar";
            this.btnEliminarConcepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarConcepto.UseVisualStyleBackColor = false;
            this.btnEliminarConcepto.Click += new System.EventHandler(this.btnEliminarConcepto_Click);
            // 
            // LbClientes
            // 
            this.LbClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbClientes.FormattingEnabled = true;
            this.LbClientes.ItemHeight = 20;
            this.LbClientes.Location = new System.Drawing.Point(16, 122);
            this.LbClientes.Name = "LbClientes";
            this.LbClientes.Size = new System.Drawing.Size(334, 24);
            this.LbClientes.TabIndex = 83;
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
            this.txtBuscarClientes.Location = new System.Drawing.Point(16, 91);
            this.txtBuscarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarClientes.Multiline = false;
            this.txtBuscarClientes.Name = "txtBuscarClientes";
            this.txtBuscarClientes.Padding = new System.Windows.Forms.Padding(7);
            this.txtBuscarClientes.PasswordChar = false;
            this.txtBuscarClientes.ReadOnly = false;
            this.txtBuscarClientes.Size = new System.Drawing.Size(334, 31);
            this.txtBuscarClientes.TabIndex = 82;
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
            this.txtTotal.Location = new System.Drawing.Point(781, 440);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Padding = new System.Windows.Forms.Padding(7);
            this.txtTotal.PasswordChar = false;
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(138, 31);
            this.txtTotal.TabIndex = 81;
            this.txtTotal.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotal.Texts = "";
            this.txtTotal.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(715, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 80;
            this.label2.Text = "Total";
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
            this.dgvConceptosPedido.Location = new System.Drawing.Point(20, 249);
            this.dgvConceptosPedido.Name = "dgvConceptosPedido";
            this.dgvConceptosPedido.ReadOnly = true;
            this.dgvConceptosPedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConceptosPedido.RowHeadersVisible = false;
            this.dgvConceptosPedido.Size = new System.Drawing.Size(917, 161);
            this.dgvConceptosPedido.TabIndex = 79;
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
            this.BtnAgregar.Location = new System.Drawing.Point(814, 197);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnAgregar.Size = new System.Drawing.Size(123, 37);
            this.BtnAgregar.TabIndex = 78;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(671, 504);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 77;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 71;
            this.label1.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(767, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Telefono";
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
            this.txtTelefono.Location = new System.Drawing.Point(771, 91);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(161, 31);
            this.txtTelefono.TabIndex = 76;
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
            this.txtDireccion.Location = new System.Drawing.Point(381, 91);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Padding = new System.Windows.Forms.Padding(7);
            this.txtDireccion.PasswordChar = false;
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(338, 31);
            this.txtDireccion.TabIndex = 75;
            this.txtDireccion.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDireccion.Texts = "";
            this.txtDireccion.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(377, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 73;
            this.label5.Text = "Dirección";
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
            this.btnEdit.Location = new System.Drawing.Point(814, 504);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 74;
            this.btnEdit.Text = "Actualizar";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.txtFolioPedido.Location = new System.Drawing.Point(21, 203);
            this.txtFolioPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolioPedido.Multiline = false;
            this.txtFolioPedido.Name = "txtFolioPedido";
            this.txtFolioPedido.Padding = new System.Windows.Forms.Padding(7);
            this.txtFolioPedido.PasswordChar = false;
            this.txtFolioPedido.ReadOnly = true;
            this.txtFolioPedido.Size = new System.Drawing.Size(103, 31);
            this.txtFolioPedido.TabIndex = 86;
            this.txtFolioPedido.TextAling = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFolioPedido.Texts = "";
            this.txtFolioPedido.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "#Folio Pedio";
            // 
            // ModalDetallesPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 590);
            this.Controls.Add(this.txtFolioPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEliminarConcepto);
            this.Controls.Add(this.LbClientes);
            this.Controls.Add(this.txtBuscarClientes);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConceptosPedido);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModalDetallesPedido";
            this.Text = "ModalDetallesPedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConceptosPedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton btnEliminarConcepto;
        private System.Windows.Forms.ListBox LbClientes;
        private Componentes.RJTextBox txtBuscarClientes;
        private Componentes.RJTextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConceptosPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private Componentes.RJButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Componentes.RJTextBox txtTelefono;
        private Componentes.RJTextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private Componentes.RJButton btnEdit;
        private Componentes.RJTextBox txtFolioPedido;
        private System.Windows.Forms.Label label4;
    }
}