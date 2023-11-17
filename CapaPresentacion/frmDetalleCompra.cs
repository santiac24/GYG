using CapaEntidad;
using CapaNegocio;
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
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compras ocompra = new CN_Compra().ObtenerCompra(txtid.Text);

            if(ocompra.Id_compra != 0)
            {
                txtfecha.Text = ocompra.Fecha;
                txttipodocumento.Text = ocompra.TipoDocumento;
                txtusuario.Text = ocompra.o_usuario.Nombre;
                txtidprovedor.Text = (ocompra.o_Provedor.Id_provedor).ToString();
                txtnombreproveedor.Text = ocompra.o_Provedor.Provedor;

                dgvdata.Rows.Clear();
                foreach(Detalles_compras dc in ocompra.Odetalle_compra)
                {
                    dgvdata.Rows.Add(new object[]{ dc.Prenda_id.Prenda, dc.Precio_compra_unidad, dc.Cantidad, dc.Subtotal});
                }
                txttotal.Text = ocompra.Valor.ToString("0.00");
            }
        }
    }
}
