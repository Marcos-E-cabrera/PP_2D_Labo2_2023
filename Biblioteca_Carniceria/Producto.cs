using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Producto
    {
        private string _corte;
        private float _Precio;
        private int _Stock;
        private eTipo _tipo;
        private int _id;

        public string Corte { get => _corte; set => _corte = value; }
        public float Precio { get => _Precio; set => _Precio = value; }
        public int Stock { get => _Stock; set => _Stock = value; }
        public eTipo Tipo { get => _tipo; set => _tipo = value; }
        public int Id { get => _id; set => _id = value; }

        public Producto()
        {
            Corte = string.Empty;
            Precio = 0;
            Stock = 0;
            Id = 0;
        }

        public Producto(string nombre, float precio, int stock) : this()
        {
            Corte = nombre;
            Precio = precio;
            Stock = stock;
        }

        public Producto(string nombre, float precio, int stock, int tipo) : this( nombre, precio,stock)
        {
            Tipo = (eTipo)tipo;
        }

        public Producto(string nombre, float precio, int stock, int tipo, int id) : this(nombre, precio, stock,tipo)
        {
            Id = id;
        }



        public static bool operator == ( Producto a, Producto b) 
        {
            return a.Corte == b.Corte;
        }

        public static bool operator != ( Producto a, Producto b ) 
        { 
           return !(a == b);
        }

    }
}
