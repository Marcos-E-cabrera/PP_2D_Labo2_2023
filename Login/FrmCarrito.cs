using Biblioteca_Carniceria;
using Frm_Vendedor;
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
    public partial class FrmCarrito : Form
    {
        #region CAMPOS
        private Cliente clienteMain;
        private List<Producto> listaCarrito = new List<Producto>();
        private bool carrito = false;
        private bool efectivo;
        private bool carritoVacio = false;
        private bool validarFactura = false;
        public bool compraEfectuada = false;
        private decimal saldo;
        private decimal total;
        private decimal aux;
        #endregion

        #region PROPIEDADES
        public decimal Saldo { get; set; }
        public decimal Total { get; set; }
        public decimal Aux { get; set; }
        #endregion

        #region FRM CARRITO CONSTRUCTOR
        public FrmCarrito()
        {
            InitializeComponent();
        }

        public FrmCarrito(List<Producto> listaProductos, decimal saldo, string nombre, string apellido)
        {
            InitializeComponent();
            clienteMain = new Cliente();
            listaCarrito = listaProductos;
            Saldo = saldo;
            clienteMain.Nombre = nombre;
            clienteMain.Apellido = apellido;
        }
        #endregion

        #region LOAD
        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.ControlBox = false;
            MostrarCarrito();
        }
        #endregion

        #region COMPRAR
        private void ibtnComprar_Click(object sender, EventArgs e)
        {
            if (listaCarrito.Count == 0)
            {
                MessageBox.Show("El Carrito esta vacio");
                carritoVacio = true;
            }
            else
            {
                if (compraEfectuada == false && carritoVacio == false)
                {
                    Factura factura = new Factura();
                    FrmOpcionPago frmOpcionPago = new FrmOpcionPago();
                    if (frmOpcionPago.ShowDialog() == DialogResult.OK)
                    {
                        efectivo = true;
                        foreach (Producto producto in listaCarrito)
                        {
                            factura.Cantidad = producto.Stock;
                            factura.PrecioUnitario = producto.Precio;
                            factura.Total = factura.Cantidad * factura.PrecioUnitario;
                            Total = factura.Total;
                        }
                        Saldo += Total;

                        if (Total <= Saldo)
                        {
                            MensajeDeOK("Compra exitosa!!!", "Compra");
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
                        efectivo = false;
                        foreach (Producto producto in listaCarrito)
                        {
                            factura.Cantidad = producto.Stock;
                            factura.PrecioUnitario = producto.Precio;
                            factura.Total = factura.Cantidad * factura.PrecioUnitario;
                            Total = factura.Total;
                        }
                        Saldo += Total;
                        DialogResult dialogResult = MessageBox.Show("Con devito Tendras un 5% de recargo", "Pago por Devito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            Aux = AgregarCincoPorCiento((decimal)Total);
                            if (Aux <= Saldo)
                            {
                                MensajeDeOK("Compra exitosa!!!", "Compra");
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
        #endregion

        #region FACTURA
        private void ibtnFactura_Click(object sender, EventArgs e)
        {
            if (validarFactura == true)
            {
                List<Factura> listaFactura = new List<Factura>();
                foreach (Producto producto in listaCarrito)
                {
                    Factura factura = new Factura();
                    factura.Descripcion = producto.Nombre;
                    factura.Cantidad = producto.Stock;
                    factura.PrecioUnitario = producto.Precio;
                    factura.Total = factura.Cantidad * factura.PrecioUnitario;
                    if (!efectivo)
                    {
                        factura.Total = Aux;
                    }
                    listaFactura.Add(factura);
                }

                FrmFactura frmFactura = new FrmFactura(listaFactura, efectivo, clienteMain);
                frmFactura.ShowDialog();
            }
            else
            {
                MensajeDeError("Hacer compra primero", "Error, de compra");
            }
        }
        #endregion

        #region SALIR
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
        #endregion

        #region METODOS 

        /// <summary>
        /// Agregra 5% de recargo al total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public decimal AgregarCincoPorCiento(decimal total)
        {
            decimal cincoPorCiento = total * 0.05m;

            return total += cincoPorCiento;
        }

        private void MostrarCarrito()
        {
            dgvCarrito.Refresh();
            dgvCarrito.DataSource = listaCarrito;
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
