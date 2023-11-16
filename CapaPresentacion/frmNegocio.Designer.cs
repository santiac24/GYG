namespace CapaPresentacion
{
    partial class frmNegocio
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
            label_detallernegocio = new Label();
            groupBox1 = new GroupBox();
            btnguardar = new FontAwesome.Sharp.IconButton();
            txtdireccion = new TextBox();
            txtnit = new TextBox();
            txtnombrenegocio = new TextBox();
            label3 = new Label();
            label2 = new Label();
            labelnombrenegocio = new Label();
            btnsubirimagen = new FontAwesome.Sharp.IconButton();
            picLogo = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1355, 450);
            label1.TabIndex = 1;
            // 
            // label_detallernegocio
            // 
            label_detallernegocio.AutoSize = true;
            label_detallernegocio.BackColor = Color.White;
            label_detallernegocio.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_detallernegocio.ForeColor = SystemColors.ActiveCaptionText;
            label_detallernegocio.Location = new Point(12, 21);
            label_detallernegocio.Name = "label_detallernegocio";
            label_detallernegocio.Size = new Size(165, 28);
            label_detallernegocio.TabIndex = 15;
            label_detallernegocio.Text = "Detalle Negocio";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnguardar);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(txtnit);
            groupBox1.Controls.Add(txtnombrenegocio);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(labelnombrenegocio);
            groupBox1.Controls.Add(btnsubirimagen);
            groupBox1.Controls.Add(picLogo);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 335);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
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
            btnguardar.Location = new Point(298, 204);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(152, 23);
            btnguardar.TabIndex = 12;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // txtdireccion
            // 
            txtdireccion.Location = new Point(298, 159);
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(155, 23);
            txtdireccion.TabIndex = 9;
            // 
            // txtnit
            // 
            txtnit.Location = new Point(298, 98);
            txtnit.Name = "txtnit";
            txtnit.Size = new Size(155, 23);
            txtnit.TabIndex = 8;
            txtnit.TextChanged += textBox1_TextChanged;
            // 
            // txtnombrenegocio
            // 
            txtnombrenegocio.Location = new Point(298, 40);
            txtnombrenegocio.Name = "txtnombrenegocio";
            txtnombrenegocio.Size = new Size(155, 23);
            txtnombrenegocio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 141);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Dirección:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 80);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "NIT:";
            // 
            // labelnombrenegocio
            // 
            labelnombrenegocio.AutoSize = true;
            labelnombrenegocio.Location = new Point(298, 22);
            labelnombrenegocio.Name = "labelnombrenegocio";
            labelnombrenegocio.Size = new Size(100, 15);
            labelnombrenegocio.TabIndex = 2;
            labelnombrenegocio.Text = "Nombre negocio:";
            labelnombrenegocio.Click += label2_Click;
            // 
            // btnsubirimagen
            // 
            btnsubirimagen.IconChar = FontAwesome.Sharp.IconChar.Upload;
            btnsubirimagen.IconColor = Color.Black;
            btnsubirimagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnsubirimagen.IconSize = 15;
            btnsubirimagen.ImageAlign = ContentAlignment.MiddleLeft;
            btnsubirimagen.Location = new Point(49, 287);
            btnsubirimagen.Name = "btnsubirimagen";
            btnsubirimagen.RightToLeft = RightToLeft.No;
            btnsubirimagen.Size = new Size(154, 23);
            btnsubirimagen.TabIndex = 1;
            btnsubirimagen.Text = "Subir imagen";
            btnsubirimagen.UseVisualStyleBackColor = true;
            btnsubirimagen.Click += btnsubirimagen_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Location = new Point(6, 22);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(251, 235);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmNegocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 450);
            Controls.Add(groupBox1);
            Controls.Add(label_detallernegocio);
            Controls.Add(label1);
            Name = "frmNegocio";
            Text = "Negocio";
            Load += frmNegocio_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_detallernegocio;
        private GroupBox groupBox1;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnsubirimagen;
        private Label labelnombrenegocio;
        private Label label3;
        private Label label2;
        private TextBox txtnit;
        private TextBox txtnombrenegocio;
        private TextBox txtdireccion;
        private FontAwesome.Sharp.IconButton btnguardar;
    }
}