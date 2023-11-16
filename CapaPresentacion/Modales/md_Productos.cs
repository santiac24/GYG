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

namespace CapaPresentacion.Modales
{
    public partial class md_Productos : Form
    {

        public Prendas _Prendas { get; set; }
        public md_Productos()
        {
            InitializeComponent();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void md_Productos_Load(object sender, EventArgs e)
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


            //mostramos a todos los productos
            List<Prendas> listaprendas = new CN_Prendas().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Prendas item in listaprendas)
            {
                dgvdata.Rows.Add(new object[] { item.Id_prenda, item.Prenda, item.Subcategoria_id.subcategoria, item.Subcategoria_id.Id_subcategoria, item.Cantidad_dispo, item.Precio_compra, item.Precio_venta });
            }
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iCol = e.ColumnIndex;

            if (iRow >= 0 && iCol > 0)
            {
                _Prendas = new Prendas()
                {
                    Id_prenda = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Id"].Value.ToString()),
                    Prenda = dgvdata.Rows[iRow].Cells["Prenda"].Value.ToString(),
                    Subcategoria_id = new SubCategorias()
                    {
                        subcategoria = dgvdata.Rows[iRow].Cells["Subcategoria"].Value.ToString(),
                        Id_subcategoria = Convert.ToInt32(dgvdata.Rows[iRow].Cells["IdSubcategoria"].Value.ToString())

                    },
                    Cantidad_dispo = Convert.ToInt32(dgvdata.Rows[iRow].Cells["Stock"].Value.ToString()),
                    Precio_compra = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["PrecioCompra"].Value.ToString()),
                    Precio_venta = Convert.ToDecimal(dgvdata.Rows[iRow].Cells["PrecioVenta"].Value.ToString()),

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

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
