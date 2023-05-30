using Biblioteca_Carniceria;
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
    public partial class Frm_Historial : Form
    {
        Carrito compraCarrito = new Carrito();

        public Frm_Historial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.Refresh();
            //dgvHistorial.DataSource = compraCarrito.ListaHistorial;
            dgvHistorial.Columns[0].HeaderText = "Producto";
            dgvHistorial.Columns[3].Visible = false;
        }
    }
}
