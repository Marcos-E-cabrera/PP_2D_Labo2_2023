using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Historial 
    {
        private string nombreProducto;
        private int cantidad;
        private decimal total;
        private string nombre;
        private string apellido;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Total { get => total; set => total = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public static List<Historial> listaHistorial = new List<Historial>();

        public Historial()
        {
            NombreProducto = string.Empty;
            Cantidad = 0;
            Total = 0;
            Nombre = string.Empty;
            Apellido= string.Empty;
        }

        public Historial(string producto, int cantidad, decimal total, string nombre, string apellido) :this()
        {
            NombreProducto = producto;
            Cantidad = cantidad;
            Total = total;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
