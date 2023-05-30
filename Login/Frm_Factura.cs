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
    public partial class Frm_Factura : Form
    {
        Carrito compraCarrito = new Carrito();
        private Cliente cliente;

        private string formaPago;
        private static int nroFactura = 0;

        public Frm_Factura()
        {
            InitializeComponent();
            //cliente = new Cliente();
        }

        public Frm_Factura( bool foD, Cliente cliente) : this()
        {
            switch (foD)
            {
                case true:
                    formaPago = "Efectivo";
                    break;
                case false:
                    formaPago = "Devito";
                    break;
            }

            this.cliente = cliente;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            MostrarFactura();
        }

        private void MostrarFactura()
        {
            //decimal totalFinal = 0;
            //nroFactura++;
            //dgvFacturaTitle.Columns.Add("", "");
            //dgvFacturaTitle.Columns.Add("", "");
            //dgvFacturaTitle.Columns.Add("", "");
            //dgvFacturaTitle.Columns.Add("", "");

            //dgvFacturaTitle.Rows.Add("Carnicería:", " LA CABRERA", "", "");
            //dgvFacturaTitle.Rows.Add("CIUT:", datosComerciante.Cuit, "", "");
            //dgvFacturaTitle.Rows.Add("Domicilio:", "Av. Bartolomé Mitre 750", ", Buenos Aires", ", Avellaneda");
            //dgvFacturaTitle.Rows.Add("Teléfono:", datosComerciante.Telefono, "", "");
            //dgvFacturaTitle.Rows.Add("", "", "", "");
            //dgvFacturaTitle.Rows.Add("Fecha:", datosComerciante.Fecha, "Hora:", datosComerciante.Hora);
            //dgvFacturaTitle.Rows.Add("Número de factura:", nroFactura, "", "");
            //dgvFacturaTitle.Rows.Add("Datos cliente:", "Consumidor Final", $"{cliente.Nombre}", $"{cliente.Apellido}");

            //dgvFactura.Columns.Add("descripcion", "Descripción");
            //dgvFactura.Columns.Add("cantidad", "Cantidad");
            //dgvFactura.Columns.Add("precioUnitario", "Precio Unitario");
            //dgvFactura.Columns.Add("importe", "Importe");

            //foreach (Biblioteca_Carniceria.Factura aux in compraCarrito.ListaFactura)
            //{
            //    dgvFactura.Rows.Add(aux.Nombre_Producto, $"{aux.Stock_Producto.ToString("0.00")} KG", $"$ {aux.Precio_Producto.ToString("0.00")}", $"$ {aux.Total_Compra.ToString("0.00")}");
            //    totalFinal += aux.Total_Compra;
            //}

            //dgvFactura.Rows.Add("", "", "Total:", $"$ {totalFinal.ToString("0.00")}");
            //dgvFactura.Rows.Add("Forma de pago:", $"{formaPago}", "", "");

            //compraCarrito.ListaHistorial.Clear();
            
        }
    }
}
