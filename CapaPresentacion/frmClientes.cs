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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        /*private void frmClientes_Load(object sender, EventArgs e)
        {

            //Para agregar al Combobox de roles, los roles posibles
            //Traemos todos los roles y los guardamos en una lista
            List<Sexos> listaSexo = new CN_Sexo().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Sexos item in listaSexo)
            {
                cbsexo.Items.Add(new OpcionesCombo() { Valor = item.Id_sexo, Texto = item.Sexo });
            }

            //Definimos caracteristicas por defecto para el combo box
            cbsexo.DisplayMember = "Texto";
            cbsexo.ValueMember = "Valor";
            cbsexo.SelectedIndex = 0;

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
            List<Clientes> listaClientes = new CN_Cliente().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Clientes item in listaClientes)
            {
                dgvdata.Rows.Add(new object[] { "", item.Id_cliente, item.Nombre, item.Cedula, item.Celular, item.Direccion,item.o_Sexo.Id_sexo, item.o_Sexo.Sexo });
            }
        }*/

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            // Para agregar al Combobox de sexos
            //Traemos todos los roles y los guardamos en una lista
            List<Roles> listaRol = new CN_Rol().Listar();
            List<Sexos> listaSexo = new CN_Sexo().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Sexos item in listaSexo)
            {
                cbsexo.Items.Add(new OpcionesCombo() { Valor = item.Id_sexo, Texto = item.Sexo });
            }

            //Definimos caracteristicas por defecto para el combo box
            cbsexo.DisplayMember = "Texto";
            cbsexo.ValueMember = "Valor";
            cbsexo.SelectedIndex = 0;

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

            //mostramos a todos los clientes
            List<Clientes> listaClientes = new CN_Cliente().Listar();

            //Recorremos cada uno de los elementos de la lista para agregarlos en el combo box
            foreach (Clientes item in listaClientes)
            {
                dgvdata.Rows.Add(new object[] { "", item.Id_cliente, item.Nombre, item.Cedula, item.Celular,item.Direccion, item.Fecha_nacimiento, item.o_Sexo.Id_sexo, item.o_Sexo.Sexo,
                });
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Clientes objcliente = new Clientes()
            {
                Id_cliente = Convert.ToInt32(txtid.Text),
                Nombre = txtNombreCompleto.Text,
                Cedula = txtCedula.Text,
                Celular = txtCelular.Text,
                Direccion = txtDireccion.Text,
                Fecha_nacimiento = txtFechaNacimiento.Text,
                o_Sexo = new Sexos()
                {
                    Id_sexo = Convert.ToInt32(((OpcionesCombo)cbsexo.SelectedItem).Valor)
                }
            };
            if (objcliente.Id_cliente == 0)
            {
                int idclientegenerado = new CN_Cliente().Registrar(objcliente, out mensaje);

                if (idclientegenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] { "", txtid.Text, txtNombreCompleto.Text, txtCedula.Text, txtCelular.Text, ((OpcionesCombo)cbsexo.SelectedItem).Valor.ToString(), ((OpcionesCombo)cbsexo.SelectedItem).Texto.ToString() });
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resutado = new CN_Cliente().Editar(objcliente, out mensaje);

                if (resutado)
                {

                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];//fila seleccionada
                    row.Cells["Id_cliente"].Value = txtid.Text;
                    row.Cells["Nombre"].Value = txtNombreCompleto.Text;
                    row.Cells["Cedula"].Value = txtCedula.Text;
                    row.Cells["Celular"].Value = txtCelular.Text;
                    row.Cells["Direccion"].Value = txtFechaNacimiento.Text;
                    row.Cells["Fecha_nacimiento"].Value = txtFechaNacimiento.Text;
                    row.Cells["Id_sexo"].Value = ((OpcionesCombo)cbsexo.SelectedItem).Valor.ToString();
                    row.Cells["Sexo"].Value = ((OpcionesCombo)cbsexo.SelectedItem).Texto.ToString();

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
            txtCedula.Text = "";
            txtCelular.Text = "";
            txtDireccion.Text = "";
            cbsexo.SelectedIndex = 0;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtid.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Clientes objcliente = new Clientes()
                    {
                        Id_cliente = Convert.ToInt32(txtid.Text)
                    };
                    bool respuesta = new CN_Cliente().Eliminar(objcliente, out mensaje);

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

        private void cbbusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    txtid.Text = dgvdata.Rows[indice].Cells["Id_cliente"].Value.ToString();
                    txtNombreCompleto.Text = dgvdata.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtCedula.Text = dgvdata.Rows[indice].Cells["cedula"].Value.ToString();
                    txtCelular.Text = dgvdata.Rows[indice].Cells["Celular"].Value.ToString();
                    txtDireccion.Text = dgvdata.Rows[indice].Cells["Direccion"].Value.ToString();
                    txtFechaNacimiento.Text = dgvdata.Rows[indice].Cells["fechaNacimiento"].Value.ToString();
                    foreach (OpcionesCombo oc in cbsexo.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["Id_sexo"].Value))
                        {
                            int indice_combo = cbsexo.Items.IndexOf(oc);
                            cbsexo.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
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
    }
}
