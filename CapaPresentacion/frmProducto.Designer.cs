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
            this.txtindice = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbbusqueda = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnlimpiarbuscador = new FontAwesome.Sharp.IconButton();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.seleccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_dispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategoria_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.cbsubcategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidaddisponible = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.cbtalla = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbcolor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // txtindice
            // 
            this.txtindice.Location = new System.Drawing.Point(90, 13);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(36, 23);
            this.txtindice.TabIndex = 47;
            this.txtindice.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnBuscar.IconSize = 15;
            this.btnBuscar.Location = new System.Drawing.Point(973, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 23);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(802, 38);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 23);
            this.txtbusqueda.TabIndex = 44;
            // 
            // cbbusqueda
            // 
            this.cbbusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbusqueda.FormattingEnabled = true;
            this.cbbusqueda.Location = new System.Drawing.Point(596, 38);
            this.cbbusqueda.Name = "cbbusqueda";
            this.cbbusqueda.Size = new System.Drawing.Size(200, 23);
            this.cbbusqueda.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(515, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "Buscar por:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(135, 13);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(36, 23);
            this.txtid.TabIndex = 41;
            this.txtid.Text = "0";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(218, 22);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label8.Size = new System.Drawing.Size(1058, 54);
            this.label8.TabIndex = 40;
            this.label8.Text = "Prendas registradas";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnlimpiarbuscador
            // 
            this.btnlimpiarbuscador.BackColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiarbuscador.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiarbuscador.ForeColor = System.Drawing.Color.White;
            this.btnlimpiarbuscador.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiarbuscador.IconColor = System.Drawing.Color.Black;
            this.btnlimpiarbuscador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiarbuscador.IconSize = 15;
            this.btnlimpiarbuscador.Location = new System.Drawing.Point(1020, 37);
            this.btnlimpiarbuscador.Name = "btnlimpiarbuscador";
            this.btnlimpiarbuscador.Size = new System.Drawing.Size(41, 23);
            this.btnlimpiarbuscador.TabIndex = 46;
            this.btnlimpiarbuscador.UseVisualStyleBackColor = false;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seleccion,
            this.Id_prenda,
            this.Prenda,
            this.Cantidad_dispo,
            this.Precio_compra,
            this.Precio_venta,
            this.Subcategoria_id,
            this.Subcategoria,
            this.Talla_id,
            this.Talla,
            this.Color_id,
            this.Color});
            this.dgvdata.Location = new System.Drawing.Point(218, 98);
            this.dgvdata.MultiSelect = false;
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.ReadOnly = true;
            this.dgvdata.RowTemplate.Height = 25;
            this.dgvdata.Size = new System.Drawing.Size(1058, 390);
            this.dgvdata.TabIndex = 39;
            // 
            // seleccion
            // 
            this.seleccion.DataPropertyName = "seleccion";
            this.seleccion.HeaderText = "";
            this.seleccion.Name = "seleccion";
            this.seleccion.ReadOnly = true;
            this.seleccion.Width = 50;
            // 
            // Id_prenda
            // 
            this.Id_prenda.HeaderText = "Id_prenda";
            this.Id_prenda.Name = "Id_prenda";
            this.Id_prenda.ReadOnly = true;
            this.Id_prenda.Visible = false;
            this.Id_prenda.Width = 200;
            // 
            // Prenda
            // 
            this.Prenda.HeaderText = "Prenda";
            this.Prenda.Name = "Prenda";
            this.Prenda.ReadOnly = true;
            // 
            // Cantidad_dispo
            // 
            this.Cantidad_dispo.HeaderText = "Disponible";
            this.Cantidad_dispo.Name = "Cantidad_dispo";
            this.Cantidad_dispo.ReadOnly = true;
            // 
            // Precio_compra
            // 
            this.Precio_compra.HeaderText = "Precio compra";
            this.Precio_compra.Name = "Precio_compra";
            this.Precio_compra.ReadOnly = true;
            this.Precio_compra.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Precio_venta
            // 
            this.Precio_venta.HeaderText = "Precio venta";
            this.Precio_venta.Name = "Precio_venta";
            this.Precio_venta.ReadOnly = true;
            // 
            // Subcategoria_id
            // 
            this.Subcategoria_id.HeaderText = "Subcategoria_id";
            this.Subcategoria_id.Name = "Subcategoria_id";
            this.Subcategoria_id.ReadOnly = true;
            this.Subcategoria_id.Visible = false;
            // 
            // Subcategoria
            // 
            this.Subcategoria.HeaderText = "Subcategoria";
            this.Subcategoria.Name = "Subcategoria";
            this.Subcategoria.ReadOnly = true;
            this.Subcategoria.Width = 250;
            // 
            // Talla_id
            // 
            this.Talla_id.HeaderText = "Talla_id";
            this.Talla_id.Name = "Talla_id";
            this.Talla_id.ReadOnly = true;
            this.Talla_id.Visible = false;
            this.Talla_id.Width = 250;
            // 
            // Talla
            // 
            this.Talla.HeaderText = "Talla";
            this.Talla.Name = "Talla";
            this.Talla.ReadOnly = true;
            // 
            // Color_id
            // 
            this.Color_id.HeaderText = "Color_id";
            this.Color_id.Name = "Color_id";
            this.Color_id.ReadOnly = true;
            this.Color_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Color_id.Visible = false;
            // 
            // Color
            // 
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            this.Color.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(10, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 28);
            this.label7.TabIndex = 38;
            this.label7.Text = "Prendas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            this.btneliminar.Location = new System.Drawing.Point(16, 523);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(152, 23);
            this.btneliminar.TabIndex = 37;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Blue;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.ForeColor = System.Drawing.Color.White;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.Location = new System.Drawing.Point(16, 494);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(152, 23);
            this.btnlimpiar.TabIndex = 36;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
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
            this.btnguardar.Location = new System.Drawing.Point(16, 465);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(152, 23);
            this.btnguardar.TabIndex = 35;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // cbsubcategoria
            // 
            this.cbsubcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsubcategoria.FormattingEnabled = true;
            this.cbsubcategoria.Location = new System.Drawing.Point(16, 312);
            this.cbsubcategoria.Name = "cbsubcategoria";
            this.cbsubcategoria.Size = new System.Drawing.Size(169, 23);
            this.cbsubcategoria.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio venta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Subcategoria";
            // 
            // txtprenda
            // 
            this.txtprenda.Location = new System.Drawing.Point(13, 79);
            this.txtprenda.Name = "txtprenda";
            this.txtprenda.Size = new System.Drawing.Size(172, 23);
            this.txtprenda.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(10, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Prenda";
            // 
            // txtcantidaddisponible
            // 
            this.txtcantidaddisponible.Location = new System.Drawing.Point(13, 138);
            this.txtcantidaddisponible.Name = "txtcantidaddisponible";
            this.txtcantidaddisponible.Size = new System.Drawing.Size(172, 23);
            this.txtcantidaddisponible.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cantidad disponible";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 581);
            this.label1.TabIndex = 24;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(13, 194);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(172, 23);
            this.txtpreciocompra.TabIndex = 48;
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(13, 254);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(172, 23);
            this.txtprecioventa.TabIndex = 49;
            // 
            // cbtalla
            // 
            this.cbtalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtalla.FormattingEnabled = true;
            this.cbtalla.Location = new System.Drawing.Point(13, 365);
            this.cbtalla.Name = "cbtalla";
            this.cbtalla.Size = new System.Drawing.Size(172, 23);
            this.cbtalla.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "Talla";
            // 
            // cbcolor
            // 
            this.cbcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcolor.FormattingEnabled = true;
            this.cbcolor.Location = new System.Drawing.Point(13, 420);
            this.cbcolor.Name = "cbcolor";
            this.cbcolor.Size = new System.Drawing.Size(172, 23);
            this.cbcolor.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 15);
            this.label11.TabIndex = 52;
            this.label11.Text = "Color";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 581);
            this.Controls.Add(this.cbcolor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbtalla);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.cbbusqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnlimpiarbuscador);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cbsubcategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcantidaddisponible);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProducto";
            this.Text = "frmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox cbsubcategoria;
        private Label label6;
        private Label label5;
        private TextBox txtprenda;
        private Label label4;
        private TextBox txtcantidaddisponible;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn seleccion;
        private DataGridViewTextBoxColumn Id_prenda;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Cantidad_dispo;
        private DataGridViewTextBoxColumn Precio_compra;
        private DataGridViewTextBoxColumn Precio_venta;
        private DataGridViewTextBoxColumn Subcategoria_id;
        private DataGridViewTextBoxColumn Subcategoria;
        private DataGridViewTextBoxColumn Talla_id;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn Color_id;
        private DataGridViewTextBoxColumn Color;
        private TextBox txtpreciocompra;
        private TextBox txtprecioventa;
        private ComboBox cbtalla;
        private Label label10;
        private ComboBox cbcolor;
        private Label label11;
    }
}