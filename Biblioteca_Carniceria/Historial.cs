using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Historial : Factura
    {
        public static List<string> listFacturas = new List<string>();

        // Nombre Cliente
        string _nombre;
        string _apellido;
        string _nombreProducto;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }

        public Historial()
        {
            NombreProducto = "XXXXXX";
            Nombre = "XXXXXX";
            Apellido= "XXXXXX";
        }

        public Historial(string producto, int cantidad, decimal total, string nombre, string apellido) :base(cantidad, total)
        {
            NombreProducto = producto;
            Nombre = nombre;
            Apellido = apellido;
        }



    }
}
