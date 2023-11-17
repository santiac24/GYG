namespace CapaPresentacion
{
    partial class frmDetalleCompra
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
            dbinformaciondelacompra = new GroupBox();
            label2 = new Label();
            txtusuario = new TextBox();
            txttipodocumento = new TextBox();
            labeltipodocumento = new Label();
            txtfecha = new TextBox();
            label1 = new Label();
            label8 = new Label();
            labelregistrarcompra = new Label();
            label9 = new Label();
            txtid = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            groupBox1 = new GroupBox();
            txtnombreproveedor = new TextBox();
            label3 = new Label();
            txtidprovedor = new TextBox();
            label4 = new Label();
            dgvdata = new DataGridView();
            IdProducto = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            btnEliminar = new DataGridViewTextBoxColumn();
            txttotal = new TextBox();
            labelproducto = new Label();
            btnexportar = new FontAwesome.Sharp.IconButton();
            dbinformaciondelacompra.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // dbinformaciondelacompra
            // 
            dbinformaciondelacompra.BackColor = Color.White;
            dbinformaciondelacompra.Controls.Add(label2);
            dbinformaciondelacompra.Controls.Add(txtusuario);
            dbinformaciondelacompra.Controls.Add(txttipodocumento);
            dbinformaciondelacompra.Controls.Add(labeltipodocumento);
            dbinformaciondelacompra.Controls.Add(txtfecha);
            dbinformaciondelacompra.Controls.Add(label1);
            dbinformaciondelacompra.Location = new Point(71, 84);
            dbinformaciondelacompra.Name = "dbinformaciondelacompra";
            dbinformaciondelacompra.Size = new Size(1032, 102);
            dbinformaciondelacompra.TabIndex = 20;
            dbinformaciondelacompra.TabStop = false;
            dbinformaciondelacompra.Text = "Información de compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(480, 36);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "Usuario:";
            // 
            // txtusuario
            // 
            txtusuario.AcceptsTab = true;
            txtusuario.Enabled = false;
            txtusuario.Location = new Point(480, 54);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(186, 23);
            txtusuario.TabIndex = 5;
            // 
            // txttipodocumento
            // 
            txttipodocumento.AcceptsTab = true;
            txttipodocumento.Enabled = false;
            txttipodocumento.Location = new Point(247, 54);
            txttipodocumento.Name = "txttipodocumento";
            txttipodocumento.Size = new Size(186, 23);
            txttipodocumento.TabIndex = 4;
            // 
            // labeltipodocumento
            // 
            labeltipodocumento.AutoSize = true;
            labeltipodocumento.Location = new Point(242, 36);
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
            txtfecha.Size = new Size(186, 23);
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
            // label8
            // 
            label8.BackColor = Color.White;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Cursor = Cursors.IBeam;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Padding = new Padding(2, 0, 0, 0);
            label8.Size = new Size(1131, 641);
            label8.TabIndex = 18;
            // 
            // labelregistrarcompra
            // 
            labelregistrarcompra.AutoSize = true;
            labelregistrarcompra.BackColor = Color.White;
            labelregistrarcompra.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelregistrarcompra.Location = new Point(77, 41);
            labelregistrarcompra.Name = "labelregistrarcompra";
            labelregistrarcompra.Size = new Size(191, 32);
            labelregistrarcompra.TabIndex = 19;
            labelregistrarcompra.Text = "Detalle Compra";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(660, 55);
            label9.Name = "label9";
            label9.Size = new Size(120, 15);
            label9.TabIndex = 55;
            label9.Text = "Numero Documento:";
            // 
            // txtid
            // 
            txtid.Location = new Point(793, 50);
            txtid.Name = "txtid";
            txtid.Size = new Size(174, 23);
            txtid.TabIndex = 56;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.White;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.Black;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Broom;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(1050, 44);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(50, 29);
            iconButton1.TabIndex = 58;
            iconButton1.UseVisualStyleBackColor = false;
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
            btnBuscar.Location = new Point(988, 44);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(50, 29);
            btnBuscar.TabIndex = 57;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtnombreproveedor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtidprovedor);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(71, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1032, 98);
            groupBox1.TabIndex = 59;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información del Proveedor";
            // 
            // txtnombreproveedor
            // 
            txtnombreproveedor.AcceptsTab = true;
            txtnombreproveedor.Enabled = false;
            txtnombreproveedor.Location = new Point(242, 54);
            txtnombreproveedor.Name = "txtnombreproveedor";
            txtnombreproveedor.Size = new Size(186, 23);
            txtnombreproveedor.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 36);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // txtidprovedor
            // 
            txtidprovedor.AcceptsTab = true;
            txtidprovedor.Enabled = false;
            txtidprovedor.Location = new Point(6, 54);
            txtidprovedor.Name = "txtidprovedor";
            txtidprovedor.Size = new Size(186, 23);
            txtidprovedor.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 36);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 0;
            label4.Text = "ID";
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Producto, PrecioCompra, PrecioVenta, Cantidad, Subtotal, btnEliminar });
            dgvdata.Location = new Point(71, 296);
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(1032, 297);
            dgvdata.TabIndex = 60;
            // 
            // IdProducto
            // 
            IdProducto.DataPropertyName = "IdProducto";
            IdProducto.HeaderText = "IdProducto";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Visible = false;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Width = 300;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Width = 250;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 200;
            // 
            // btnEliminar
            // 
            btnEliminar.HeaderText = "";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.ReadOnly = true;
            btnEliminar.Width = 50;
            // 
            // txttotal
            // 
            txttotal.Enabled = false;
            txttotal.Location = new Point(168, 613);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(90, 23);
            txttotal.TabIndex = 62;
            // 
            // labelproducto
            // 
            labelproducto.AutoSize = true;
            labelproducto.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.World);
            labelproducto.Location = new Point(69, 614);
            labelproducto.Name = "labelproducto";
            labelproducto.Size = new Size(92, 19);
            labelproducto.TabIndex = 61;
            labelproducto.Text = "Monto total:";
            // 
            // btnexportar
            // 
            btnexportar.BackColor = Color.White;
            btnexportar.Cursor = Cursors.Hand;
            btnexportar.FlatAppearance.BorderColor = Color.Black;
            btnexportar.FlatStyle = FlatStyle.Flat;
            btnexportar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnexportar.ForeColor = Color.Black;
            btnexportar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            btnexportar.IconColor = Color.Black;
            btnexportar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnexportar.IconSize = 15;
            btnexportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnexportar.Location = new Point(975, 603);
            btnexportar.Name = "btnexportar";
            btnexportar.Size = new Size(128, 29);
            btnexportar.TabIndex = 63;
            btnexportar.Text = "Descargar PDF";
            btnexportar.UseVisualStyleBackColor = false;
            // 
            // frmDetalleCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 684);
            Controls.Add(btnexportar);
            Controls.Add(txttotal);
            Controls.Add(labelproducto);
            Controls.Add(dgvdata);
            Controls.Add(groupBox1);
            Controls.Add(iconButton1);
            Controls.Add(btnBuscar);
            Controls.Add(txtid);
            Controls.Add(label9);
            Controls.Add(labelregistrarcompra);
            Controls.Add(dbinformaciondelacompra);
            Controls.Add(label8);
            Name = "frmDetalleCompra";
            Text = "frmDetalleCompra";
            Load += frmDetalleCompra_Load;
            dbinformaciondelacompra.ResumeLayout(false);
            dbinformaciondelacompra.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox dbinformaciondelacompra;
        private Label labeltipodocumento;
        private TextBox txtfecha;
        private Label label1;
        private Label label8;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txttipodocumento;
        private Label labelregistrarcompra;
        private Label label9;
        private TextBox txtid;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private GroupBox groupBox1;
        private TextBox txtnombreproveedor;
        private Label label3;
        private TextBox txtidprovedor;
        private Label label4;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn btnEliminar;
        private TextBox txttotal;
        private Label labelproducto;
        private FontAwesome.Sharp.IconButton btnexportar;
    }
}