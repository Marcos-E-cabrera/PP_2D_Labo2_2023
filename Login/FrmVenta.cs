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
        #region CAMPOS
        private int saldo;
        private string nombre;
        private string apellido;
        private List<VenderACliente> ListaCliente;
        #endregion

        #region PROPIEDADES
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Saldo { get; set; }
        #endregion

        #region FRM VENTA CONSTRUCTOR
        public FrmVenta()
        {
            InitializeComponent();
            ListaCliente = new List<VenderACliente>();
            ListaCliente.Add(new VenderACliente("Nonah", "Dingle", 500));
            ListaCliente.Add(new VenderACliente("Gage", "Withringten", 3737));
            ListaCliente.Add(new VenderACliente("Zenia", "Ferrotti", 9793));
            ListaCliente.Add(new VenderACliente("Diann", "Gaitung", 19855));
            ListaCliente.Add(new VenderACliente("Gena", "Lembrick", 13681));
            ListaCliente.Add(new VenderACliente("Susanna", "Childe", 4885));
            ListaCliente.Add(new VenderACliente("Broderic", "Scintsbury", 4213));
            ListaCliente.Add(new VenderACliente("Frederique", "Rowesby", 7223));
            ListaCliente.Add(new VenderACliente("Abagael", "Cramphorn", 18678));
            ListaCliente.Add(new VenderACliente("Kelsi", "Kinver", 12232));
            ListaCliente.Add(new VenderACliente("Luca", "Morkham", 16142));
            ListaCliente.Add(new VenderACliente("Brigg", "Winckles", 2880));
            ListaCliente.Add(new VenderACliente("Malorie", "McCague", 14862));
            ListaCliente.Add(new VenderACliente("Daisey", "Ateggart", 8772));
            ListaCliente.Add(new VenderACliente("Cathi", "Heighway", 16726));
            ListaCliente.Add(new VenderACliente("Ardys", "Belding", 4869));
            ListaCliente.Add(new VenderACliente("Katinka", "Huggard", 13916));
            ListaCliente.Add(new VenderACliente("Mab", "Falco", 14626));
            ListaCliente.Add(new VenderACliente("Fairfax", "Clines", 17337));
            ListaCliente.Add(new VenderACliente("Meridel", "Desorts", 14010));
            ListaCliente.Add(new VenderACliente("Goldarina", "Iannuzzelli", 4444));
            ListaCliente.Add(new VenderACliente("Alvinia", "Vian", 731));
            ListaCliente.Add(new VenderACliente("Leonie", "Jaskowicz", 11462));
        }
        #endregion

        #region LOAD
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
            MostrarClientes();
        }
        #endregion

        #region SELECCIONAR CLIENTE
        /// <summary>
        /// Selecciona un cliente para porder venderle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnSeleccion_Click(object sender, EventArgs e)
        {
            int index;
            index = ObtenerPosicionFilaDGV();

            VenderACliente cliente = new VenderACliente();
            cliente = ObtenerClienteDGV(index, cliente);

            Nombre = cliente.Nombre;
            Apellido = cliente.Apellido;
            Saldo = cliente.Saldo;

            this.DialogResult = DialogResult.OK;
        }
        #endregion

        #region SALIR
        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int ObtenerPosicionFilaDGV()
        {
            int posicion;
            return posicion = dgvClientes.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public VenderACliente ObtenerClienteDGV(int index, VenderACliente p)
        {
            p.Nombre = dgvClientes[0, index].Value.ToString();
            p.Apellido = dgvClientes[1, index].Value.ToString();
            p.Saldo = Convert.ToInt32(dgvClientes[2, index].Value);
            return p;
        }

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public static void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra los productos de la listaProductos en el DataGridView
        /// </summary>
        private void MostrarClientes()
        {
            dgvClientes.Refresh();
            dgvClientes.DataSource = ListaCliente;
        }
        #endregion
    }
}
