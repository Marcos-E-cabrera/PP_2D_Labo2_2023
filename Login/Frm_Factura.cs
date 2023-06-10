using Biblioteca_Carniceria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_Factura : Form
    {
        public static Factura factura = new Factura();

        public Frm_Factura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            list_Factura.DataSource = null;
            list_Factura.DataSource = factura.MostrarFactura();
            Factura.PlantillaFactura.Clear();
        }



    }
}
