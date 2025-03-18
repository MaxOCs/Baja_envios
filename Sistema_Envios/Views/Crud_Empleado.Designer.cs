namespace Sistema_Envios.Views
{
    partial class Crud_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnVer = new FontAwesome.Sharp.IconButton();
            this.BtnRegistrar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new FontAwesome.Sharp.IconButton();
            this.BtnModificar = new FontAwesome.Sharp.IconButton();
            this.dgvCatalogoEmpleado = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoEmpleado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnVer
            // 
            this.BtnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnVer.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnVer.FlatAppearance.BorderSize = 2;
            this.BtnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVer.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnVer.IconColor = System.Drawing.Color.White;
            this.BtnVer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnVer.IconSize = 27;
            this.BtnVer.Location = new System.Drawing.Point(0, 41);
            this.BtnVer.Name = "BtnVer";
            this.BtnVer.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BtnVer.Size = new System.Drawing.Size(129, 39);
            this.BtnVer.TabIndex = 42;
            this.BtnVer.Text = "Ver";
            this.BtnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVer.UseVisualStyleBackColor = false;
            this.BtnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRegistrar.FlatAppearance.BorderSize = 2;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnRegistrar.IconColor = System.Drawing.Color.White;
            this.BtnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistrar.IconSize = 27;
            this.BtnRegistrar.Location = new System.Drawing.Point(389, 41);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.BtnRegistrar.Size = new System.Drawing.Size(122, 39);
            this.BtnRegistrar.TabIndex = 41;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
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
            this.BtnEliminar.Location = new System.Drawing.Point(517, 41);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BtnEliminar.Size = new System.Drawing.Size(123, 39);
            this.BtnEliminar.TabIndex = 40;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            this.BtnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificar.FlatAppearance.BorderSize = 2;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnModificar.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.BtnModificar.IconColor = System.Drawing.Color.White;
            this.BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnModificar.IconSize = 27;
            this.BtnModificar.Location = new System.Drawing.Point(655, 41);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.BtnModificar.Size = new System.Drawing.Size(121, 39);
            this.BtnModificar.TabIndex = 39;
            this.BtnModificar.Text = "Editar";
            this.BtnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // dgvCatalogoEmpleado
            // 
            this.dgvCatalogoEmpleado.AllowUserToAddRows = false;
            this.dgvCatalogoEmpleado.AllowUserToDeleteRows = false;
            this.dgvCatalogoEmpleado.AllowUserToResizeRows = false;
            this.dgvCatalogoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogoEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogoEmpleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(93)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogoEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogoEmpleado.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCatalogoEmpleado.Location = new System.Drawing.Point(16, 123);
            this.dgvCatalogoEmpleado.Name = "dgvCatalogoEmpleado";
            this.dgvCatalogoEmpleado.ReadOnly = true;
            this.dgvCatalogoEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCatalogoEmpleado.RowHeadersVisible = false;
            this.dgvCatalogoEmpleado.Size = new System.Drawing.Size(760, 368);
            this.dgvCatalogoEmpleado.TabIndex = 38;
            this.dgvCatalogoEmpleado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogoEmpleado_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Catalogo Empleado";
            // 
            // Crud_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.BtnVer);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.dgvCatalogoEmpleado);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Crud_Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud_Empleado";
            this.Load += new System.EventHandler(this.Crud_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogoEmpleado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnVer;
        private FontAwesome.Sharp.IconButton BtnRegistrar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private System.Windows.Forms.DataGridView dgvCatalogoEmpleado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}