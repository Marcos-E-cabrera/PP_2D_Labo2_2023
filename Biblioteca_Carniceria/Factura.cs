using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Factura : Carrito
    {
        // LISTA DE DATOS
        public static List<string> PlantillaFactura = new List<string>();
        public static List<string> cliente = new List<string>();

        // DATOS VENDEDOR
         private DateTime fechaHoraActual = DateTime.Now;
        
        private string fecha;
        private string hora;
        public static int nFactura = 0;


        // DATOS PRODUCTOS
        string _producto;
        int _cantidad;
        decimal _precioUnitario;
        decimal _total;

        // DATOS TOTAL COMPRA
        decimal _aux_Debito;
        public static decimal MontoFinal;


        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }
        
    
        public string NombreProducto { get => _producto; set => _producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }
        public decimal Aux_Debito { get => _aux_Debito; set => _aux_Debito = value; }
        public decimal Total { get => _total; set => _total = value; }

        

        public Factura()
        {
            Fecha = fechaHoraActual.ToString("dd/MM/yyyy");
            Hora = fechaHoraActual.ToString("HH:mm:ss");

            NombreProducto = "xxx";
            Cantidad = 0;
            PrecioUnitario = 0;
            Total = 0;
            Aux_Debito = 0;
            MontoFinal = 0;
        }

        public Factura(int cantidad, decimal total)
        {        
            Cantidad = cantidad;
            Total = total;
        }

        public Factura ( string producto, int cantidad, decimal precioUnitario, decimal total) :this(cantidad,total)
        {
            NombreProducto = producto;
            PrecioUnitario = precioUnitario;
        }

        public List<string> MostrarFactura()
        {
            decimal totalFinal = 0;
            string formaPago = "efectivo";

            PlantillaFactura.Add("╔══════════════════════════════════════════════════════╗");
            PlantillaFactura.Add("Carnicería LA CABRERA");
            PlantillaFactura.Add("CIUT: 20-28294141-5");
            PlantillaFactura.Add("Domicilio: Av. Bartolomé Mitre 750, Buenos Aires, Avellaneda");
            PlantillaFactura.Add("Teléfono: (011) 5555-5555");
            PlantillaFactura.Add($"Fecha: {Fecha}  Hora: {Hora}");
            PlantillaFactura.Add($"Número de factura: {nFactura}");

            foreach ( string item in Factura.cliente )
            {
                PlantillaFactura.Add($"Datos cliente: {item}");
            }
                cliente.Clear();
            PlantillaFactura.Add("╔══════════════════════════════════════════════════════╗");
            PlantillaFactura.Add("|     Descripción     |   Cantidad  |     Precio Unit    |    Total\n");
             
            foreach (Factura aux in Carrito.ListaProductos)
            {
                PlantillaFactura.Add($"|     {aux.NombreProducto}     |   {aux.Cantidad.ToString("0.00")} KG   |   {aux.PrecioUnitario.ToString("0.00")}   |   {aux.Total.ToString("0.00")}");
                totalFinal += aux.Total;
            }

            ListaProductos.Clear();

            if ( Carrito.Pago == 1)
            {
                formaPago = "Debito";
                totalFinal = Carrito.RecargoDebito(totalFinal);
            }

            PlantillaFactura.Add("\n╔══════════════════════════════════════════════════════╗");
            PlantillaFactura.Add($"Total Final: ${totalFinal.ToString("0.00")}");
            PlantillaFactura.Add($"Forma de pago: {formaPago}");
            PlantillaFactura.Add("╚══════════════════════════════════════════════════════╝");

            foreach (string f in PlantillaFactura)
            {
                Historial.listFacturas.Add(f);
            }
            Historial.listFacturas.Add("\n");

            return PlantillaFactura;
        }

    }
}
