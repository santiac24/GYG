using CapaEntidad;
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
            txtidproducto.Text = "0";
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
                    txtpreciocompra.Text = modal._Prendas.Precio_compra.ToString();
                    txtprecioventa.Text = modal._Prendas.Precio_venta.ToString();

                }
                else
                {
                    txtnrodocumento.Select();
                }
            }
        }
    }
}
