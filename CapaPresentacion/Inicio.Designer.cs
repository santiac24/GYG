namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menu = new MenuStrip();
            menuusuario = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            submenucategoria = new FontAwesome.Sharp.IconMenuItem();
            submenuproducto = new FontAwesome.Sharp.IconMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarventa = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetalleventa = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            submenuregistrarcompra = new FontAwesome.Sharp.IconMenuItem();
            submenuverdetallecompra = new FontAwesome.Sharp.IconMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            menuproveedores = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menutitulo = new MenuStrip();
            vhjToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            lblUsuario = new ToolStripMenuItem();
            contenedor = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            submenunegocio = new ToolStripMenuItem();
            menu.SuspendLayout();
            menutitulo.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuusuario, menumantenedor, menuventas, menucompras, menuclientes, menuproveedores, menureportes, menuacercade });
            menu.Location = new Point(0, 59);
            menu.Name = "menu";
            menu.Size = new Size(846, 73);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            menuusuario.AutoSize = false;
            menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuusuario.IconColor = Color.Black;
            menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuario.IconSize = 50;
            menuusuario.ImageScaling = ToolStripItemImageScaling.None;
            menuusuario.Name = "menuusuario";
            menuusuario.Size = new Size(80, 69);
            menuusuario.Text = "Usuarios";
            menuusuario.TextImageRelation = TextImageRelation.ImageAboveText;
            menuusuario.Click += menuusuario_Click;
            // 
            // menumantenedor
            // 
            menumantenedor.AutoSize = false;
            menumantenedor.DropDownItems.AddRange(new ToolStripItem[] { submenucategoria, submenuproducto, submenunegocio });
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(122, 69);
            menumantenedor.Text = "Mantenedor";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            menumantenedor.Click += iconMenuItem7_Click;
            // 
            // submenucategoria
            // 
            submenucategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            submenucategoria.IconColor = Color.Black;
            submenucategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenucategoria.Name = "submenucategoria";
            submenucategoria.Size = new Size(180, 22);
            submenucategoria.Text = "Categoria";
            submenucategoria.Click += submenucategoria_Click;
            // 
            // submenuproducto
            // 
            submenuproducto.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuproducto.IconColor = Color.Black;
            submenuproducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuproducto.Name = "submenuproducto";
            submenuproducto.Size = new Size(180, 22);
            submenuproducto.Text = "Producto";
            submenuproducto.Click += submenuproducto_Click;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarventa, submenuverdetalleventa });
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(80, 69);
            menuventas.Text = "Ventas";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarventa
            // 
            submenuregistrarventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarventa.IconColor = Color.Black;
            submenuregistrarventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarventa.Name = "submenuregistrarventa";
            submenuregistrarventa.Size = new Size(128, 22);
            submenuregistrarventa.Text = "Registrar";
            submenuregistrarventa.Click += submenuregistrarventa_Click;
            // 
            // submenuverdetalleventa
            // 
            submenuverdetalleventa.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetalleventa.IconColor = Color.Black;
            submenuverdetalleventa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetalleventa.Name = "submenuverdetalleventa";
            submenuverdetalleventa.Size = new Size(128, 22);
            submenuverdetalleventa.Text = "Ver detalle";
            submenuverdetalleventa.Click += submenuverdetalleventa_Click;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.DropDownItems.AddRange(new ToolStripItem[] { submenuregistrarcompra, submenuverdetallecompra });
            menucompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(80, 69);
            menucompras.Text = "Compras";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // submenuregistrarcompra
            // 
            submenuregistrarcompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuregistrarcompra.IconColor = Color.Black;
            submenuregistrarcompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuregistrarcompra.Name = "submenuregistrarcompra";
            submenuregistrarcompra.Size = new Size(128, 22);
            submenuregistrarcompra.Text = "Registrar";
            submenuregistrarcompra.Click += submenuregistrarcompra_Click;
            // 
            // submenuverdetallecompra
            // 
            submenuverdetallecompra.IconChar = FontAwesome.Sharp.IconChar.None;
            submenuverdetallecompra.IconColor = Color.Black;
            submenuverdetallecompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            submenuverdetallecompra.Name = "submenuverdetallecompra";
            submenuverdetallecompra.Size = new Size(128, 22);
            submenuverdetallecompra.Text = "Ver detalle";
            submenuverdetallecompra.Click += submenuverdetallecompra_Click;
            // 
            // menuclientes
            // 
            menuclientes.AutoSize = false;
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 50;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(80, 69);
            menuclientes.Text = "Clientes";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            menuclientes.Click += menuclientes_Click;
            // 
            // menuproveedores
            // 
            menuproveedores.AutoSize = false;
            menuproveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            menuproveedores.IconColor = Color.Black;
            menuproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuproveedores.IconSize = 50;
            menuproveedores.ImageScaling = ToolStripItemImageScaling.None;
            menuproveedores.Name = "menuproveedores";
            menuproveedores.Size = new Size(80, 69);
            menuproveedores.Text = "Proveedores";
            menuproveedores.TextImageRelation = TextImageRelation.ImageAboveText;
            menuproveedores.Click += menuproveedores_Click;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(80, 69);
            menureportes.Text = "Reportes";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            menureportes.Click += menureportes_Click;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(80, 69);
            menuacercade.Text = "Acerca de";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            menuacercade.Click += iconMenuItem1_Click;
            // 
            // menutitulo
            // 
            menutitulo.AutoSize = false;
            menutitulo.BackColor = Color.SteelBlue;
            menutitulo.Items.AddRange(new ToolStripItem[] { vhjToolStripMenuItem, usuarioToolStripMenuItem, lblUsuario });
            menutitulo.Location = new Point(0, 0);
            menutitulo.Name = "menutitulo";
            menutitulo.RightToLeft = RightToLeft.No;
            menutitulo.Size = new Size(846, 59);
            menutitulo.TabIndex = 1;
            menutitulo.Text = "menuStrip2";
            menutitulo.ItemClicked += menutitulo_ItemClicked;
            // 
            // vhjToolStripMenuItem
            // 
            vhjToolStripMenuItem.AutoSize = false;
            vhjToolStripMenuItem.Font = new Font("Microsoft YaHei", 15F, FontStyle.Bold, GraphicsUnit.Point);
            vhjToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            vhjToolStripMenuItem.Name = "vhjToolStripMenuItem";
            vhjToolStripMenuItem.Overflow = ToolStripItemOverflow.AsNeeded;
            vhjToolStripMenuItem.Size = new Size(200, 55);
            vhjToolStripMenuItem.Text = "Sistema de Ventas";
            vhjToolStripMenuItem.Click += vhjToolStripMenuItem_Click;
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(62, 55);
            usuarioToolStripMenuItem.Text = "Usuario:";
            usuarioToolStripMenuItem.Click += usuarioToolStripMenuItem_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(71, 55);
            lblUsuario.Text = "lblusuario";
            // 
            // contenedor
            // 
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 132);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(846, 313);
            contenedor.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // submenunegocio
            // 
            submenunegocio.Name = "submenunegocio";
            submenunegocio.Size = new Size(180, 22);
            submenunegocio.Text = "Negocio";
            submenunegocio.Click += submenunegocio_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 445);
            Controls.Add(contenedor);
            Controls.Add(menu);
            Controls.Add(menutitulo);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Inicio";
            SizeGripStyle = SizeGripStyle.Show;
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += Inicio_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            menutitulo.ResumeLayout(false);
            menutitulo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuproveedores;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private Panel contenedor;
        private ContextMenuStrip contextMenuStrip1;
        public MenuStrip menutitulo;
        public ToolStripMenuItem vhjToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem submenucategoria;
        private FontAwesome.Sharp.IconMenuItem submenuproducto;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem lblUsuario;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarventa;
        private FontAwesome.Sharp.IconMenuItem submenuverdetalleventa;
        private FontAwesome.Sharp.IconMenuItem submenuregistrarcompra;
        private FontAwesome.Sharp.IconMenuItem submenuverdetallecompra;
        private ToolStripMenuItem submenunegocio;
    }
}