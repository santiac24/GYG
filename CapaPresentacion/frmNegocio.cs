using CapaEntidad;
using CapaNegocio;
using DocumentFormat.OpenXml.Drawing.Charts;
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
    public partial class frmNegocio : Form
    {
        public frmNegocio()
        {
            InitializeComponent();
        }

        //Método para convertir array de bytes en imagen
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);

            return imagen;
        }
        private void frmNegocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                picLogo.Image = ByteToImage(byteimagen);
            }

            Negocio datos = new CN_Negocio().ObtenerDatos();

            txtnombrenegocio.Text = datos.Nombre;
            txtnit.Text = datos.NIT;
            txtdireccion.Text = datos.Direccion;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsubirimagen_Click(object sender, EventArgs e)
        {
            String mensaje = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileName = "Files|*.jpg;*jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                byte[] byteimage = File.ReadAllBytes(ofd.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteimage, out mensaje);

                if (respuesta)
                {
                    picLogo.Image = ByteToImage(byteimage);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Negocio obj = new Negocio()
            {
                Nombre = txtnombrenegocio.Text,
                NIT = txtnit.Text,
                Direccion = txtdireccion.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta) {
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("No se pudieron guardar los cambios" + mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
