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
            List<Roles> listaRol = new CN_Rol().Listar();

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
            foreach (DataGridViewColumn columna in dgvusuarios.Columns)
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
                dgvusuarios.Rows.Add(new object[] { "", item.Id_usuario, item.Nombre, item.Usuario, item.Contrasena, item.o_Rol.Id_rol, item.o_Rol.rol });
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuarios objusuario = new Usuarios()
                    {
                        Id_usuario = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvusuarios.Rows.RemoveAt(Convert.ToInt32(txtid.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Usuarios objusario = new Usuarios()
            {
                Id_usuario = Convert.ToInt32(txtid.Text),
                Nombre = txtNombreCompleto.Text,
                Contrasena = txtClave.Text,
                o_Rol = new Roles()
                {
                    Id_rol = Convert.ToInt32(((OpcionesCombo)cbrol.SelectedItem).Valor)
                },
                Usuario = txtNombreUsuario.Text
            };
            if (objusario.Id_usuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvusuarios.Rows.Add(new object[] { "", txtid.Text, txtNombreCompleto.Text, txtNombreUsuario.Text, txtClave.Text, ((OpcionesCombo)cbrol.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbrol.SelectedItem).Texto.ToString() });
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resutado = new CN_Usuario().Editar(objusario, out mensaje);

                if (resutado)
                {

                    DataGridViewRow row = dgvusuarios.Rows[Convert.ToInt32(txtid.Text) - 1];//fila seleccionada
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtNombreCompleto.Text;
                    row.Cells["Usuario"].Value = txtNombreUsuario.Text;
                    row.Cells["contraseña"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionesCombo)cbrol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionesCombo)cbrol.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvusuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //Que no concidere seleccionar la cavecera
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check.Width;
                var h = Properties.Resources.check.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvusuarios.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtid.Text = dgvusuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtNombreCompleto.Text = dgvusuarios.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtNombreUsuario.Text = dgvusuarios.Rows[indice].Cells["Usuario"].Value.ToString();
                    txtClave.Text = dgvusuarios.Rows[indice].Cells["Contrasena"].Value.ToString();
                    txtConfirmarClave.Text = dgvusuarios.Rows[indice].Cells["Contrasena"].Value.ToString();

                    foreach (OpcionesCombo oc in cbrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvusuarios.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cbrol.Items.IndexOf(oc);
                            cbrol.SelectedIndex = indice_combo;
                            break;
                        }
                    }

                }
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
