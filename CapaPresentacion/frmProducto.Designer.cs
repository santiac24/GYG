namespace CapaPresentacion
{
    partial class frmProducto
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
            label7 = new Label();
            btneliminar = new FontAwesome.Sharp.IconButton();
            btnlimpiar = new FontAwesome.Sharp.IconButton();
            btnguardar = new FontAwesome.Sharp.IconButton();
            cbroltalla = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            txtnombreprenda = new TextBox();
            label4 = new Label();
            txtcantdisponible = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbrolcolor = new ComboBox();
            label10 = new Label();
            cbrolsubcategoria = new ComboBox();
            label11 = new Label();
            txtpreciocompra = new TextBox();
            txtprecioventa = new TextBox();
            btnlimpiar1 = new FontAwesome.Sharp.IconButton();
            seleccion = new DataGridViewTextBoxColumn();
            Id_prenda = new DataGridViewTextBoxColumn();
            Prenda = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_compra = new DataGridViewTextBoxColumn();
            Precio_venta = new DataGridViewTextBoxColumn();
            Subcategoria_id = new DataGridViewTextBoxColumn();
            Subcategoria = new DataGridViewTextBoxColumn();
            Talla_id = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            Color_id = new DataGridViewTextBoxColumn();
            Color = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // txtindice
            // 
            txtindice.Location = new Point(93, 9);
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
            btnBuscar.Location = new Point(976, 33);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 24);
            btnBuscar.TabIndex = 45;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(805, 34);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 23);
            txtbusqueda.TabIndex = 44;
            // 
            // cbbusqueda
            // 
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(599, 34);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(200, 23);
            cbbusqueda.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(518, 40);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 42;
            label9.Text = "Buscar por:";
            // 
            // txtid
            // 
            txtid.Location = new Point(138, 9);
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
            label8.Location = new Point(206, 18);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(871, 55);
            label8.TabIndex = 40;
            label8.Text = "Prendas registradas";
            label8.Click += label8_Click_1;
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
            btnlimpiarbuscador.Location = new Point(1023, 33);
            btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            btnlimpiarbuscador.Size = new Size(41, 24);
            btnlimpiarbuscador.TabIndex = 46;
            btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { seleccion, Id_prenda, Prenda, Cantidad, Precio_compra, Precio_venta, Subcategoria_id, Subcategoria, Talla_id, Talla, Color_id, Color });
            dgvdata.Location = new Point(221, 129);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(796, 333);
            dgvdata.TabIndex = 39;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(19, 29);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 38;
            label7.Text = "Prendas";
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
            btneliminar.Location = new Point(19, 536);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(152, 24);
            btneliminar.TabIndex = 37;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
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
            btnlimpiar.Location = new Point(19, 507);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(152, 24);
            btnlimpiar.TabIndex = 36;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
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
            btnguardar.Location = new Point(19, 478);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(152, 24);
            btnguardar.TabIndex = 35;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            // 
            // cbroltalla
            // 
            cbroltalla.DropDownStyle = ComboBoxStyle.DropDownList;
            cbroltalla.FormattingEnabled = true;
            cbroltalla.Location = new Point(19, 316);
            cbroltalla.Name = "cbroltalla";
            cbroltalla.Size = new Size(152, 23);
            cbroltalla.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Location = new Point(16, 245);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 32;
            label6.Text = "Precio de venta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Location = new Point(16, 298);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 31;
            label5.Text = "Talla";
            // 
            // txtnombreprenda
            // 
            txtnombreprenda.Location = new Point(19, 85);
            txtnombreprenda.Name = "txtnombreprenda";
            txtnombreprenda.Size = new Size(155, 23);
            txtnombreprenda.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(16, 67);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 29;
            label4.Text = "Nombre de la prenda";
            label4.Click += label4_Click;
            // 
            // txtcantdisponible
            // 
            txtcantdisponible.Location = new Point(19, 147);
            txtcantdisponible.Name = "txtcantdisponible";
            txtcantdisponible.Size = new Size(155, 23);
            txtcantdisponible.TabIndex = 27;
            txtcantdisponible.Text = "0";
            txtcantdisponible.KeyPress += txtcantdisponible_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(16, 191);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 26;
            label3.Text = "Precio de compra";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(16, 129);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 25;
            label2.Text = "Cant. Disponible";
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 599);
            label1.TabIndex = 24;
            // 
            // cbrolcolor
            // 
            cbrolcolor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrolcolor.FormattingEnabled = true;
            cbrolcolor.Location = new Point(22, 368);
            cbrolcolor.Name = "cbrolcolor";
            cbrolcolor.Size = new Size(152, 23);
            cbrolcolor.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Location = new Point(19, 350);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 48;
            label10.Text = "Color";
            // 
            // cbrolsubcategoria
            // 
            cbrolsubcategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrolsubcategoria.FormattingEnabled = true;
            cbrolsubcategoria.Location = new Point(22, 423);
            cbrolsubcategoria.Name = "cbrolsubcategoria";
            cbrolsubcategoria.Size = new Size(152, 23);
            cbrolsubcategoria.TabIndex = 51;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Location = new Point(19, 405);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 50;
            label11.Text = "Subcategoria";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(19, 209);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(155, 23);
            txtpreciocompra.TabIndex = 52;
            txtpreciocompra.KeyPress += txtpreciocompra_KeyPress;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(19, 263);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(155, 23);
            txtprecioventa.TabIndex = 53;
            // 
            // btnlimpiar1
            // 
            btnlimpiar1.BackColor = Color.White;
            btnlimpiar1.Cursor = Cursors.Hand;
            btnlimpiar1.FlatAppearance.BorderColor = Color.Black;
            btnlimpiar1.FlatStyle = FlatStyle.Flat;
            btnlimpiar1.ForeColor = Color.White;
            btnlimpiar1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnlimpiar1.IconColor = Color.Black;
            btnlimpiar1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnlimpiar1.IconSize = 15;
            btnlimpiar1.Location = new Point(1019, 33);
            btnlimpiar1.Name = "btnlimpiar1";
            btnlimpiar1.Size = new Size(41, 24);
            btnlimpiar1.TabIndex = 54;
            btnlimpiar1.UseVisualStyleBackColor = false;
            // 
            // seleccion
            // 
            seleccion.DataPropertyName = "seleccion";
            seleccion.HeaderText = "";
            seleccion.Name = "seleccion";
            seleccion.ReadOnly = true;
            seleccion.Width = 50;
            // 
            // Id_prenda
            // 
            Id_prenda.HeaderText = "Id_prenda";
            Id_prenda.Name = "Id_prenda";
            Id_prenda.ReadOnly = true;
            Id_prenda.Visible = false;
            Id_prenda.Width = 200;
            // 
            // Prenda
            // 
            Prenda.HeaderText = "Prenda";
            Prenda.Name = "Prenda";
            Prenda.ReadOnly = true;
            Prenda.Width = 250;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Width = 80;
            // 
            // Precio_compra
            // 
            Precio_compra.HeaderText = "Val. Compra";
            Precio_compra.Name = "Precio_compra";
            Precio_compra.ReadOnly = true;
            // 
            // Precio_venta
            // 
            Precio_venta.HeaderText = "Val. Venta";
            Precio_venta.Name = "Precio_venta";
            Precio_venta.ReadOnly = true;
            Precio_venta.Resizable = DataGridViewTriState.False;
            // 
            // Subcategoria_id
            // 
            Subcategoria_id.HeaderText = "Subcategoria_id";
            Subcategoria_id.Name = "Subcategoria_id";
            Subcategoria_id.ReadOnly = true;
            Subcategoria_id.Visible = false;
            Subcategoria_id.Width = 150;
            // 
            // Subcategoria
            // 
            Subcategoria.HeaderText = "Subcategoria";
            Subcategoria.Name = "Subcategoria";
            Subcategoria.ReadOnly = true;
            // 
            // Talla_id
            // 
            Talla_id.HeaderText = "Talla_id";
            Talla_id.Name = "Talla_id";
            Talla_id.ReadOnly = true;
            Talla_id.Visible = false;
            // 
            // Talla
            // 
            Talla.HeaderText = "Talla";
            Talla.Name = "Talla";
            Talla.ReadOnly = true;
            // 
            // Color_id
            // 
            Color_id.HeaderText = "Color_id";
            Color_id.Name = "Color_id";
            Color_id.ReadOnly = true;
            Color_id.Visible = false;
            // 
            // Color
            // 
            Color.HeaderText = "Color";
            Color.Name = "Color";
            Color.ReadOnly = true;
            Color.Visible = false;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 599);
            Controls.Add(btnlimpiar1);
            Controls.Add(txtprecioventa);
            Controls.Add(txtpreciocompra);
            Controls.Add(cbrolsubcategoria);
            Controls.Add(label11);
            Controls.Add(cbrolcolor);
            Controls.Add(label10);
            Controls.Add(txtindice);
            Controls.Add(btnBuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label9);
            Controls.Add(txtid);
            Controls.Add(label8);
            Controls.Add(btnlimpiarbuscador);
            Controls.Add(dgvdata);
            Controls.Add(label7);
            Controls.Add(btneliminar);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(cbroltalla);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtnombreprenda);
            Controls.Add(label4);
            Controls.Add(txtcantdisponible);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
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
        private Label label7;
        private FontAwesome.Sharp.IconButton btneliminar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnguardar;
        private ComboBox cbroltalla;
        private TextBox txtConfirmarClave;
        private Label label6;
        private Label label5;
        private TextBox txtnombreprenda;
        private Label label4;
        private TextBox txtClave;
        private TextBox txtcantdisponible;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbrolcolor;
        private Label label10;
        private ComboBox cbrolsubcategoria;
        private Label label11;
        private TextBox txtpreciocompra;
        private TextBox txtprecioventa;
        private FontAwesome.Sharp.IconButton btnlimpiar1;
        private DataGridViewTextBoxColumn seleccion;
        private DataGridViewTextBoxColumn Id_prenda;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_compra;
        private DataGridViewTextBoxColumn Precio_venta;
        private DataGridViewTextBoxColumn Subcategoria_id;
        private DataGridViewTextBoxColumn Subcategoria;
        private DataGridViewTextBoxColumn Talla_id;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Color_id;
        private DataGridViewTextBoxColumn Color;
    }
}