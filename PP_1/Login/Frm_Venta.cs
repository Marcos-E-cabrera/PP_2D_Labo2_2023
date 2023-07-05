using Biblioteca_Carniceria;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class Frm_Venta : Form
    {
        #region CAMPOS
        private Vendedor vendedor;
        private Cliente cliente;

        bool _cambiarCliente = false;
        bool _efectivo = false;
        bool _debito = false;
        bool _factura = false;

        private static List<int> auxIndex = new List<int>();
        #endregion

        #region CONSTRUCTOR
        public Frm_Venta()
        {
            InitializeComponent();
            vendedor = new Vendedor();
            cliente = new Cliente();
        }
        #endregion

        #region LOAD
        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
            MostrarClientes();

            cbxOrdenamiento.Items.Add("Nombre");
            cbxOrdenamiento.Items.Add("Precio");
            cbxOrdenamiento.Items.Add("Stock");
            cbxOrdenamiento.Items.Add("Detalle");

            MostrarCarrito();
            MostrarHeladera();
        }
        #endregion

        #region SELECCION DE CLIENTE
        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            int index;

            if (!_cambiarCliente)
            {

                _cambiarCliente = true;
                index = DGV_GetFila();

                cliente.Nombre = dgvClientes[0, index].Value.ToString();
                cliente.Apellido = dgvClientes[1, index].Value.ToString();
                cliente.Saldo = (float)Convert.ToDecimal(dgvClientes[2, index].Value);

                vendedor.getMontoCliente(cliente);

                Vendedor.clienteCargado = true;
                auxIndex.Add(index);

                MensajeOK($"Cliente: {cliente.Nombre} {cliente.Apellido}, Saldo: {cliente.Saldo}", "Cliente Seleccionado");
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres cambiar de Cliente?", "Confirmación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    index = DGV_GetFila();
                    cliente.Nombre = dgvClientes[0, index].Value.ToString();
                    cliente.Apellido = dgvClientes[1, index].Value.ToString();
                    cliente.Saldo = (float)Convert.ToDecimal(dgvClientes[2, index].Value);


                    foreach (int item in auxIndex)
                    {
                        if (item == index)
                        {
                            MensajeError("Cliente ya Seleccionado, seleccione otro.", "Error [ 1 ]");
                        }
                        else
                        {
                            vendedor.getMontoCliente(cliente);
                            Vendedor.clienteCargado = true;
                            MensajeOK($"Cliente: {cliente.Nombre} {cliente.Apellido}, Saldo: {cliente.Saldo}", "Cliente Seleccionado");
                        }
                    }
                    auxIndex.Clear();
                    auxIndex.Add(index);
                }
            }
            lb_Dinero.Text = $" $ {Vendedor.MontoCliene}";
        }
        #endregion

        #region AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            int index = DGV_GetFilaHeladera();

            CN_Heladera.getProducto(index, out producto);

            switch (vendedor.CargarCarrito(producto))
            {
                case 0:
                    MensajeOK("Producto cargado con exito!!", "Producto Cargado");
                    MostrarCarrito();

                    break;
                case 1:
                    MensajeError("Cliente no ingresado", "Error - [1]");
                    break;
                case 2:
                    MensajeError("Sin STOCK del producto", "Error - [2]");
                    break;
                case 3:
                    MensajeError("Saldo no Suficiente", "Error - [3]");
                    break;
                case 4:
                    MensajeError("STOCK alcanzado", "Error - [4]");
                    break;
            }
        }
        #endregion

        #region COMPRAR
        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (_debito && !_efectivo)
            {
                DialogResult aux;
                aux = MessageBox.Show("Con debito Tendras un 5% de recargo", "Aviso", MessageBoxButtons.YesNo);
                if (aux == DialogResult.Yes)
                {
                    validacionCompra(1);
                }
                else
                {
                    MensajeError("Se cancelo el recargo de 5%", "Cancelar Recargo");
                    validacionCompra(0);
                }
            }
            else if (!_debito && _efectivo)
            {
                if (_efectivo)
                {
                    validacionCompra(0);
                }
            }
            else
            {
                MensajeError("Seleccione forma de Pago.", "Error Forma de Pago");
            }
        }

        #region VALIDACION COMPRA
        private void validacionCompra(int formaDePago)
        {
            int rta;
            rta = Carrito.Comprar(vendedor.ListCarrito, out Vendedor.MontoCliene, cliente.Nombre, cliente.Apellido, cliente.Saldo, formaDePago);

            switch (rta)
            {
                case 0:
                    _factura = true;
                    dgvHeladera.Refresh();

                    lb_Dinero.Text = $" $ {Vendedor.MontoCliene}";

                    MensajeOK("Compra exitosa!!", "Compra de Productos");
                    vendedor.ListCarrito.Clear();
                    MostrarCarrito();
                    break;
                case 1:
                    MensajeError("Carrito Vacio", "Error - [1]");

                    break;
                case 2:
                    MensajeError("Error de Compra", "Error - [2]");

                    break;
                case 3:
                    MensajeError("Saldo no suficiente", "Error - [3]");
                    break;
            }
        }
        #endregion 

        #region FORMA DE PAGO
        private void checkEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEfectivo.Checked)
            {
                _efectivo = true;
            }
            else
            {
                _efectivo = false;
            }
        }

        private void checkDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDebito.Checked)
            {
                _debito = true;
            }
            else
            {
                _debito = false;
            }
        }
        #endregion

        #endregion

        #region FACTURA
        private void btn_Factura_Click(object sender, EventArgs e)
        {
            if (_factura)
            {
                Frm_Factura factura = new Frm_Factura();
                factura.ShowDialog();
                _factura = false;
            }
            else
            {
                MensajeError("Primero Hacer una Comprar", "Error Compra no Efectuada");
            }
        }
        #endregion

        #region MOSTRAR
        /// <summary>
        /// Muestra los clientes de la listaClientes en el DataGridView
        /// </summary>
        private void MostrarClientes()
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.Refresh();

            // Agrega las columnas directamente al DataGridView utilizando la inicialización de objetos
            dgvClientes.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nombre",
                    DataPropertyName = "Nombre"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Apellido",
                    DataPropertyName = "Apellido"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Saldo",
                    DataPropertyName = "Saldo"
                }
            );


            dgvClientes.DataSource = Vendedor.ListClientes;
        }

        private void MostrarHeladera()
        {
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = CN_Heladera.ListHeladera;

        }


        private void MostrarCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Corte",
                DataPropertyName = "Corte"
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio"
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Stock"
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tipo",
                DataPropertyName = "Tipo"
            });

            // Establecer el origen de datos solo si hay elementos en el carrito
            if (vendedor.ListCarrito.Count > 0)
            {
                dgvCarrito.Visible = true;
                lb_Vacio.Visible = false;
                dgvCarrito.DataSource = vendedor.ListCarrito;
            }
            else
            {
                dgvCarrito.DataSource = null; // Si no hay elementos en el carrito, establecer el origen de datos a null para limpiar el DataGridView
                dgvCarrito.Visible = false;
                lb_Vacio.Visible = true;
            }
        }

        #endregion

        #region MENSAJES
        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region METODOS DGV
        public int DGV_GetFilaHeladera()
        {
            return dgvHeladera.CurrentRow.Index;
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
        public Cliente DGV_GetCliente(int index)
        {
            Cliente c = new Cliente();

            c.Nombre = dgvClientes[0, index].Value.ToString();
            c.Apellido = dgvClientes[1, index].Value.ToString();
            c.Saldo = (float)Convert.ToDecimal(dgvClientes[2, index].Value);

            return c;
        }
        #endregion

        #region ORDENAMIENTO
        private void cbxOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_Heladera.OrdenarHeladera(cbxOrdenamiento.SelectedIndex);
            MostrarHeladera();
        }
        #endregion
    }
}