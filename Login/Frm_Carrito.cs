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
    public partial class Frm_Carrito : Form
    {        
        //private CompraCarrito compraCarrito = new CompraCarrito();
        //private Cliente cliente = new Cliente();
        //private Factura factura = new Factura();
        //private Historial historial = new Historial();

        //private bool efectivo;
        //private bool carritoVacio = false;
        //private bool validarFactura = false;
        //public bool compraEfectuada = false;
       
        //public Frm_Carrito()
        //{
        //    InitializeComponent();
        //}

        //public Frm_Carrito(List<Producto> listaProductos, Cliente c) : this()
        //{
        //    Vendedor.ListCarrito = listaProductos;
        //    cliente = c;
        //}

        //private void FrmCarrito_Load(object sender, EventArgs e)
        //{
        //    this.MinimizeBox = false;
        //    this.MaximizeBox = false;
        //    this.ControlBox = false;
        //    MostrarCarrito();
        //}

        //private void ibtnComprar_Click(object sender, EventArgs e)
        //{ 
        //    // pregunto si el carrito esta vacio
        //    if (Vendedor.ListCarrito.Count == 0)
        //    {
        //        MessageBox.Show("El Carrito esta vacio");
        //        carritoVacio = true;
        //    }
        //    else
        //    {
        //        // si no se compro y el carrito esta lleno se peudo comprar
        //        if (compraEfectuada == false && carritoVacio == false)
        //        {
        //            // pregunto como lo va a pagar
        //            Frm_Pago frmOpcionPago = new Frm_Pago();

        //            // si es ok, pagara con efectivo y no lo paga con devito
        //            if (frmOpcionPago.ShowDialog() == DialogResult.OK)
        //            {
        //                efectivo = true; // se pagara con efectivo

        //                // cargo los productos comprados a la factura
        //                compraCarrito.CrearFactura(Vendedor.ListCarrito);

        //                // le paso la cantidad a pagar al carrito
        //                factura.Aux_Saldo += factura.Total_Compra;

        //                // el total apagar tiene que ser igual o menor al saldo del cliente
        //                if (factura.Total_Compra <= factura.Aux_Saldo)
        //                {
        //                    MensajeDeOK("Compra exitosa!!!", "Compra");

        //                    // Guardo la factura del cliente
        //                    compraCarrito.AgregarAlHistorial(cliente.Nombre, cliente.Apellido);

        //                    // estome da el gasto total
        //                    factura.Aux_Saldo += factura.Total_Compra;

        //                    validarFactura = true;
        //                    compraEfectuada = true;
        //                }
        //                else
        //                {
        //                    MensajeDeError("Saldo no suficiente", "Error, Saldo no suficiente");
        //                }
        //            }
        //            else
        //            {
        //                DialogResult dialogResult = MessageBox.Show("Con devito Tendras un 5% de recargo", "Pago por Devito", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //                if (dialogResult == DialogResult.Yes)
        //                {
        //                    // sepagara con devito
        //                    efectivo = false;

        //                    // cargo los productos comprados a la factura
        //                    compraCarrito.CrearFactura(Vendedor.ListCarrito);

        //                    // le paso la cantidad a pagar al carrito
        //                    factura.Aux_Saldo += factura.Total_Compra;

        //                    factura.Total_Compra = compraCarrito.RecargoDebito(factura.Total_Compra);

        //                    if (factura.Aux_Saldo <= factura.Aux_Saldo)
        //                    {
        //                        MensajeDeOK("Compra exitosa!!!", "Compra");
        //                        // Guardo la factura del cliente
        //                        compraCarrito.AgregarAlHistorial(cliente.Nombre, cliente.Apellido);

        //                        // estome da el gasto total
        //                        factura.Aux_Saldo += factura.Total_Compra;
        //                        validarFactura = true;
        //                        compraEfectuada = true;
        //                    }
        //                    else
        //                    {
        //                        MensajeDeError("Saldo no suficiente", "Error, Saldo no suficiente");
        //                    }
        //                }
        //                else
        //                {
        //                    MensajeDeError("Pago con devito Cancelado", "Error, Deviito cancelado");
        //                }
        //            }
        //        }
        //        else
        //        {
        //            MensajeDeError("Compra ya Efectuada", "Error, de compra");
        //        }
        //    }

        //}

        //private void ibtnFactura_Click(object sender, EventArgs e)
        //{
        //    if (validarFactura == true)
        //    {
        //        Frm_Factura frmFactura = new Frm_Factura( efectivo, cliente);
        //        frmFactura.ShowDialog();
        //    }
        //    else
        //    {
        //        MensajeDeError("Hacer compra primero", "Error, de compra");
        //    }
        //}
        

        //private void ibtnSalir_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //    if (!compraEfectuada)
        //    {
        //        DialogResult = DialogResult.Cancel;
        //    }
        //    else
        //    {
        //        DialogResult = DialogResult.OK;
        //    }
        //}

        //#region METODOS 

        //private void MostrarCarrito()
        //{
        //    dgvCarrito.Refresh();
        //    dgvCarrito.DataSource = Vendedor.ListCarrito;
        //    dgvCarrito.Columns[1].HeaderText = "Precio x Kilo";
        //    dgvCarrito.Columns[2].HeaderText = "Cantidad";
        //}

        ///// <summary>
        ///// Muestra un mensaje de error 
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="title"></param>
        //public void MensajeDeError(string msg, string title)
        //{
        //    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        ///// <summary>
        ///// Muestra un mensaje de OK
        ///// </summary>
        ///// <param name="msg"></param>
        ///// <param name="title"></param>
        //public void MensajeDeOK(string msg, string title)
        //{
        //    MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //}
        //#endregion

        
    }
}
