using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Producto
    {
        #region CAMPOS
        string _nombre;
        decimal _Precio;
        int _Stock;
        eTipo _tipo;
        #endregion

        #region PROPIEDADES
        public string Nombre { get => _nombre; set => _nombre = value; }
        public decimal Precio { get => _Precio; set => _Precio = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public eTipo Tipo { get => _tipo; set => _tipo = value; }
        #endregion

        #region CONSTRUCTORES
        public Producto()
        {
            Nombre = "xxxxxxx";
            Precio = 0;
            Stock = 0;
            Tipo = 0;
        }

        public Producto(string nombre, decimal precio, int stock) : this()
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public Producto(string nombre, decimal precio, int stock, eTipo tipo) : this( nombre, precio,stock)
        {
            Tipo = tipo;
        }
        #endregion

        #region METODOS 
        public static bool operator == ( Producto a, Producto b) 
        {
            return a.Nombre.Equals(b.Nombre);
        }

        public static bool operator != ( Producto a, Producto b ) 
        { 
           return !(a == b);
        }
        #endregion

    }
}
