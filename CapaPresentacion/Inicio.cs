
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuarios usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio(Usuarios objusuario = null)
        {
            if(objusuario == null) //Para que mientras programemos, no nos pida estar logueando
            {
                usuarioActual = new Usuarios() { Usuario = "ADMIN PREDEFINIDO", Id_usuario = 1 };
            } else
            {
                //Se le pasa el usuario de la sesión
                usuarioActual = objusuario;
            }

            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            List<Permisos> ListaPermisos = new CN_Permiso().Listar(usuarioActual.Id_usuario);

            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermisos.Any(m => m.NombreMenu == iconmenu.Name);
                if(encontrado = false)
                {
                    iconmenu.Visible = false;
                }
            }
            lblUsuario.Text = usuarioActual.Usuario;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void vhjToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menutitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {

        }

        

        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }
        private void menuusuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());

        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmCategoria());
        }
        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menumantenedor, new frmProducto());
        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmVentas());
        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuventas, new frmDetalleVenta());
        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmCompras());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menucompras, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());
        }
    }

}



