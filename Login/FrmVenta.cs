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

namespace Frm_Vendedor
{
    public partial class FrmVenta : Form
    {
        private List<VenderACliente> listaCliente = new List<VenderACliente>();

        public FrmVenta()
        {
            InitializeComponent();
            listaCliente.Add(new VenderACliente("Nonah", "Dingle", 500));
            listaCliente.Add(new VenderACliente("Gage", "Withringten", 3737));
            listaCliente.Add(new VenderACliente("Zenia", "Ferrotti", 9793));
            listaCliente.Add(new VenderACliente("Diann", "Gaitung", 19855));
            listaCliente.Add(new VenderACliente("Gena", "Lembrick", 13681));
            listaCliente.Add(new VenderACliente("Susanna", "Childe", 4885));
            listaCliente.Add(new VenderACliente("Broderic", "Scintsbury", 4213));
            listaCliente.Add(new VenderACliente("Frederique", "Rowesby", 7223));
            listaCliente.Add(new VenderACliente("Abagael", "Cramphorn", 18678));
            listaCliente.Add(new VenderACliente("Kelsi", "Kinver", 12232));
            listaCliente.Add(new VenderACliente("Luca", "Morkham", 16142));
            listaCliente.Add(new VenderACliente("Brigg", "Winckles", 2880));
            listaCliente.Add(new VenderACliente("Malorie", "McCague", 14862));
            listaCliente.Add(new VenderACliente("Daisey", "Ateggart", 8772));
            listaCliente.Add(new VenderACliente("Cathi", "Heighway", 16726));
            listaCliente.Add(new VenderACliente("Ardys", "Belding", 4869));
            listaCliente.Add(new VenderACliente("Katinka", "Huggard", 13916));
            listaCliente.Add(new VenderACliente("Mab", "Falco", 14626));
            listaCliente.Add(new VenderACliente("Fairfax", "Clines", 17337));
            listaCliente.Add(new VenderACliente("Meridel", "Desorts", 14010));
            listaCliente.Add(new VenderACliente("Goldarina", "Iannuzzelli", 4444));
            listaCliente.Add(new VenderACliente("Alvinia", "Vian", 731));
            listaCliente.Add(new VenderACliente("Leonie", "Jaskowicz", 11462));
        }   

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        /// <summary>
        /// Muestra los productos de la listaCliente en el DataGridView
        /// </summary>
        private void MostrarClientes()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = listaCliente;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int posicion;

            VenderACliente cliente = new VenderACliente();
            posicion = dgvClientes.CurrentRow.Index;

            cliente.Nombre = dgvClientes[0, posicion].Value.ToString();
            cliente.Apellido = dgvClientes[1, posicion].Value.ToString();
            cliente.Saldo = Convert.ToInt32(dgvClientes[2, posicion].Value);

            MessageBox.Show($"{cliente.Nombre} - {cliente.Apellido} - {cliente.Saldo}");
        }
    }
}
