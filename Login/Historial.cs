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
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.Refresh();
            dgvHistorial.DataSource = Biblioteca_Carniceria.Historial.listaHistorial;
            dgvHistorial.Columns[0].HeaderText = "Producto";
            dgvHistorial.Columns[3].Visible = false;
        }
    }
}
