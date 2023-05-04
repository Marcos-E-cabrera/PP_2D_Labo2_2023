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
        private string nombre;
        private eCortes precio;
        private int stock;
        private string detalle;
        #endregion

        #region PROPIEDADES
        public string Nombre {get; set;}

        public int Precio { get; set; }

        public int Stock { get; set; }

        public string Detalle { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Producto ()
        {
            nombre = string.Empty;
            precio = new eCortes ();
            stock = 0;
            detalle = string.Empty;
        }

        public Producto(string nombre, eCortes precio, int stock, string detalle) :this()
        {
            this.Nombre = nombre;
            this.Precio = (int)precio;
            this.Stock = stock;
            this.Detalle = detalle;
        }
        #endregion

        

    }
}
