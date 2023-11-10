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
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                        Limpiar();
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
                    dgvdata.Rows.Add(new object[] { "", txtid.Text, txtNombreCompleto.Text, txtNombreUsuario.Text, txtClave.Text, ((OpcionesCombo)cbrol.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbrol.SelectedItem).Texto.ToString() });
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

                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];//fila seleccionada
                    row.Cells["IdUsuario"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtNombreCompleto.Text;
                    row.Cells["Usuario"].Value = txtNombreUsuario.Text;
                    row.Cells["contrasena"].Value = txtClave.Text;
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
            txtindice.Text = "-1";
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

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtNombreUsuario.Text = dgvdata.Rows[indice].Cells["Usuario"].Value.ToString();
                    txtClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();
                    txtConfirmarClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();

                    foreach (OpcionesCombo oc in cbrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
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

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionesCombo)cbbusqueda.SelectedItem).Valor.ToString();
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbusqueda.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else { row.Visible = false; }
                }
            }
        }

        private void btnlimpiarbuscador_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dgvdata.CurrentRow.Selected = true;
            //if (dgvdata.Columns[e.ColumnIndex].Name == "seleccion")
            //{
            //    int indice = e.RowIndex;
            //
            //   if (indice >= 0)
            //    {
            //      txtindice.Text = indice.ToString();
            //        txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
            //        txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
            //        txtNombreUsuario.Text = dgvdata.Rows[indice].Cells["Usuario"].Value.ToString();
            //        txtClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();
            //        txtConfirmarClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();
//
            //        foreach (OpcionesCombo oc in cbrol.Items)
            //      {
            //            if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
            //          {
            //                int indice_combo = cbrol.Items.IndexOf(oc);
            //                cbrol.SelectedIndex = indice_combo;
            //                break;
            //           }
            //        }
            //   }
            //}
            dgvdata.CurrentRow.Selected = true;
            if (dgvdata.Columns[e.ColumnIndex].Name == "Nombre")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtNombreUsuario.Text = dgvdata.Rows[indice].Cells["Usuario"].Value.ToString();
                    txtClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();
                    txtConfirmarClave.Text = dgvdata.Rows[indice].Cells["Contrasena"].Value.ToString();

                    foreach (OpcionesCombo oc in cbrol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_combo = cbrol.Items.IndexOf(oc);
                            cbrol.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void frmUsuarios_Load_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmarClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void cbbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlimpiarbuscador_Click_1(object sender, EventArgs e)
        {

        }

        private void txtindice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
