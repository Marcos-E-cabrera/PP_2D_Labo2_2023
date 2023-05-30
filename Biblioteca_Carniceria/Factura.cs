using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Factura : Carrito
    {
        public static int nFactura = 0;
        // Total de la compra
        decimal _total;
        decimal _aux_Debito;
        public static decimal MontoFinal;

        eCortes _nombre;
        int _cantidad;
        decimal _precioUnitario;

        private string cuit;
        private string telefono;

        private DateTime fechaHoraActual = DateTime.Now;
        private string fecha;
        private string hora;

        public string Cuit { get => cuit; set => cuit = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Hora { get => hora; set => hora = value; }

        public decimal Total { get => _total; set => _total = value; }
        public decimal Aux_Debito { get => _aux_Debito; set => _aux_Debito = value; }
        public eCortes Nombre { get => _nombre; set => _nombre = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }
        public decimal PrecioUnitario { get => _precioUnitario; set => _precioUnitario = value; }

        public Factura()
        {
            Cuit = "20-28294141-5";
            Telefono = "(011) 5555-5555";
            Fecha = fechaHoraActual.ToString("dd/MM/yyyy");
            Hora = fechaHoraActual.ToString("HH:mm:ss");

            Nombre = 0;
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

        public Factura ( eCortes nombre, int cantidad, decimal precioUnitario, decimal total) :this(cantidad,total)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }
        
      
    }
}
