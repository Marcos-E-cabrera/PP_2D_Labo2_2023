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
    public partial class Frm_User_Cliente : Form
    {
        #region CAMPOS
        Vendedor _vendedor;
        Cliente _cliente;
        bool _efectivo = false;
        bool _debito = false;
        bool _factura = false;
        bool _facturaCreada = true;
        #endregion

        #region CONSTRUCTORES
        public Frm_User_Cliente()
        {
            InitializeComponent();
        }

        public Frm_User_Cliente(Cliente cliente) : this()
        {
            this._cliente = cliente;
            _vendedor = new Vendedor();


            Frm_Dinero frm_Dinero = new Frm_Dinero();
            if (frm_Dinero.ShowDialog(this) == DialogResult.OK)
            {
                cliente.Saldo = frm_Dinero.dinero;
            }


            _vendedor.getMontoCliente(cliente);
            Vendedor.clienteCargado = true;
            lb_Dinero.Text = cliente.Saldo.ToString();
            cbxOrdenamiento.Items.Add("Nombre");
            cbxOrdenamiento.Items.Add("Precio");
            cbxOrdenamiento.Items.Add("Stock");
            cbxOrdenamiento.Items.Add("Detalle");

            MostrarHeladera();
            MostrarCarrito();
        }
        #endregion

        #region AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            if (_facturaCreada)
            {
                int index = DGV_GetFilaHeladera();

                Heladera.getProductoHeladeraCliente(index, out producto);

                switch (_vendedor.CargarCarrito(producto))
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
            else
            {
                MensajeError("Seleccione Factura, Por Favor.", "Error Factura no entregada");
            }
        }
        #endregion

        #region COMPRAR
        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            if (_facturaCreada)
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
            else
            {
                MensajeError("Seleccione Factura, Por Favor.", "Error Factura no entregada");
            }
        }

        #region VALIDACION COMPRA
        private void validacionCompra(int formaDePago)
        {
            int rta;
            rta = Carrito.Comprar(_vendedor.ListCarrito, out Vendedor.MontoCliene, _cliente.Nombre, _cliente.Apellido, _cliente.Saldo, formaDePago);

            switch (rta)
            {
                case 0:
                    _factura = true;
                    dgvHeladera.Refresh();

                    lb_Dinero.Text = $" $ {Vendedor.MontoCliene}";

                    MensajeOK("Compra exitosa!!", "Compra de Productos");
                    _vendedor.ListCarrito.Clear();
                    MostrarCarrito();
                    _facturaCreada = false;
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
                _facturaCreada = true;
            }
            else
            {
                MensajeError("Primero Hacer una Comprar", "Error Compra no Efectuada");
            }
        }
        #endregion

        #region METODOS MOSTRAR
        /// <summary>
        /// Muestra los clientes de la listaClientes en el DataGridView
        /// </summary>

        private void MostrarHeladera()
        {
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = Heladera.HeladeraCliente();
        }

        private void MostrarCarrito()
        {
            dgvCarrito.AutoGenerateColumns = false;
            dgvCarrito.Columns.Clear(); // Limpiar las columnas existentes en caso de que haya alguna

            // Agrega las columnas directamente al DataGridView utilizando la inicialización de objetos
            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre" // Asegúrate de utilizar la propiedad correcta para el nombre de la columna
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio" // Asegúrate de utilizar la propiedad correcta para el precio de la columna
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Cantidad",
                DataPropertyName = "Stock" // Asegúrate de utilizar la propiedad correcta para la cantidad de la columna
            });

            dgvCarrito.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Tipo",
                DataPropertyName = "Tipo" // Asegúrate de utilizar la propiedad correcta para la cantidad de la columna
            });

            // Establecer el origen de datos solo si hay elementos en el carrito
            if (_vendedor.ListCarrito.Count > 0)
            {
                dgvCarrito.Visible = true;
                lb_Vacio.Visible = false;
                dgvCarrito.DataSource = _vendedor.ListCarrito;
            }
            else
            {
                dgvCarrito.DataSource = null; // Si no hay elementos en el carrito, establecer el origen de datos a null para limpiar el DataGridView
                dgvCarrito.Visible = false;
                lb_Vacio.Visible = true;
            }
        }

        #endregion

        #region TIPO USUARIO
        private void Frm_User_Cliente_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Tipo: {_cliente.ObtenerUsuario()} || Usuario: {_cliente.Nombre} {_cliente.Apellido}";
        }
        #endregion

        #region ORDENAMIENTO
        private void cbxOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHeladera.Refresh();
            Heladera.OrdenarHeladera(cbxOrdenamiento.SelectedIndex);
            MostrarHeladera();
        }
        #endregion

        #region METODOS DGV
        public int DGV_GetFilaHeladera()
        {
            return dgvHeladera.CurrentRow.Index;
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
    }
}
