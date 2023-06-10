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
        private Vendedor vendedor;
        private Cliente cliente;
        bool _efectivo = false;
        bool _debito = false;
        bool _factura = false;

        public Frm_User_Cliente()
        {
            InitializeComponent();
        }

        public Frm_User_Cliente(Cliente cliente) : this()
        {
            this.cliente = cliente;

            vendedor = new Vendedor();
            vendedor.getMontoCliente(cliente);
            Vendedor.clienteCargado = true;
            txtDinero.Text = cliente.Saldo.ToString();
            cbxOrdenamiento.Items.Add("Nombre");
            cbxOrdenamiento.Items.Add("Precio");
            cbxOrdenamiento.Items.Add("Stock");
            cbxOrdenamiento.Items.Add("Detalle");

            MostrarHeladera();
            MostrarCarrito();
        }

        #region MOSTRAR
        /// <summary>
        /// Muestra los clientes de la listaClientes en el DataGridView
        /// </summary>


        private void MostrarHeladera()
        {
            dgvHeladera.Refresh();
            dgvHeladera.DataSource = Heladera.ListHeladera;

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
            if (vendedor.ListCarrito.Count > 0)
            {
                dgvCarrito.DataSource = vendedor.ListCarrito;
            }
            else
            {
                dgvCarrito.DataSource = null; // Si no hay elementos en el carrito, establecer el origen de datos a null para limpiar el DataGridView
            }
        }

        #endregion

        private void Frm_User_Cliente_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Tipo: {cliente.ObtenerUsuario()} || Usuario: {cliente.Nombre} {cliente.Apellido}";
        }


        #region AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Heladera heladera = new Heladera();
            Producto producto = new Producto();

            int index = DGV_GetFilaHeladera();

            heladera.getProducto(index, out producto);

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

                    txtDinero.Text = $" $ {Vendedor.MontoCliene}";

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

        private void cbxOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Heladera.OrdenarHeladera(cbxOrdenamiento.SelectedIndex);
            MostrarHeladera();
        }

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
