namespace CapaPresentacion
{
    partial class frmCategoria
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
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label9 = new Label();
            txtid = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            dgvdata = new DataGridView();
            seleccion = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtCategoria = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtindice = new TextBox();
            btnlimpiarbuscador1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnlimpiarbuscador
            // 
            btnlimpiarbuscador.BackColor = Color.White;
            btnlimpiarbuscador.Cursor = Cursors.Hand;
            btnlimpiarbuscador.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador.ForeColor = Color.White;
            btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador.IconColor = Color.Black;
            btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador.IconSize = 15;
            btnlimpiarbuscador.Location = new Point(1021, -233);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(41, 23);
            btnlimpiarbuscador.TabIndex = 45;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(803, 30);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 23);
            txtbusqueda.TabIndex = 43;
            // 
            // cbbusqueda
            // 
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(597, 30);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(200, 23);
            cbbusqueda.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(516, 36);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 41;
            label9.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(133, 0);
            txtid.Name = "txtid";
            txtid.Size = new Size(36, 23);
            txtid.TabIndex = 40;
            txtid.Text = "0";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuscar.IconSize = 15;
            btnBuscar.Location = new Point(974, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 23);
            btnBuscar.TabIndex = 44;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(204, 14);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(871, 54);
            label8.TabIndex = 39;
            label8.Text = "Categorias registradas";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { seleccion, Id, Categoria });
            dgvdata.Location = new Point(204, 81);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(770, 252);
            dgvdata.TabIndex = 38;
            dgvdata.CellClick += dgvdata_CellClick;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellPainting += dgvdata_CellPainting;
            // 
            // seleccion
            // 
            seleccion.DataPropertyName = "seleccion";
            seleccion.HeaderText = "";
            seleccion.Name = "seleccion";
            seleccion.ReadOnly = true;
            seleccion.Width = 50;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 200;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 250;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(17, 25);
            label7.Name = "label7";
            label7.Size = new Size(103, 28);
            label7.TabIndex = 37;
            label7.Text = "Categoria";
            label7.Click += label7_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Cursor = Cursors.Hand;
            btneliminar.FlatAppearance.BorderColor = Color.Black;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.ForeColor = Color.White;
            btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btneliminar.IconColor = Color.Black;
            btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneliminar.Location = new Point(17, 186);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(152, 23);
            btneliminar.TabIndex = 36;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.Blue;
            btnlimpiar.Cursor = Cursors.Hand;
            btnlimpiar.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar.FlatStyle = FlatStyle.Flat;
            btnlimpiar.ForeColor = Color.White;
            btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnlimpiar.IconColor = Color.Black;
            btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiar.Location = new Point(17, 157);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(152, 23);
            btnlimpiar.TabIndex = 35;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Green;
            btnguardar.Cursor = Cursors.Hand;
            btnguardar.FlatAppearance.BorderColor = Color.Black;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.ForeColor = Color.White;
            btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnguardar.IconColor = Color.White;
            btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnguardar.Location = new Point(17, 128);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(152, 23);
            btnguardar.TabIndex = 34;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(17, 81);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(155, 23);
            txtCategoria.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 63);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 28;
            label4.Text = "Nombre Categoria:";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 485);
            label1.TabIndex = 23;
            label1.Click += label1_Click;
            // 
            // txtindice
            // 
            txtindice.Location = new Point(84, 0);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(36, 23);
            txtindice.TabIndex = 46;
            txtindice.Text = "0";
            // 
            // btnlimpiarbuscador1
            // 
            btnlimpiarbuscador1.BackColor = Color.White;
            btnlimpiarbuscador1.Cursor = Cursors.Hand;
            btnlimpiarbuscador1.FlatAppearance.BorderColor = Color.Black;
            btnlimpiarbuscador1.FlatStyle = FlatStyle.Flat;
            btnlimpiarbuscador1.ForeColor = Color.White;
            btnlimpiarbuscador1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnlimpiarbuscador1.IconColor = Color.Black;
            btnlimpiarbuscador1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlimpiarbuscador1.IconSize = 15;
            btnlimpiarbuscador1.Location = new Point(1022, 29);
            btnlimpiarbuscador1.Name = "btnlimpiarbuscador1";
            btnlimpiarbuscador1.Size = new Size(41, 23);
            btnlimpiarbuscador1.TabIndex = 47;
            btnlimpiarbuscador1.UseVisualStyleBackColor = false;
            btnlimpiarbuscador1.Click += btnlimpiarbuscador1_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 485);
            Controls.Add(btnlimpiarbuscador1);
            Controls.Add(txtindice);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label9);
            Controls.Add(txtid);
            Controls.Add(btnBuscar);
            Controls.Add(label8);
            Controls.Add(dgvdata);
            Controls.Add(label7);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtCategoria);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            Load += frmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label9;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private Label label8;
        private DataGridView dgvdata;
        private Label label7;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private TextBox txtCategoria;
        private Label label4;
        private Label label1;
        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador1;
        private DataGridViewTextBoxColumn seleccion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Categoria;
    }
}