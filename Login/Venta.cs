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
    public partial class Venta : Form
    {
        public Cliente cliente;

        public Venta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
            MostrarClientes();
        }
        

        /// <summary>
        /// Selecciona un cliente para porder venderle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnSeleccion_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            int index;
            index = DGV_GetFila();
            cliente = DGV_GetCliente(index, cliente);
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
        {
            return dgvClientes.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public Cliente DGV_GetCliente(int index, Cliente c)
        {
            c.Saldo = Convert.ToDecimal(dgvClientes[0, index].Value);
            c.Nombre = dgvClientes[1, index].Value.ToString();
            c.Apellido = dgvClientes[2, index].Value.ToString();
            return c;
        }

        /// <summary>
        /// Muestra los clientes de la listaClientes en el DataGridView
        /// </summary>
        private void MostrarClientes()
        {
            dgvClientes.Refresh();
            //dgvClientes.DataSource = Cliente.ListaClientes;
        }
    }
}