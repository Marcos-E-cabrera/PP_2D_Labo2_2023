using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Producto
    {
        private eCortes _nombre;
        private decimal _Precio;
        private int _Stock;
        private eTipo _tipo;

        public eCortes Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public eTipo Tipo { get => _tipo; set => _tipo = value; }

        public Producto()
        {
            Nombre = 0;
            Precio = 0;
            Stock = 0;
            Tipo = 0;
        }

        public Producto(eCortes nombre, decimal precio, int stock) : this()
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public Producto(eCortes nombre, decimal precio, int stock, eTipo tipo) : this( nombre, precio,stock)
        {
            Tipo = tipo;
        }

      

        public static bool operator == ( Producto a, Producto b) 
        {
            return a.Nombre.Equals(b.Nombre);
        }

        public static bool operator != ( Producto a, Producto b ) 
        { 
           return !(a == b);
        }
    
    
    }   
}
