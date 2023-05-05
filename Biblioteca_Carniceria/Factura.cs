using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Factura
    {
        private string descripcion;
        private int cantidad;
        private int precioUnitario;
        private int total;

        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
        public int Total { get; set; }

        public Factura ()
        {
            Descripcion = string.Empty;
            Cantidad = 0;
            PrecioUnitario = 0;
            Total = 0;
        }

    }
}
