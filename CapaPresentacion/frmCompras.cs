using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Modales;
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
    public partial class frmCompras : Form
    {

        private Usuarios _Usuario;
        public frmCompras(Usuarios oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(txtidproveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proceedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Subtotal", typeof(decimal));

            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                detalle_compra.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt32(row.Cells["IdProducto"].Value.ToString()),
                        row.Cells["Cantidad"].Value.ToString(),
                        row.Cells["PrecioCompra"].Value.ToString(),
                        row.Cells["PrecioVenta"].Value.ToString(),
                        row.Cells["Subtotal"].Value.ToString(),
                    });
            }
            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            string numerodocumento = string.Format("{0:00000}", idcorrelativo);

            Compras oCampra = new Compras()
            {
                o_usuario = new Usuarios() { Id_usuario = _Usuario.Id_usuario },
                o_Provedor = new Provedores() { Id_provedor = Convert.ToInt32(txtidproveedor.Text) },
                NumeroDocumento = numerodocumento,
                Valor = Convert.ToDecimal(txttotalapagar.Text),
                TipoDocumento = ((OpcionesCombo)cbotipodocumento.SelectedItem).Texto,
            };
            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCampra, detalle_compra, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("numero de compra generado:\n" + numerodocumento + "\n\nDesea copiar al portapapeles?",
                    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    Clipboard.SetText(numerodocumento);

                txtidproveedor.Text = "0";
                txtnrodocumento.Text = "";
                txtnombreprovedor.Text = "";
                dgvdata.Rows.Clear();
                CalcularTotal();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void labelregistrarcompra_Click(object sender, EventArgs e)
        {
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cbotipodocumento.Items.Add(new OpcionesCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbotipodocumento.Items.Add(new OpcionesCombo() { Valor = "Factura", Texto = "Factura" });
            cbotipodocumento.DisplayMember = "Texto";
            cbotipodocumento.ValueMember = "Valor";
            cbotipodocumento.SelectedIndex = 0;

            txtfecha.Text = DateTime.Now.ToString();

            txtidproveedor.Text = "0";
            txtnoutilporahora.Text = "0";
        }

        private void btnBuscarDocumento_Click(object sender, EventArgs e)
        {
            using (var modal = new md_Provedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtidproveedor.Text = modal._Provedor.Id_provedor.ToString();
                    //txtnrodocumento.Text = modal._Provedor.
                    txtnombreprovedor.Text = modal._Provedor.Provedor.ToString();
                }
                else
                {
                    txtnrodocumento.Select();
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new md_Productos())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtiddelproducto.Text = modal._Prendas.Id_prenda.ToString();
                    txtproducto.Text = modal._Prendas.Prenda.ToString();

                }
                else
                {
                    txtnrodocumento.Select();
                }
            }
        }

        private void txtiddelproducto_KeyDown(object sender, KeyEventArgs e)
        {
            //Acá irá el código cuando se escane con código de barras cap15
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal preciocompra = 0;
            decimal precioventa = 0;
            bool producto_existe = false;

            //Válidaciones en la capa de presentación (Dios mío)
            if (string.IsNullOrEmpty(txtiddelproducto.Text))
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            if (int.Parse(txtiddelproducto.Text) < 0)
            {
                MessageBox.Show("El id del producto no es valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            //Validamos que los precios de compra y venta sean mayores que cero

            if (string.IsNullOrEmpty(txtpreciocompra.Text))
            {
                MessageBox.Show("Se debe ingresar un precio de compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            if (string.IsNullOrEmpty(txtprecioventa.Text))
            {
                MessageBox.Show("Se debe ingresar un precio de venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            if (int.Parse(txtpreciocompra.Text) < 0)
            {
                MessageBox.Show("Precio de compra no puede ser negativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            if (int.Parse(txtprecioventa.Text) < 0)
            {
                MessageBox.Show("Precio de venta no puede ser negativo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            //Validación de formatos de moneda
            if (!decimal.TryParse(txtpreciocompra.Text, out preciocompra))
            {
                MessageBox.Show("Precio Compra - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            if (!decimal.TryParse(txtprecioventa.Text, out precioventa))
            {
                MessageBox.Show("Precio Venta - Formato moneda incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; //Para que acabe
            }

            foreach (DataGridViewRow fila in dgvdata.Rows)
            {
                Console.WriteLine(fila.ToString());
                var idProductoCellValue = fila.Cells["IdProducto"].Value;
                if (idProductoCellValue != null && idProductoCellValue.ToString() == txtiddelproducto.Text)
                {
                    producto_existe = true;
                    break;
                }
            }


            if (!producto_existe)
            {
                dgvdata.Rows.Add(new object[]
                {
                    txtiddelproducto.Text,
                    txtproducto.Text,
                    txtpreciocompra.Text,
                    txtprecioventa.Text,
                    txtcantidad.Text,
                    (txtcantidad.Value * decimal.Parse(txtpreciocompra.Text)).ToString()
                });
            }
            else
            {
                MessageBox.Show("La prenda ya se ha registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CalcularTotal();
            LimpiarProducto();
            txtiddelproducto.Select();

        }

        private void LimpiarProducto()
        {
            txtiddelproducto.Text = "0";
            txtproducto.Text = "";
            txtpreciocompra.Text = "";
            txtprecioventa.Text = "";
            txtcantidad.Value = 1;

        }

        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvdata.Rows)
                {
                    // Verificar si la celda "SubTotal" no es nula y si su valor es una cadena válida.
                    if (fila.Cells["SubTotal"].Value != null)
                    {
                        string valorSubTotal = fila.Cells["SubTotal"].Value.ToString();
                        decimal subTotal;
                        if (decimal.TryParse(valorSubTotal, out subTotal))
                        {
                            total += subTotal;
                        }
                        else
                        {
                            // Manejar el caso en el que el valor no sea una cadena válida para decimal
                        }
                    }
                    else
                    {
                        // Manejar el caso en el que la celda "SubTotal" sea nula
                    }
                }
            }
            txttotalapagar.Text = total.ToString();
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 6)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete.Width;
                var h = Properties.Resources.delete.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        private void dgvdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvdata.CurrentRow.Selected = true;

            if (dgvdata.Columns[e.ColumnIndex].Name == "btnEliminar")
            {

                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvdata.Rows.RemoveAt(indice);
                    CalcularTotal();
                }
            }
        }

        private void txtpreciocompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtprecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
