using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
    {
        private string nombre;
        private eCortes precioPorKilo;
        private int stock;
        private string detalle;

        public string Nombre { get; }
        public int PrecioPorKilo
        {
            get { return (int)precioPorKilo; }
            set { precioPorKilo = (eCortes)value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public string Detalle { get; }

        public Producto(string nombre, eCortes precio, int stock, string detalle)
        {
            this.Nombre = nombre;
            this.PrecioPorKilo = (int)precio;
            this.Stock = stock;
            this.Detalle = detalle;
        }


        public override string ToString()
        {
            return $"| {Nombre}   | {(int)PrecioPorKilo}     | {Stock}   | {Detalle}  |";
        }
    }
}
