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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.cbrol = new System.Windows.Forms.ComboBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvusuarios = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbusqueda = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnseleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 489);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(12, 138);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(155, 23);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(12, 200);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(155, 23);
            this.txtClave.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre Completo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(12, 76);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(155, 23);
            this.txtNombreCompleto.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirmar Contraseña";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(12, 254);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(155, 23);
            this.txtConfirmarClave.TabIndex = 9;
            // 
            // cbrol
            // 
            this.cbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrol.FormattingEnabled = true;
            this.cbrol.Location = new System.Drawing.Point(12, 307);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(152, 23);
            this.cbrol.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Green;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(12, 385);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(152, 23);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.Blue;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneditar.IconColor = System.Drawing.Color.Black;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.Location = new System.Drawing.Point(12, 414);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(152, 23);
            this.btneditar.TabIndex = 12;
            this.btneditar.Text = "Editar";
            this.btneditar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Red;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btneliminar.IconColor = System.Drawing.Color.Black;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.Location = new System.Drawing.Point(12, 443);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(152, 23);
            this.btneliminar.TabIndex = 13;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Usuario";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dgvusuarios
            // 
            this.dgvusuarios.AllowUserToAddRows = false;
            this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnseleccionar,
            this.IdUsuario,
            this.Nombre,
            this.Usuario,
            this.Contrasena,
            this.IdRol,
            this.Rol});
            this.dgvusuarios.Location = new System.Drawing.Point(199, 76);
            this.dgvusuarios.MultiSelect = false;
            this.dgvusuarios.Name = "dgvusuarios";
            this.dgvusuarios.ReadOnly = true;
            this.dgvusuarios.RowTemplate.Height = 25;
            this.dgvusuarios.Size = new System.Drawing.Size(871, 390);
            this.dgvusuarios.TabIndex = 15;
            this.dgvusuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvusuarios_CellContentClick);
            this.dgvusuarios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvusuarios_CellPainting);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(199, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(871, 54);
            this.label8.TabIndex = 16;
            this.label8.Text = "Usuarios registrados";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(128, 25);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 23);
            this.txtid.TabIndex = 17;
            this.txtid.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(511, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buscar por:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cbbusqueda
            // 
            this.cbbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbusqueda.FormattingEnabled = true;
            this.cbbusqueda.Location = new System.Drawing.Point(592, 25);
            this.cbbusqueda.Name = "cbbusqueda";
            this.cbbusqueda.Size = new System.Drawing.Size(200, 23);
            this.cbbusqueda.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(798, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 15;
            this.iconButton1.Location = new System.Drawing.Point(969, 24);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(41, 23);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.White;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 15;
            this.iconButton2.Location = new System.Drawing.Point(1016, 24);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(41, 23);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.HeaderText = "";
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.ReadOnly = true;
            this.btnseleccionar.Width = 50;
            // 
            // IdUsuario
            // 
            this.IdUsuario.HeaderText = "Id_usuario";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Visible = false;
            this.IdUsuario.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 250;
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contraseña";
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.ReadOnly = true;
            this.Contrasena.Visible = false;
            // 
            // IdRol
            // 
            this.IdRol.HeaderText = "IdRol";
            this.IdRol.Name = "IdRol";
            this.IdRol.ReadOnly = true;
            this.IdRol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdRol.Visible = false;
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            this.Rol.Width = 150;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1082, 489);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbbusqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvusuarios);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbrol);
            this.Controls.Add(this.txtConfirmarClave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreCompleto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private FontAwesome.Sharp.IconButton btneditar;
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