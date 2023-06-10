using Biblioteca_Carniceria;
using Frm_Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Heladera : Form
    {
        private Vendedor vendedor;
        private Producto producto;

        public Frm_Heladera()
        {
            InitializeComponent();
        }

        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            MostrarHeladera();
            cbxTipo.Items.Add("Vacuno");
            cbxTipo.Items.Add("Ternero");
            cbxTipo.Items.Add("Cerdo");
            cbxTipo.Items.Add("Cordero");
            cbxTipo.Items.Add("Pollo");
            cbxTipo.Items.Add("Procesado");
            cbxTipo.SelectedIndex = 0;
        }


        private void MostrarHeladera()
        {
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = Heladera.ListHeladera;
            dgvHeladera.Columns[0].HeaderText = "Producto";
            dgvHeladera.Columns[1].HeaderText = "Precio x Kilo";
            dgvHeladera.Columns[2].HeaderText = "Stock";
            dgvHeladera.Columns[3].HeaderText = "Tipo de Carne";
        }

        private void btnReponer_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            int index;
            index = DGV_GetFila();
            DGV_GetProducto(index, out producto);

            switch (Vendedor.Reponer(producto, txtStock.Text))
            {
                case 0:
                    DGV_ActualizarDatos(Heladera.CargarHeladera(index, producto));
                    break;
                case 1:
                    MensajeDeError("El stock no puede ser menor a 0 y no puede bajar el stock.", "Error [ 1 ]");
                    break;
                case 2:
                    MensajeDeError("El stock debe ser un número entero/ cantidad no Ingresada.", "Error [ 2 ]");
                    break;
            }
        }

        #region METODOS DGV
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
        {
            return dgvHeladera.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public void DGV_GetProducto(int index, out Producto aux)
        {
            Producto p = new Producto();

            p.Nombre = dgvHeladera[0, index].Value.ToString();
            p.Precio = Convert.ToInt32(dgvHeladera[1, index].Value);
            p.Stock = Convert.ToInt32(dgvHeladera[2, index].Value);
            p.Tipo = (eTipo)Convert.ToInt32(dgvHeladera[3, index].Value);

            aux = p;
        }

        /// <summary>
        /// Carga al DataGridView la nueva "Lista Heladera"
        /// </summary>
        /// <param name="l"></param>
        public void DGV_ActualizarDatos(List<Producto> l)
        {

            dgvHeladera.Refresh();
            dgvHeladera.DataSource = l;
            dgvHeladera.Columns[0].HeaderText = "Producto";
            dgvHeladera.Columns[1].HeaderText = "Precio x Kilo";
            dgvHeladera.Columns[2].HeaderText = "Stock";
            dgvHeladera.Columns[3].HeaderText = "Tipo de Carne";
        }

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            string tipo = cbxTipo.Text;


            switch (Vendedor.Agregar(nombre, precio, stock, tipo))
            {
                case 0:
                    dgvHeladera.DataSource = null;
                    dgvHeladera.DataSource = Vendedor.ListaProductos;
                    break;
                case 1:
                    MensajeDeError("Parametros mal ingresados", "Error [ 1 ]");
                    break;
                case 2:
                    MensajeDeError("Producto ya existente.", "Error [ 2 ]");
                    break;

            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int index = DGV_GetFila();
            Vendedor.ListaProductos.RemoveAt(index);
            dgvHeladera.DataSource = null;
            dgvHeladera.DataSource = Vendedor.ListaProductos;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void dgvHeladera_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dgvHeladera[0, dgvHeladera.CurrentRow.Index].Value.ToString();
            txtPrecio.Text = dgvHeladera[1, dgvHeladera.CurrentRow.Index].Value.ToString();
            txtStock.Text = dgvHeladera[2, dgvHeladera.CurrentRow.Index].Value.ToString();
            cbxTipo.Text = dgvHeladera[3, dgvHeladera.CurrentRow.Index].Value.ToString();
        }
    }
}
