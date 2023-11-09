namespace CapaPresentacion
{
    partial class frmClientes
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
            txtindice = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label9 = new Label();
            txtid = new TextBox();
            label8 = new Label();
            btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            dgvdata = new DataGridView();
            seleccion = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cedula = new DataGridViewTextBoxColumn();
            Celular = new DataGridViewTextBoxColumn();
            Fecha_nacimiento = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Sexo_id = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            label7 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            cbsexo = new ComboBox();
            txtDireccion = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtNombreCompleto = new TextBox();
            label4 = new Label();
            txtCelular = new TextBox();
            txtCedula = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            txtFechaNacimiento = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtindice
            // 
            txtindice.Location = new Point(102, 28);
            txtindice.Name = "txtindice";
            txtindice.Size = new Size(36, 23);
            txtindice.TabIndex = 47;
            txtindice.Text = "0";
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
            btnBuscar.Location = new Point(971, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 23);
            btnBuscar.TabIndex = 45;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(800, 25);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 23);
            txtbusqueda.TabIndex = 44;
            // 
            // cbbusqueda
            // 
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(594, 25);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(200, 23);
            cbbusqueda.TabIndex = 43;
            cbbusqueda.SelectedIndexChanged += cbbusqueda_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(513, 31);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 42;
            label9.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(144, 28);
            txtid.Name = "txtid";
            txtid.Size = new Size(36, 23);
            txtid.TabIndex = 41;
            txtid.Text = "0";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(201, 9);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(871, 54);
            label8.TabIndex = 40;
            label8.Text = "Clientes";
            label8.TextAlign = ContentAlignment.MiddleLeft;
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
            btnlimpiarbuscador.Location = new Point(1018, 25);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(41, 23);
            btnlimpiarbuscador.TabIndex = 46;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            btnlimpiarbuscador.Click += btnlimpiarbuscador_Click;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.BackgroundColor = Color.White;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { seleccion, Id, Nombre, Cedula, Celular, Fecha_nacimiento, Direccion, Sexo_id, Sexo });
            dgvdata.Location = new Point(201, 76);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(871, 390);
            dgvdata.TabIndex = 39;
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
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Cedula
            // 
            Cedula.HeaderText = "Cedula";
            Cedula.Name = "Cedula";
            Cedula.ReadOnly = true;
            Cedula.Width = 250;
            // 
            // Celular
            // 
            Celular.HeaderText = "Celular";
            Celular.Name = "Celular";
            Celular.ReadOnly = true;
            // 
            // Fecha_nacimiento
            // 
            Fecha_nacimiento.HeaderText = "Fecha_nacimiento";
            Fecha_nacimiento.Name = "Fecha_nacimiento";
            Fecha_nacimiento.ReadOnly = true;
            Fecha_nacimiento.Visible = false;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Sexo_id
            // 
            Sexo_id.HeaderText = "Sexo_id";
            Sexo_id.Name = "Sexo_id";
            Sexo_id.ReadOnly = true;
            Sexo_id.Resizable = DataGridViewTriState.False;
            Sexo_id.Visible = false;
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            Sexo.ReadOnly = true;
            Sexo.Visible = false;
            Sexo.Width = 150;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 20);
            label7.Name = "label7";
            label7.Size = new Size(78, 28);
            label7.TabIndex = 38;
            label7.Text = "Cliente";
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
            btneliminar.Location = new Point(12, 453);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(152, 23);
            btneliminar.TabIndex = 37;
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
            btnlimpiar.Location = new Point(12, 424);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(152, 23);
            btnlimpiar.TabIndex = 36;
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
            btnguardar.Location = new Point(12, 395);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(152, 23);
            btnguardar.TabIndex = 35;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // cbsexo
            // 
            cbsexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsexo.FormattingEnabled = true;
            cbsexo.Location = new Point(12, 356);
            cbsexo.Name = "cbsexo";
            cbsexo.Size = new Size(152, 23);
            cbsexo.TabIndex = 34;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(14, 254);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(155, 23);
            txtDireccion.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(14, 236);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 32;
            label6.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(12, 338);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 31;
            label5.Text = "Sexo";
            label5.Click += label5_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(14, 76);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(155, 23);
            txtNombreCompleto.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(14, 58);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 29;
            label4.Text = "Nombre";
            label4.Click += label4_Click;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(14, 200);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(155, 23);
            txtCelular.TabIndex = 28;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(14, 138);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(155, 23);
            txtCedula.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(14, 182);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 26;
            label3.Text = "Celular";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(14, 120);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 25;
            label2.Text = "Cedula";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 484);
            label1.TabIndex = 24;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 308);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 49;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.AutoSize = true;
            txtFechaNacimiento.BackColor = Color.White;
            txtFechaNacimiento.Location = new Point(14, 290);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(117, 15);
            txtFechaNacimiento.TabIndex = 48;
            txtFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(155, 23);
            dateTimePicker1.TabIndex = 50;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 484);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(txtindice);
            Controls.Add(btnBuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label9);
            Controls.Add(txtid);
            Controls.Add(label8);
            Controls.Add(dgvdata);
            Controls.Add(label7);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(cbsexo);
            Controls.Add(txtDireccion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label4);
            Controls.Add(txtCelular);
            Controls.Add(txtCedula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmClientes";
            Load += frmClientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtindice;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label9;
        private TextBox txtid;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnlimpiarbuscador;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn seleccion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cedula;
        private DataGridViewTextBoxColumn Celular;
        private DataGridViewTextBoxColumn Fecha_nacimiento;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Sexo_id;
        private DataGridViewTextBoxColumn Sexo;
        private Label label7;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private ComboBox cbsexo;
        private TextBox txtDireccion;
        private Label label6;
        private Label label5;
        private TextBox txtNombreCompleto;
        private Label label4;
        private TextBox txtCelular;
        private TextBox txtCedula;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label txtFechaNacimiento;
        private DateTimePicker dateTimePicker1;
    }
}