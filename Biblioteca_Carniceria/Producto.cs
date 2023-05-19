using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Producto
    {
        private eCortes nombre;
        private int precio;
        private int stock;
        private string detalle;

        public eCortes Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Detalle { get => detalle; set => detalle = value; }

        public Producto()
        {
            Nombre = new eCortes();
            precio = 0;
            Stock = 0;
            Detalle= string.Empty;
        }

        public Producto(eCortes nombre, int precio, int stock, string detalle) : this()
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Detalle = detalle;
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
