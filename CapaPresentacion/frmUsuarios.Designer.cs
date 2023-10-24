namespace CapaPresentacion
{
    partial class frmUsuarios
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreUsuario = new TextBox();
            txtClave = new TextBox();
            label4 = new Label();
            txtNombreCompleto = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtConfirmarClave = new TextBox();
            cbrol = new ComboBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btneliminar = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            dgvusuarios = new DataGridView();
            btnseleccionar = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contrasena = new DataGridViewTextBoxColumn();
            IdRol = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txtid = new TextBox();
            label9 = new Label();
            cbbusqueda = new ComboBox();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dgvusuarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 489);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(9, 120);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(9, 182);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(12, 138);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(155, 23);
            txtNombreUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 200);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(155, 23);
            txtClave.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(9, 58);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 5;
            label4.Text = "Nombre Completo";
            label4.Click += label4_Click;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(12, 76);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(155, 23);
            txtNombreCompleto.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(9, 289);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 7;
            label5.Text = "Rol";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(9, 236);
            label6.Name = "label6";
            label6.Size = new Size(124, 15);
            label6.TabIndex = 8;
            label6.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarClave
            // 
            txtConfirmarClave.Location = new Point(12, 254);
            txtConfirmarClave.Name = "txtConfirmarClave";
            txtConfirmarClave.PasswordChar = '*';
            txtConfirmarClave.Size = new Size(155, 23);
            txtConfirmarClave.TabIndex = 9;
            // 
            // cbrol
            // 
            cbrol.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrol.FormattingEnabled = true;
            cbrol.Location = new Point(12, 307);
            cbrol.Name = "cbrol";
            cbrol.Size = new Size(152, 23);
            cbrol.TabIndex = 10;
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
            btnguardar.Location = new Point(12, 385);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(152, 23);
            btnguardar.TabIndex = 11;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
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
            btnlimpiar.Location = new Point(12, 414);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(152, 23);
            btnlimpiar.TabIndex = 12;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
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
            btneliminar.Location = new Point(12, 443);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(152, 23);
            btneliminar.TabIndex = 13;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 20);
            label7.Name = "label7";
            label7.Size = new Size(84, 28);
            label7.TabIndex = 14;
            label7.Text = "Usuario";
            label7.Click += label7_Click;
            // 
            // dgvusuarios
            // 
            dgvusuarios.AllowUserToAddRows = false;
            dgvusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvusuarios.Columns.AddRange(new DataGridViewColumn[] { btnseleccionar, IdUsuario, Nombre, Usuario, Contrasena, IdRol, Rol });
            dgvusuarios.Location = new Point(199, 76);
            dgvusuarios.MultiSelect = false;
            dgvusuarios.Name = "dgvusuarios";
            dgvusuarios.ReadOnly = true;
            dgvusuarios.RowTemplate.Height = 25;
            dgvusuarios.Size = new Size(871, 390);
            dgvusuarios.TabIndex = 15;
            dgvusuarios.CellContentClick += dgvusuarios_CellContentClick;
            dgvusuarios.CellPainting += dgvusuarios_CellPainting;
            // 
            // btnseleccionar
            // 
            btnseleccionar.HeaderText = "";
            btnseleccionar.Name = "btnseleccionar";
            btnseleccionar.ReadOnly = true;
            btnseleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "Id_usuario";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Visible = false;
            IdUsuario.Width = 200;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 250;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 250;
            // 
            // Contrasena
            // 
            Contrasena.HeaderText = "Contraseña";
            Contrasena.Name = "Contrasena";
            Contrasena.ReadOnly = true;
            Contrasena.Visible = false;
            // 
            // IdRol
            // 
            IdRol.HeaderText = "IdRol";
            IdRol.Name = "IdRol";
            IdRol.ReadOnly = true;
            IdRol.Resizable = DataGridViewTriState.False;
            IdRol.Visible = false;
            // 
            // Rol
            // 
            Rol.HeaderText = "Rol";
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 150;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(199, 9);
            label8.Name = "label8";
            label8.Size = new Size(871, 54);
            label8.TabIndex = 16;
            label8.Text = "Usuarios registrados";
            // 
            // txtid
            // 
            txtid.Location = new Point(128, 25);
            txtid.Name = "txtid";
            txtid.Size = new Size(36, 23);
            txtid.TabIndex = 17;
            txtid.Text = "0";
            txtid.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(511, 31);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 18;
            label9.Text = "Buscar por:";
            label9.Click += label9_Click;
            // 
            // cbbusqueda
            // 
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(592, 25);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(200, 23);
            cbbusqueda.TabIndex = 19;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(798, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(969, 24);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(41, 23);
            iconButton1.TabIndex = 21;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.White;
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.FlatAppearance.BorderColor = Color.Black;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 15;
            iconButton2.Location = new Point(1016, 24);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(41, 23);
            iconButton2.TabIndex = 22;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1028, 489);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(textBox1);
            Controls.Add(cbbusqueda);
            Controls.Add(label9);
            Controls.Add(txtid);
            Controls.Add(label8);
            Controls.Add(dgvusuarios);
            Controls.Add(label7);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(cbrol);
            Controls.Add(txtConfirmarClave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombreCompleto);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvusuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreUsuario;
        private TextBox txtClave;
        private Label label4;
        private TextBox txtNombreCompleto;
        private Label label5;
        private Label label6;
        private TextBox txtConfirmarClave;
        private ComboBox cbrol;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private Label label7;
        private DataGridView dgvusuarios;
        private Label label8;
        private TextBox txtid;
        private Label label9;
        private ComboBox cbbusqueda;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private DataGridViewTextBoxColumn btnseleccionar;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contrasena;
        private DataGridViewTextBoxColumn IdRol;
        private DataGridViewTextBoxColumn Rol;
    }
}