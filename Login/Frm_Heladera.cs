using Biblioteca_Carniceria;
using Frm_Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Heladera : Form
    {
        Vendedor vendedor;

        public Frm_Heladera()
        {
            InitializeComponent();
        }

        private void Frm_Heladera_Load(object sender, EventArgs e)
        {
            MostrarHeladera();
        }


        private void MostrarHeladera()
        {
            Heladera heladera = new Heladera();
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = Heladera.ListHeladera;
            dgvHeladera.Columns[0].HeaderText = "Producto";
            dgvHeladera.Columns[1].HeaderText = "Precio x Kilo";
            dgvHeladera.Columns[2].HeaderText = "Stock";
            dgvHeladera.Columns[3].HeaderText = "Tipo de Carne";

        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            int index;
            index = DGV_GetFila();
            DGV_GetProducto(index, out producto);

            Frm_Stock frm_Stock = new Frm_Stock(producto);
            if (frm_Stock.ShowDialog() == DialogResult.OK )
            {
                producto = frm_Stock.producto;


                DGV_ActualizarDatos(Heladera.CargarHeladera(index, producto));

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

            p.Nombre = (eCortes)Convert.ToInt32(dgvHeladera[0, index].Value);
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
    }
}
