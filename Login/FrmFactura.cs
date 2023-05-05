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
        private DateTime fechaHoraActual = DateTime.Now;
        private List<Factura> listaFactura = new List<Factura>();

        public FrmFactura()
        {
            InitializeComponent();
        }

        public FrmFactura(List<Factura> listaCarrito)
        {
            InitializeComponent();
            listaFactura = listaCarrito;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            string ciut = "20-28294141-5";
            string telefono = "(011) 5555-5555";
            string fecha = fechaHoraActual.ToString("dd/MM/yyyy");
            string hora = fechaHoraActual.ToString("HH:mm:ss");
            string nroFactura = "00000001";

            string descripcion = "";
            int cantidad = 0;
            int precioUnitario = 0;
            int total = 0;

            int totalFinal = 0;

            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");
            dgvFacturaTitle.Columns.Add("", "");

            dgvFacturaTitle.Rows.Add("Carnicería:", " LA CABRERA", "", "");

            dgvFacturaTitle.Rows.Add("CIUT:", ciut, "", "");
            dgvFacturaTitle.Rows.Add("Domicilio:", "Av. San Martín 1234", "CABA", "");
            dgvFacturaTitle.Rows.Add("Teléfono:", telefono, "", "");
            dgvFacturaTitle.Rows.Add("", "", "", "");
            dgvFacturaTitle.Rows.Add("Fecha:", fecha, "Hora:", hora);
            dgvFacturaTitle.Rows.Add("Número de factura:", nroFactura, "", "");

            dgvFactura.Columns.Add("descripcion", "Descripción");
            dgvFactura.Columns.Add("cantidad", "Cantidad");
            dgvFactura.Columns.Add("precioUnitario", "Precio Unitario");
            dgvFactura.Columns.Add("importe", "Importe");


            foreach (Factura producto in listaFactura)
            {
                descripcion = producto.Descripcion;
                cantidad = producto.Cantidad;
                precioUnitario = producto.PrecioUnitario;
                total = producto.Total;
                totalFinal += total;

                dgvFactura.Rows.Add(descripcion, cantidad, $"$ {precioUnitario}", $"$ {total}");
            }
            decimal iva = totalFinal * 0.21m;
            dgvFactura.Rows.Add("", "", "Subtotal:", $"$ {totalFinal}");   
            dgvFactura.Rows.Add("", "", "%IVA:  21", $"$ {iva}");
            dgvFactura.Rows.Add("", "", "Total:", $"$ {totalFinal + iva}");
            dgvFactura.Rows.Add("Forma de pago:", "Efectivo", "", "");

        }
    }
}
