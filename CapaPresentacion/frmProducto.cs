using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {


            //Para agregar al Combobox de subcategorias, las categorias posibles
            //Traemos todos loas categorias y los guardamos en una lista
            List<SubCategorias> listaSubcategoria = new CN_Subcategoria().Listar();
            List<Tallas> listaTalla = new CN_Talla().Listar();
            List<Colores> listaColor = new CN_Color().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Roles item in listaRol)
            {
                cbrol.Items.Add(new OpcionesCombo() { Valor = item.Id_rol, Texto = item.rol });
            }

            //Definimos caracteristicas por defecto para el combo box
            cbrol.DisplayMember = "Texto";
            cbrol.ValueMember = "Valor";
            cbrol.SelectedIndex = 0;

            //Agregamos los criterios de búsqueda
            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true)
                {
                    cbbusqueda.Items.Add(new OpcionesCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";
            cbbusqueda.SelectedIndex = 0;


            //mostramos a todos los usuarios
            List<Usuarios> listaUsuarios = new CN_Usuario().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Usuarios item in listaUsuarios)
            {
                dgvdata.Rows.Add(new object[] { "", item.Id_usuario, item.Nombre, item.Usuario, item.Contrasena, item.o_Rol.Id_rol, item.o_Rol.rol });
            }
        }
    }
}
