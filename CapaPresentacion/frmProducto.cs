using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
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
            foreach (SubCategorias item in listaSubcategoria)
            {
                cbsubcategoria.Items.Add(new OpcionesCombo() { Valor = item.Id_subcategoria, Texto = item.subcategoria });
            }

            foreach (Tallas item in listaTalla)
            {
                cbtalla.Items.Add(new OpcionesCombo() { Valor = item.Id_talla, Texto = item.Talla });
            }

            foreach (Colores item in listaColor)
            {
                cbcolor.Items.Add(new OpcionesCombo() { Valor = item.Id_color, Texto = item.Color });
            }
            //Definimos caracteristicas por defecto para el combo box
            cbsubcategoria.DisplayMember = "Texto";
            cbsubcategoria.ValueMember = "Valor";
            cbsubcategoria.SelectedIndex = 0;

            cbtalla.DisplayMember = "Texto";
            cbtalla.ValueMember = "Valor";
            cbtalla.SelectedIndex = 0;

            cbcolor.DisplayMember = "Texto";
            cbcolor.ValueMember = "Valor";
            cbcolor.SelectedIndex = 0;

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
                dgvdata.Rows.Add(new object[] { "", item.Id_prenda, item.Prenda, item.Cantidad_dispo, item.Precio_compra, item.Precio_venta, item.Subcategoria_id.Id_subcategoria, item.Subcategoria_id.subcategoria, item.Talla_id.Id_talla, item.Talla_id.Talla, item.Color_id.Id_color, item.Color_id.Color });
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Prendas obj = new Prendas()
                    {
                        Id_prenda = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Prendas().Eliminar(obj, out mensaje);

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

        private void btnguardar_Click(object sender, EventArgs e)
        {


            string mensaje = string.Empty;

            Prendas obj = new Prendas()
            {
                Id_prenda = Convert.ToInt32(txtid.Text),
                Prenda = txtprenda.Text,
                Cantidad_dispo = Convert.ToInt32(txtcantidaddisponible.Text),
                Precio_compra = Convert.ToInt32(txtpreciocompra.Text),
                Precio_venta = Convert.ToInt32(txtprecioventa.Text),
                Subcategoria_id = new SubCategorias()
                {
                    Id_subcategoria = Convert.ToInt32(((OpcionesCombo)cbsubcategoria.SelectedItem).Valor)
                },
                Talla_id = new Tallas()
                {
                    Id_talla = Convert.ToInt32(((OpcionesCombo)cbtalla.SelectedItem).Valor)
                },
                Color_id = new Colores()
                {
                    Id_color = Convert.ToInt32(((OpcionesCombo)cbcolor.SelectedItem).Valor)
                },

            };
            if (obj.Id_prenda == 0)
            {
                int id = new CN_Prendas().Registrar(obj, out mensaje);

                if (id != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", txtid.Text, txtprenda.Text, txtcantidaddisponible.Text, txtpreciocompra.Text, txtprecioventa.Text, ((OpcionesCombo)cbsubcategoria.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbsubcategoria.SelectedItem).Texto.ToString(), ((OpcionesCombo)cbtalla.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbtalla.SelectedItem).Texto.ToString(), ((OpcionesCombo)cbcolor.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbcolor.SelectedItem).Texto.ToString() });
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resutado = new CN_Prendas().Editar(obj, out mensaje);

                if (resutado)
                {

                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];//fila seleccionada
                    row.Cells["Id_prenda"].Value = txtid.Text;
                    row.Cells["Prenda"].Value = txtprenda.Text;
                    row.Cells["Disponible"].Value = txtcantidaddisponible.Text;
                    row.Cells["Precio compra"].Value = txtpreciocompra.Text;
                    row.Cells["Precio venta"].Value = txtprecioventa.Text;

                    row.Cells["Subcategoria_id"].Value = ((OpcionesCombo)cbsubcategoria.SelectedItem).Valor.ToString();
                    row.Cells["Subcategoria"].Value = ((OpcionesCombo)cbsubcategoria.SelectedItem).Texto.ToString();

                    row.Cells["Talla_id"].Value = ((OpcionesCombo)cbtalla.SelectedItem).Valor.ToString();
                    row.Cells["Talla"].Value = ((OpcionesCombo)cbtalla.SelectedItem).Texto.ToString();

                    row.Cells["Color_id"].Value = ((OpcionesCombo)cbcolor.SelectedItem).Valor.ToString();
                    row.Cells["Color"].Value = ((OpcionesCombo)cbcolor.SelectedItem).Texto.ToString();

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
            txtprenda.Text = "";
            txtcantidaddisponible.Text = "";
            txtprecioventa.Text = "";
            txtpreciocompra.Text = "";
            cbsubcategoria.SelectedIndex = 0;
            cbtalla.SelectedIndex = 0;
            cbcolor.SelectedIndex = 0;
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
        //----------------------------------------------------
        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
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
            txtbusqueda.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
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
                    txtid.Text = dgvdata.Rows[indice].Cells["Id_prenda"].Value.ToString();
                    txtprenda.Text = dgvdata.Rows[indice].Cells["Prenda"].Value.ToString();
                    txtcantidaddisponible.Text = dgvdata.Rows[indice].Cells["Cantidad_dispo"].Value.ToString();
                    txtpreciocompra.Text = dgvdata.Rows[indice].Cells["Precio_compra"].Value.ToString();
                    txtprecioventa.Text = dgvdata.Rows[indice].Cells["Precio_venta"].Value.ToString();

                    foreach (OpcionesCombo oc in cbsubcategoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Id_subcategoria"].Value))
                        {
                            int indice_combo = cbsubcategoria.Items.IndexOf(oc);
                            cbsubcategoria.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionesCombo oc in cbtalla.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Id_talla"].Value))
                        {
                            int indice_combo = cbsubcategoria.Items.IndexOf(oc);
                            cbtalla.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                    foreach (OpcionesCombo oc in cbcolor.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Id_color"].Value))
                        {
                            int indice_combo = cbsubcategoria.Items.IndexOf(oc);
                            cbcolor.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if(dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                
                foreach(DataGridViewColumn columna in dgvdata.Columns)
                {
                    if(columna.HeaderText != "" && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText,typeof(string));
                    }
                }
                foreach(DataGridViewRow fila in dgvdata.Rows)
                {
                    if (fila.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString(),
                            fila.Cells[5].Value.ToString(),
                            fila.Cells[7].Value.ToString(),
                            fila.Cells[9].Value.ToString(),
                            fila.Cells[11].Value.ToString()
                        });
                    }
                }
                SaveFileDialog savefile = new SaveFileDialog(); //Dialogo para ver donde guardar el excel
                savefile.FileName = string.Format("ReporteProducto_{0}.xlsx",DateTime.Now.ToString("ddMMyyyyHHmmss")); //Se le da un formato para que se guarde el reporte con fecha
                savefile.Filter = "Excel Files | *.xlsx";  //Para que en la ventana de dialogo solo se muestren archivos xlsx

                if(savefile.ShowDialog() == DialogResult.OK) //Este evento se dispara cuando seleccionamos la ruta donde vamos a guardar
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe"); //Se crea una hoja llamada informe
                        hoja.ColumnsUsed().AdjustToContents(); //Se ajustan las columnas usadas a la hoja de excel
                        wb.SaveAs(savefile.FileName); //Se guarda en la ruta seleccionada
                        MessageBox.Show("Reporte generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
