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
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorial.Refresh();
            dgvHistorial.DataSource = Historial.listaHistorial;
            dgvHistorial.Columns[0].HeaderText = "Producto";
            dgvHistorial.Columns[3].Visible = false;
        }
    }
}
