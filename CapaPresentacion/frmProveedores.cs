using CapaDatos;
using CapaEntidad;
using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
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

            //mostramos a todos los proveedores
            List<Provedores> listaProvedores = new CN_Provedor().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Provedores item in listaProvedores)
            {
                dgvdata.Rows.Add(new object[] { "", item.Id_provedor, item.Provedor, item.Telefono, item.Correo,
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Provedores objprovedor = new Provedores()
            {
                Id_provedor = Convert.ToInt32(txtid.Text),
                Provedor = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
            };
            if (objprovedor.Id_provedor == 0)
            {
                int idprovedorgenerado = new CN_Provedor().Registrar(objprovedor, out mensaje);

                if (idprovedorgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", txtid.Text, txtNombre.Text, txtTelefono.Text, txtCorreo.Text });
                }
                else
                {
                    MessageBox.Show(mensaje);
                }

            }
            else
            {
                bool resutado = new CN_Provedor().Editar(objprovedor, out mensaje);

                if (resutado)
                {

                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];//fila seleccionada
                    row.Cells["Id_provedor"].Value = txtid.Text;
                    row.Cells["provedor"].Value = txtNombre.Text;
                    row.Cells["Telefono"].Value = txtTelefono.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;

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
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

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
            dgvdata.CurrentRow.Selected = true;
            if (dgvdata.Columns[e.ColumnIndex].Name == "seleccion")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id_provedor"].Value.ToString();
                    txtNombre.Text = dgvdata.Rows[indice].Cells["Provedor"].Value.ToString();
                    txtTelefono.Text = dgvdata.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                }
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el proveedor?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Provedores objprovedor = new Provedores()
                    {
                        Id_provedor = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Provedor().Eliminar(objprovedor, out mensaje);

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

        private void btnBuscar_Click(object sender, EventArgs e)
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
