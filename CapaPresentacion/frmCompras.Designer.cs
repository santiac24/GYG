namespace CapaPresentacion
{
    partial class frmCompras
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
            label8 = new Label();
            labelregistrarcompra = new Label();
            dbinformaciondelacompra = new GroupBox();
            cbotipodocumento = new ComboBox();
            labeltipodocumento = new Label();
            txtfecha = new TextBox();
            label1 = new Label();
            gbinformacionproveedor = new GroupBox();
            txtidproveedor = new TextBox();
            btnBuscarDocumento = new FontAwesome.Sharp.IconButton();
            txtnombreprovedor = new TextBox();
            labelnombreprovedor = new Label();
            txtnrodocumento = new TextBox();
            labelnrodocumento = new Label();
            groupBox1 = new GroupBox();
            txtiddelproducto = new TextBox();
            txtcantidad = new NumericUpDown();
            labelcantidad = new Label();
            txtprecioventa = new TextBox();
            labelprecioventa = new Label();
            txtpreciocompra = new TextBox();
            labelpreciocompra = new Label();
            txtproducto = new TextBox();
            labelproducto = new Label();
            txtidproducto = new TextBox();
            btnBuscarProducto = new FontAwesome.Sharp.IconButton();
            labelidproducto = new Label();
            dataGridView1 = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewTextBoxColumn();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            labeltotalapagar = new Label();
            txttotalapagar = new TextBox();
            btnRegistrar = new FontAwesome.Sharp.IconButton();
            dbinformaciondelacompra.SuspendLayout();
            gbinformacionproveedor.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 18);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(1119, 532);
            label8.TabIndex = 17;
            label8.Click += label8_Click;
            // 
            // labelregistrarcompra
            // 
            labelregistrarcompra.AutoSize = true;
            labelregistrarcompra.BackColor = Color.White;
            labelregistrarcompra.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelregistrarcompra.Location = new Point(35, 40);
            labelregistrarcompra.Name = "labelregistrarcompra";
            labelregistrarcompra.Size = new Size(214, 32);
            labelregistrarcompra.TabIndex = 18;
            labelregistrarcompra.Text = "Registrar Compra";
            labelregistrarcompra.Click += labelregistrarcompra_Click;
            // 
            // dbinformaciondelacompra
            // 
            dbinformaciondelacompra.BackColor = Color.White;
            dbinformaciondelacompra.Controls.Add(cbotipodocumento);
            dbinformaciondelacompra.Controls.Add(labeltipodocumento);
            dbinformaciondelacompra.Controls.Add(txtfecha);
            dbinformaciondelacompra.Controls.Add(label1);
            dbinformaciondelacompra.Location = new Point(35, 98);
            dbinformaciondelacompra.Name = "dbinformaciondelacompra";
            dbinformaciondelacompra.Size = new Size(470, 129);
            dbinformaciondelacompra.TabIndex = 19;
            dbinformaciondelacompra.TabStop = false;
            dbinformaciondelacompra.Text = "Información de la compra";
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
            // gbinformacionproveedor
            // 
            gbinformacionproveedor.BackColor = Color.White;
            gbinformacionproveedor.Controls.Add(txtidproveedor);
            gbinformacionproveedor.Controls.Add(btnBuscarDocumento);
            gbinformacionproveedor.Controls.Add(txtnombreprovedor);
            gbinformacionproveedor.Controls.Add(labelnombreprovedor);
            gbinformacionproveedor.Controls.Add(txtnrodocumento);
            gbinformacionproveedor.Controls.Add(labelnrodocumento);
            gbinformacionproveedor.Location = new Point(511, 98);
            gbinformacionproveedor.Name = "gbinformacionproveedor";
            gbinformacionproveedor.Size = new Size(470, 129);
            gbinformacionproveedor.TabIndex = 20;
            gbinformacionproveedor.TabStop = false;
            gbinformacionproveedor.Text = "Información del Proveedor";
            // 
            // txtidproveedor
            // 
            txtidproveedor.Location = new Point(424, 13);
            txtidproveedor.Name = "txtidproveedor";
            txtidproveedor.Size = new Size(31, 23);
            txtidproveedor.TabIndex = 23;
            txtidproveedor.Visible = false;
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
            btnBuscarDocumento.Click += btnBuscarDocumento_Click;
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
            groupBox1.Controls.Add(txtidproducto);
            groupBox1.Controls.Add(btnBuscarProducto);
            groupBox1.Controls.Add(labelidproducto);
            groupBox1.Location = new Point(35, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 89);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del producto";
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
            labelcantidad.Click += label2_Click_2;
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
            labelpreciocompra.Click += label2_Click_1;
            // 
            // txtproducto
            // 
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
            labelproducto.Click += label2_Click;
            // 
            // txtidproducto
            // 
            txtidproducto.Location = new Point(189, 22);
            txtidproducto.Name = "txtidproducto";
            txtidproducto.Size = new Size(31, 23);
            txtidproducto.TabIndex = 24;
            txtidproducto.Visible = false;
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
            btnBuscarProducto.Click += btnBuscarProducto_Click;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dataGridView1.Location = new Point(35, 328);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(946, 209);
            dataGridView1.TabIndex = 21;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.Width = 300;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.Width = 250;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 200;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.PaleGreen;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(849, 233);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(132, 89);
            btnAgregar.TabIndex = 22;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // labeltotalapagar
            // 
            labeltotalapagar.AutoSize = true;
            labeltotalapagar.BackColor = Color.White;
            labeltotalapagar.Location = new Point(987, 452);
            labeltotalapagar.Name = "labeltotalapagar";
            labeltotalapagar.Size = new Size(77, 15);
            labeltotalapagar.TabIndex = 23;
            labeltotalapagar.Text = "Total a pagar:";
            // 
            // txttotalapagar
            // 
            txttotalapagar.Location = new Point(987, 470);
            txttotalapagar.Name = "txttotalapagar";
            txttotalapagar.Size = new Size(131, 23);
            txttotalapagar.TabIndex = 24;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.RoyalBlue;
            btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.Tag;
            btnRegistrar.IconColor = Color.Black;
            btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRegistrar.IconSize = 30;
            btnRegistrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrar.Location = new Point(987, 499);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(132, 38);
            btnRegistrar.TabIndex = 25;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 727);
            Controls.Add(btnRegistrar);
            Controls.Add(txttotalapagar);
            Controls.Add(labeltotalapagar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(gbinformacionproveedor);
            Controls.Add(dbinformaciondelacompra);
            Controls.Add(labelregistrarcompra);
            Controls.Add(label8);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            dbinformaciondelacompra.ResumeLayout(false);
            dbinformaciondelacompra.PerformLayout();
            gbinformacionproveedor.ResumeLayout(false);
            gbinformacionproveedor.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtcantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label labelregistrarcompra;
        private GroupBox dbinformaciondelacompra;
        private Label labeltipodocumento;
        private TextBox txtfecha;
        private Label label1;
        private ComboBox cbotipodocumento;
        private GroupBox gbinformacionproveedor;
        private ComboBox comboBox1;
        private Label labelnombreprovedor;
        private TextBox txtnrodocumento;
        private Label labelnrodocumento;
        private TextBox txtnombreprovedor;
        private FontAwesome.Sharp.IconButton btnBuscarDocumento;
        private TextBox txtidproveedor;
        private GroupBox groupBox1;
        private Label label2;
        private Label labelidproducto;
        private FontAwesome.Sharp.IconButton btnBuscarProducto;
        private TextBox txtidproducto;
        private Label labelproducto;
        private Label labelpreciocompra;
        private TextBox txtproducto;
        private Label labelcantidad;
        private TextBox txtprecioventa;
        private Label labelprecioventa;
        private TextBox txtpreciocompra;
        private NumericUpDown txtcantidad;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private Label labeltotalapagar;
        private TextBox txttotalapagar;
        private FontAwesome.Sharp.IconButton btnRegistrar;
        private TextBox txtiddelproducto;
    }
}