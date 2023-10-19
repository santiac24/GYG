using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

            //Para agregar al Combobox de roles, los roles posibles
            //Traemos todos los roles y los guardamos en una lista
            List<Rol> listaRol = new CN_Rol().Listar();
            
            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach(Rol item in listaRol)
            {
                cbrol.Items.Add(new OpcionesCombo() { Valor = item.Id_rol, Texto = item.rol});  
            }

            //Definimos caracteristicas por defecto para el combo box
            cbrol.DisplayMember = "Texto";
            cbrol.ValueMember = "Valor";
            cbrol.SelectedIndex = 0;

            //Agregamos los criterios de búsqueda
            foreach (DataGridViewColumn columna in dgvusuarios.Columns)
            {
                if(columna.Visible == true)
                {
                    cbbusqueda.Items.Add(new OpcionesCombo() { Valor = columna.Name, Texto = columna.HeaderText});
                }
            }

            cbbusqueda.DisplayMember = "Texto";
            cbbusqueda.ValueMember = "Valor";
            cbbusqueda.SelectedIndex = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            dgvusuarios.Rows.Add(new object[] {"",txtid.Text,txtNombreCompleto.Text,txtNombreUsuario.Text, txtClave.Text, ((OpcionesCombo)cbrol.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbrol.SelectedItem).Texto.ToString() });

            //Se llama al método limpiar
            Limpiar();

        }

        private void Limpiar()
        {
            txtid.Text = "0";
            txtNombreCompleto.Text = "";
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
            txtConfirmarClave.Text = "";
            cbrol.SelectedIndex = 0;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
