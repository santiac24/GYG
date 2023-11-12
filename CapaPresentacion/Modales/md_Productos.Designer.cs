namespace CapaPresentacion.Modales
{
    partial class md_Productos
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
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtbusqueda = new TextBox();
            cbbusqueda = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            dgvdata = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Prenda = new DataGridViewTextBoxColumn();
            Subcategoria = new DataGridViewTextBoxColumn();
            IdSubcategoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvdata).BeginInit();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.FlatAppearance.BorderColor = Color.Black;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 15;
            btnLimpiar.Location = new Point(838, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(41, 23);
            btnLimpiar.TabIndex = 60;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += iconButton1_Click;
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
            btnBuscar.Location = new Point(791, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(41, 23);
            btnBuscar.TabIndex = 59;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(596, 45);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(165, 23);
            txtbusqueda.TabIndex = 58;
            // 
            // cbbusqueda
            // 
            cbbusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbusqueda.FormattingEnabled = true;
            cbbusqueda.Location = new Point(390, 45);
            cbbusqueda.Name = "cbbusqueda";
            cbbusqueda.Size = new Size(200, 23);
            cbbusqueda.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.White;
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(309, 48);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 56;
            label9.Text = "Buscar por:";
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
            label8.Padding = new Padding(2, 7, 0, 0);
            label8.Size = new Size(886, 89);
            label8.TabIndex = 55;
            label8.Text = "Lista de productos";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvdata
            // 
            dgvdata.AllowUserToAddRows = false;
            dgvdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdata.Columns.AddRange(new DataGridViewColumn[] { Id, Prenda, Subcategoria, IdSubcategoria, Stock, PrecioCompra, PrecioVenta });
            dgvdata.Location = new Point(12, 118);
            dgvdata.MultiSelect = false;
            dgvdata.Name = "dgvdata";
            dgvdata.ReadOnly = true;
            dgvdata.RowTemplate.Height = 25;
            dgvdata.Size = new Size(886, 390);
            dgvdata.TabIndex = 61;
            dgvdata.CellContentClick += dgvdata_CellContentClick;
            dgvdata.CellDoubleClick += dgvdata_CellDoubleClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // Prenda
            // 
            Prenda.HeaderText = "Prenda";
            Prenda.Name = "Prenda";
            Prenda.ReadOnly = true;
            Prenda.Width = 450;
            // 
            // Subcategoria
            // 
            Subcategoria.HeaderText = "Subcategoria";
            Subcategoria.Name = "Subcategoria";
            Subcategoria.ReadOnly = true;
            Subcategoria.Width = 450;
            // 
            // IdSubcategoria
            // 
            IdSubcategoria.HeaderText = "IdSubcategoria";
            IdSubcategoria.Name = "IdSubcategoria";
            IdSubcategoria.ReadOnly = true;
            IdSubcategoria.Visible = false;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Visible = false;
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            PrecioCompra.ReadOnly = true;
            PrecioCompra.Visible = false;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Visible = false;
            // 
            // md_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(dgvdata);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtbusqueda);
            Controls.Add(cbbusqueda);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "md_Productos";
            Text = "md_Productos";
            Load += md_Productos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtbusqueda;
        private ComboBox cbbusqueda;
        private Label label9;
        private Label label8;
        private DataGridView dgvdata;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Prenda;
        private DataGridViewTextBoxColumn Subcategoria;
        private DataGridViewTextBoxColumn IdSubcategoria;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
    }
}