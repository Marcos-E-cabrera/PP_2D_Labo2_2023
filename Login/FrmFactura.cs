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
    public partial class FrmFactura : Form
    {
        #region CAMPOS
        public Cliente cliente;

        private string cuit;
        private string telefono;

        private DateTime fechaHoraActual = DateTime.Now;
        private string fecha;
        private string hora;
        private static int ultimoNumeroFactura = 0;

        private string nroFactura;
        private decimal totalFinal;
        private string formaPago;
        private List<Factura> listaFactura = new List<Factura>();
        #endregion

        #region PROPIEDADES
        public string Cuit { get { return this.cuit = "20-28294141-5"; } }
        public string Telefono { get { return this.telefono = "(011) 5555-5555"; } }
        public string Fecha { get { return this.fecha = fechaHoraActual.ToString("dd/MM/yyyy"); } }
        public string Hora { get { return this.hora = fechaHoraActual.ToString("HH:mm:ss"); } }
        public string NroFactura { get; set; }
        public decimal TotalFinal { get; set; }
        public string FormaPago { get; set; }
        #endregion

        #region CONSTRUTORES
        public FrmFactura()
        {
            InitializeComponent();
            //cliente = new Cliente();
        }

        public FrmFactura(List<Factura> listaCarrito, bool foD, Cliente cliente)
        {
            InitializeComponent();
            listaFactura = listaCarrito;
            switch (foD)
            {
                case true:
                    FormaPago = "Efectivo";
                    break;
                case false:
                    FormaPago = "Devito";
                    break;
            }

            this.cliente = cliente;
        }
        #endregion

        #region LOAD
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            TotalFinal = 0;
            Factura factura = new Factura();
            ultimoNumeroFactura++;
            this.NroFactura = ultimoNumeroFactura.ToString().PadLeft(8, '0');

            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");

            dgvFacturaTitle.Rows.Add("Carnicería:", " LA CABRERA", "", "");
            dgvFacturaTitle.Rows.Add("CIUT:", Cuit, "", "");
            dgvFacturaTitle.Rows.Add("Domicilio:", "Av. Bartolomé Mitre 750", ", Buenos Aires", ", Avellaneda");
            dgvFacturaTitle.Rows.Add("Teléfono:", Telefono, "", "");
            dgvFacturaTitle.Rows.Add("", "", "", "");
            dgvFacturaTitle.Rows.Add("Fecha:", Fecha, "Hora:", Hora);
            dgvFacturaTitle.Rows.Add("Número de factura:", NroFactura, "", "");
            dgvFacturaTitle.Rows.Add("Datos cliente:", "Consumidor Final", $"{cliente.Nombre}", $"{cliente.Apellido}");

            dgvFactura.Columns.Add("descripcion", "Descripción");
            dgvFactura.Columns.Add("cantidad", "Cantidad");
            dgvFactura.Columns.Add("precioUnitario", "Precio Unitario");
            dgvFactura.Columns.Add("importe", "Importe");

            foreach (Factura producto in listaFactura)
            {
                factura.Descripcion = producto.Descripcion;
                factura.Cantidad = producto.Cantidad;
                factura.PrecioUnitario = producto.PrecioUnitario;
                factura.Total = producto.Total;
                TotalFinal += factura.Total;

                dgvFactura.Rows.Add(factura.Descripcion, $"{factura.Cantidad.ToString("0.00")} KG", $"$ {factura.PrecioUnitario.ToString("0.00")}", $"$ {factura.Total.ToString("0.00")}");
            }

            dgvFactura.Rows.Add("", "", "Total:", $"$ {TotalFinal.ToString("0.00")}");
            dgvFactura.Rows.Add("Forma de pago:", $"{FormaPago}", "", "");
        }
        
        #endregion
    }
}
