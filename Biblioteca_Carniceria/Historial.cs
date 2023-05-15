using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Historial : Cliente
    {
        private string nombreProducto;
        private int cantidad;
        private decimal total;

        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Total { get => total; set => total = value; }

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

        public void AgregarAlHistorial(string nombre, string apellido)
        {
            Historial historial = new Historial();
            foreach (Factura factura in Factura.ListaFactura) 
            {
                historial.NombreProducto = factura.Nombre.ToString();
                historial.cantidad = factura.Cantidad;
                historial.Total = factura.Total;

                Historial.listaHistorial.Add(new Historial( historial.NombreProducto, historial.Cantidad,historial.Total, nombre, apellido));
            }
        }

    }
}
