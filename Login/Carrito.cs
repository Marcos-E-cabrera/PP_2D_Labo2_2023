using Biblioteca_Carniceria;
using Frm_Vendedor;
using System;
    using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Carrito : Form
    {        
        private Biblioteca_Carniceria.Cliente clienteMain = new Biblioteca_Carniceria.Cliente();
        private Biblioteca_Carniceria.Carrito carritoMain = new Biblioteca_Carniceria.Carrito();
        private Biblioteca_Carniceria.Factura factura = new Biblioteca_Carniceria.Factura();
        private Biblioteca_Carniceria.Historial historial = new Biblioteca_Carniceria.Historial();

        private bool efectivo;
        private bool carritoVacio = false;
        private bool validarFactura = false;
        public bool compraEfectuada = false;
       
        public Carrito()
        {
            InitializeComponent();
        }

        public Carrito(List<Producto> listaProductos, Biblioteca_Carniceria.Cliente cliente) : this()
        {
            carritoMain.ListaCarrito = listaProductos;
            clienteMain = cliente;
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            MostrarCarrito();
        }

        private void ibtnComprar_Click(object sender, EventArgs e)
        {
            // pregunto si el carrito esta vacio
            if (carritoMain.ListaCarrito.Count == 0)
            {
                MessageBox.Show("El Carrito esta vacio");
                carritoVacio = true;
            }
            else
            {
                // si no se compro y el carrito esta lleno se peudo comprar
                if (compraEfectuada == false && carritoVacio == false)
                {
                    // pregunto como lo va a pagar
                    Pago frmOpcionPago = new Pago();

                    // si es ok, pagara con efectivo y no lo paga con devito
                    if (frmOpcionPago.ShowDialog() == DialogResult.OK)
                    {
                        efectivo = true; // se pagara con efectivo

                        // cargo los productos comprados a la factura
                        factura.CrearFactura(carritoMain.ListaCarrito);

                        // le paso la cantidad a pagar al carrito
                        carritoMain.Total = factura.Total;

                        // el total apagar tiene que ser igual o menor al saldo del cliente
                        if (carritoMain.Total <= carritoMain.Saldo)
                        {
                            MensajeDeOK("Compra exitosa!!!", "Compra");

                            // Guardo la factura del cliente
                            historial.AgregarAlHistorial( clienteMain.Nombre, clienteMain.Apellido);

                            // estome da el gasto total
                            carritoMain.Saldo += carritoMain.Total;

                            validarFactura = true;
                            compraEfectuada = true;
                        }
                        else
                        {
                            MensajeDeError("Saldo no suficiente", "Error, Saldo no suficiente");
                        }
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Con devito Tendras un 5% de recargo", "Pago por Devito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            // sepagara con devito
                            efectivo = false;

                            // cargo los productos comprados a la factura
                            factura.CrearFactura(carritoMain.ListaCarrito);

                            // le paso la cantidad a pagar al carrito
                            carritoMain.Total = factura.Total;

                            carritoMain.Aux = carritoMain.RecargoDevito(carritoMain.Total);

                            if (carritoMain.Aux <= carritoMain.Saldo)
                            {
                                MensajeDeOK("Compra exitosa!!!", "Compra");
                                // Guardo la factura del cliente
                                historial.AgregarAlHistorial(clienteMain.Nombre, clienteMain.Apellido);

                                // estome da el gasto total
                                carritoMain.Saldo += carritoMain.Total;
                                validarFactura = true;
                                compraEfectuada = true;
                            }
                            else
                            {
                                MensajeDeError("Saldo no suficiente", "Error, Saldo no suficiente");
                            }
                        }
                        else
                        {
                            MensajeDeError("Pago con devito Cancelado", "Error, Deviito cancelado");
                        }
                    }
                }
                else
                {
                    MensajeDeError("Compra ya Efectuada", "Error, de compra");
                }
            }

        }

        private void ibtnFactura_Click(object sender, EventArgs e)
        {
            if (validarFactura == true)
            {
                Factura frmFactura = new Factura( efectivo, clienteMain);
                frmFactura.ShowDialog();
            }
            else
            {
                MensajeDeError("Hacer compra primero", "Error, de compra");
            }
        }
        

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            if (!compraEfectuada)
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }

        #region METODOS 

        private void MostrarCarrito()
        {
            dgvCarrito.Refresh();
            dgvCarrito.DataSource = carritoMain.ListaCarrito;
            dgvCarrito.Columns[1].HeaderText = "Precio x Kilo";
            dgvCarrito.Columns[2].HeaderText = "Cantidad";
        }

        /// <summary>
        /// Muestra un mensaje de error 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de OK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        
    }
}
