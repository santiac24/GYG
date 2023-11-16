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

namespace CapaPresentacion.Modales
{
    public partial class md_Provedor : Form
    {
        public Provedores _Provedor { get; set; }


        public md_Provedor()
        {
            InitializeComponent();
        }


        private void md_Provedor_Load(object sender, EventArgs e)
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


            //mostramos a todos los usuarios
            List<Provedores> listaProvedores = new CN_Provedor().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Provedores item in listaProvedores)
            {
                dgvdata.Rows.Add(new object[] { item.Id_provedor, item.Provedor, item.Correo, item.Telefono });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
                _Provedor = new Provedores()
                {
                    Id_provedor = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdProvedor"].Value.ToString()),
                    Provedor = dgvdata.Rows[iRow].Cells["Provedor"].Value.ToString(),
                    Correo = dgvdata.Rows[iRow].Cells["Correo"].Value.ToString(),
                    Telefono = dgvdata.Rows[iRow].Cells["Telefono"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
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


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
