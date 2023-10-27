using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCategoria_Load(object sender, EventArgs e)
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


            //mostramos a todos los Categorias
            List<Categorias> listaCategorias = new CN_Categoria().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Categorias item in listaCategorias)
            {
                dgvdata.Rows.Add(new object[] { "", item.Id_categoria,
                    item.Categoria
                });
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string mensaje = string.Empty;

            Categorias obj = new Categorias()
            {
                Id_categoria = Convert.ToInt32(txtid.Text),
                Categoria = txtCategoria.Text
            };

            if (obj.Id_categoria == 0)
            {
                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "",
                        idgenerado, txtCategoria.Text
                    });
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resutado = new CN_Categoria().Editar(obj, out mensaje);

                if (resutado)
                {

                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];//fila seleccionada
                    row.Cells["Id"].Value = txtid.Text;
                    row.Cells["Categoria"].Value = txtCategoria.Text;
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }

        }

        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtid.Text = "0";
            txtCategoria.Text = "";
            txtCategoria.Select();
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
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categorias obj = new Categorias()
                    {
                        Id_categoria = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Categoria().Eliminar(obj, out mensaje);

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

        private void btnlimpiarbuscador1_Click(object sender, EventArgs e)
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

        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvdata.CurrentRow.Selected = true;
            if (dgvdata.Columns[e.ColumnIndex].Name == "seleccion")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtid.Text = dgvdata.Rows[indice].Cells["Id"].Value.ToString();
                    txtCategoria.Text = dgvdata.Rows[indice].Cells["Categoria"].Value.ToString();

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
