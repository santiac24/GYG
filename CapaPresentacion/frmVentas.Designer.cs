namespace CapaPresentacion
{
    partial class frmVentas
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
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            labeltotalapagar = new Label();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            txttotalapagar = new TextBox();
            dgvdata = new DataGridView();
            txtiddelproducto = new TextBox();
            txtcantidad = new NumericUpDown();
            labelcantidad = new Label();
            txtprecioventa = new TextBox();
            labelprecioventa = new Label();
            dbinformaciondelacompra = new GroupBox();
            cbotipodocumento = new ComboBox();
            labeltipodocumento = new Label();
            txtfecha = new TextBox();
            label1 = new Label();
            labelregistrarventa = new Label();
            label8 = new Label();
            gbinformacionproveedor = new GroupBox();
            txtidproveedor = new TextBox();
            btnBuscarDocumento = new FontAwesome.Sharp.IconButton();
            txtnombreprovedor = new TextBox();
            labelnombreprovedor = new Label();
            txtnrodocumento = new TextBox();
            labelnrodocumento = new Label();
            txtpreciocompra = new TextBox();
            labelpreciocompra = new Label();
            txtproducto = new TextBox();
            labelproducto = new Label();
            txtnoutilporahora = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            labelidproducto = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            dbinformaciondelacompra.SuspendLayout();
            gbinformacionproveedor.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.RoyalBlue;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.IconSize = 30;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(1125, 528);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 38);
            btnRegistrar.TabIndex = 35;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // labeltotalapagar
            // 
            labeltotalapagar.AutoSize = true;
            labeltotalapagar.BackColor = Color.White;
            labeltotalapagar.Location = new Point(1125, 481);
            labeltotalapagar.Name = "labeltotalapagar";
            labeltotalapagar.Size = new Size(77, 15);
            labeltotalapagar.TabIndex = 33;
            labeltotalapagar.Text = "Total a pagar:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(987, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 89);
            btnAgregar.TabIndex = 32;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 50;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 200;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 250;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 300;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(1125, 499);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.Size = new Size(131, 23);
            txttotalapagar.TabIndex = 34;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dgvdata.Location = new Point(173, 357);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(931, 209);
            dgvdata.TabIndex = 31;
            // 
            // txtiddelproducto
            // 
            txtiddelproducto.Location = new Point(6, 53);
            txtiddelproducto.Name = "txtiddelproducto";
            txtiddelproducto.Size = new Size(177, 23);
            txtiddelproducto.TabIndex = 33;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(720, 53);
            txtcantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(75, 23);
            txtcantidad.TabIndex = 32;
            txtcantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelcantidad
            // 
            labelcantidad.AutoSize = true;
            labelcantidad.Location = new Point(720, 35);
            labelcantidad.Name = "labelcantidad";
            labelcantidad.Size = new Size(58, 15);
            labelcantidad.TabIndex = 31;
            labelcantidad.Text = "Cantidad:";
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(587, 52);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(115, 23);
            txtprecioventa.TabIndex = 30;
            // 
            // labelprecioventa
            // 
            labelprecioventa.AutoSize = true;
            labelprecioventa.Location = new Point(586, 36);
            labelprecioventa.Name = "labelprecioventa";
            labelprecioventa.Size = new Size(75, 15);
            labelprecioventa.TabIndex = 29;
            labelprecioventa.Text = "Precio venta:";
            // 
            // dbinformaciondelacompra
            // 
            dbinformaciondelacompra.BackColor = Color.White;
            dbinformaciondelacompra.Controls.Add(cbotipodocumento);
            dbinformaciondelacompra.Controls.Add(labeltipodocumento);
            dbinformaciondelacompra.Controls.Add(txtfecha);
            dbinformaciondelacompra.Controls.Add(label1);
            dbinformaciondelacompra.Location = new Point(173, 127);
            dbinformaciondelacompra.Name = "dbinformaciondelacompra";
            dbinformaciondelacompra.Size = new Size(470, 129);
            dbinformaciondelacompra.TabIndex = 28;
            dbinformaciondelacompra.TabStop = false;
            dbinformaciondelacompra.Text = "Información de la venta";
            // 
            // cbotipodocumento
            // 
            cbotipodocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbotipodocumento.FormattingEnabled = true;
            cbotipodocumento.Location = new Point(203, 54);
            cbotipodocumento.Name = "cbotipodocumento";
            cbotipodocumento.Size = new Size(242, 23);
            cbotipodocumento.TabIndex = 3;
            // 
            // labeltipodocumento
            // 
            labeltipodocumento.AutoSize = true;
            labeltipodocumento.Location = new Point(203, 36);
            labeltipodocumento.Name = "labeltipodocumento";
            labeltipodocumento.Size = new Size(114, 15);
            labeltipodocumento.TabIndex = 2;
            labeltipodocumento.Text = "Tipo de documento:";
            // 
            // txtfecha
            // 
            txtfecha.AcceptsTab = true;
            txtfecha.Enabled = false;
            txtfecha.Location = new Point(6, 54);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(177, 23);
            txtfecha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha";
            // 
            // labelregistrarventa
            // 
            labelregistrarventa.AutoSize = true;
            labelregistrarventa.BackColor = Color.White;
            labelregistrarventa.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelregistrarventa.Location = new Point(173, 69);
            labelregistrarventa.Name = "labelregistrarventa";
            labelregistrarventa.Size = new Size(188, 32);
            labelregistrarventa.TabIndex = 27;
            labelregistrarventa.Text = "Registrar Venta";
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(150, 47);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(1119, 532);
            label8.TabIndex = 26;
            // 
            // gbinformacionproveedor
            // 
            gbinformacionproveedor.BackColor = Color.White;
            gbinformacionproveedor.Controls.Add(txtidproveedor);
            gbinformacionproveedor.Controls.Add(btnBuscarDocumento);
            gbinformacionproveedor.Controls.Add(txtnombreprovedor);
            gbinformacionproveedor.Controls.Add(labelnombreprovedor);
            gbinformacionproveedor.Controls.Add(txtnrodocumento);
            gbinformacionproveedor.Controls.Add(labelnrodocumento);
            gbinformacionproveedor.Location = new Point(649, 127);
            gbinformacionproveedor.Name = "gbinformacionproveedor";
            gbinformacionproveedor.Size = new Size(470, 129);
            gbinformacionproveedor.TabIndex = 29;
            gbinformacionproveedor.TabStop = false;
            gbinformacionproveedor.Text = "Información del cliente";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(424, 13);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(31, 23);
            txtidproveedor.TabIndex = 23;
            // 
            // btnBuscarDocumento
            // 
            btnBuscarDocumento.BackColor = Color.White;
            btnBuscarDocumento.Cursor = Cursors.Hand;
            btnBuscarDocumento.FlatAppearance.BorderColor = Color.Black;
            btnBuscarDocumento.FlatStyle = FlatStyle.Flat;
            btnBuscarDocumento.ForeColor = Color.White;
            btnBuscarDocumento.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarDocumento.IconColor = Color.Black;
            btnBuscarDocumento.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuscarDocumento.IconSize = 15;
            btnBuscarDocumento.Location = new Point(156, 54);
            btnBuscarDocumento.Name = "btnBuscarDocumento";
            btnBuscarDocumento.Size = new Size(29, 23);
            btnBuscarDocumento.TabIndex = 22;
            btnBuscarDocumento.UseVisualStyleBackColor = false;
            // 
            // txtnombreprovedor
            // 
            txtnombreprovedor.Location = new Point(203, 54);
            txtnombreprovedor.Name = "txtnombreprovedor";
            txtnombreprovedor.Size = new Size(177, 23);
            txtnombreprovedor.TabIndex = 3;
            // 
            // labelnombreprovedor
            // 
            labelnombreprovedor.AutoSize = true;
            labelnombreprovedor.Location = new Point(203, 36);
            labelnombreprovedor.Name = "labelnombreprovedor";
            labelnombreprovedor.Size = new Size(105, 15);
            labelnombreprovedor.TabIndex = 2;
            labelnombreprovedor.Text = "Nombre provedor:";
            // 
            // txtnrodocumento
            // 
            txtnrodocumento.Location = new Point(6, 54);
            txtnrodocumento.Name = "txtnrodocumento";
            txtnrodocumento.Size = new Size(145, 23);
            txtnrodocumento.TabIndex = 1;
            // 
            // labelnrodocumento
            // 
            labelnrodocumento.AutoSize = true;
            labelnrodocumento.Location = new Point(6, 36);
            labelnrodocumento.Name = "labelnrodocumento";
            labelnrodocumento.Size = new Size(96, 15);
            labelnrodocumento.TabIndex = 0;
            labelnrodocumento.Text = "Nro. Documento";
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.Location = new Point(443, 53);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.Size = new Size(125, 23);
            txtpreciocompra.TabIndex = 28;
            // 
            // labelpreciocompra
            // 
            labelpreciocompra.AutoSize = true;
            labelpreciocompra.Location = new Point(443, 36);
            labelpreciocompra.Name = "labelpreciocompra";
            labelpreciocompra.Size = new Size(87, 15);
            labelpreciocompra.TabIndex = 27;
            labelpreciocompra.Text = "Precio compra:";
            // 
            // txtproducto
            // 
            txtproducto.Enabled = false;
            txtproducto.Location = new Point(248, 54);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(177, 23);
            txtproducto.TabIndex = 26;
            // 
            // labelproducto
            // 
            labelproducto.AutoSize = true;
            labelproducto.Location = new Point(248, 36);
            labelproducto.Name = "labelproducto";
            labelproducto.Size = new Size(59, 15);
            labelproducto.TabIndex = 25;
            labelproducto.Text = "Producto:";
            // 
            // txtnoutilporahora
            // 
            txtnoutilporahora.Location = new Point(189, 22);
            txtnoutilporahora.Name = "txtnoutilporahora";
            txtnoutilporahora.Size = new Size(31, 23);
            txtnoutilporahora.TabIndex = 24;
            txtnoutilporahora.Visible = false;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.White;
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderColor = Color.Black;
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.White;
            btnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscarProducto.IconColor = Color.Black;
            btnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnBuscarProducto.IconSize = 15;
            btnBuscarProducto.Location = new Point(189, 53);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(29, 23);
            btnBuscarProducto.TabIndex = 24;
            btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // labelidproducto
            // 
            labelidproducto.AutoSize = true;
            labelidproducto.Location = new Point(6, 36);
            labelidproducto.Name = "labelidproducto";
            labelidproducto.Size = new Size(91, 15);
            labelidproducto.TabIndex = 0;
            labelidproducto.Text = "Id del producto:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtiddelproducto);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(labelcantidad);
            groupBox1.Controls.Add(txtprecioventa);
            groupBox1.Controls.Add(labelprecioventa);
            groupBox1.Controls.Add(txtpreciocompra);
            groupBox1.Controls.Add(labelpreciocompra);
            groupBox1.Controls.Add(txtproducto);
            groupBox1.Controls.Add(labelproducto);
            groupBox1.Controls.Add(txtnoutilporahora);
            groupBox1.Controls.Add(btnBuscarProducto);
            groupBox1.Controls.Add(labelidproducto);
            groupBox1.Location = new Point(173, 262);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 89);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del producto";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(labeltotalapagar);
            Controls.Add(btnAgregar);
            Controls.Add(txttotalapagar);
            Controls.Add(dgvdata);
            Controls.Add(dbinformaciondelacompra);
            Controls.Add(labelregistrarventa);
            Controls.Add(gbinformacionproveedor);
            Controls.Add(groupBox1);
            Controls.Add(label8);
            Name = "frmVentas";
            Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            dbinformaciondelacompra.ResumeLayout(false);
            dbinformaciondelacompra.PerformLayout();
            gbinformacionproveedor.ResumeLayout(false);
            gbinformacionproveedor.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnRegistrar;
        private Label labeltotalapagar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridViewTextBoxColumn btnEliminar;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn IdProducto;
        private TextBox txttotalapagar;
        private DataGridView dgvdata;
        private TextBox txtiddelproducto;
        private NumericUpDown txtcantidad;
        private Label labelcantidad;
        private TextBox txtprecioventa;
        private Label labelprecioventa;
        private GroupBox dbinformaciondelacompra;
        private ComboBox cbotipodocumento;
        private Label labeltipodocumento;
        private TextBox txtfecha;
        private Label label1;
        private Label labelregistrarventa;
        private Label label8;
        private GroupBox gbinformacionproveedor;
        private TextBox txtidproveedor;
        private FontAwesome.Sharp.IconButton btnBuscarDocumento;
        private TextBox txtnombreprovedor;
        private Label labelnombreprovedor;
        private TextBox txtnrodocumento;
        private Label labelnrodocumento;
        private TextBox txtpreciocompra;
        private Label labelpreciocompra;
        private TextBox txtproducto;
        private Label labelproducto;
        private TextBox txtnoutilporahora;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private Label labelidproducto;
        private GroupBox groupBox1;
    }
}