using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public interface ICarrito
    {
        /// <summary>
        /// EL usuario tendra un metodo que le permitira cargar productos al carrito
        /// </summary>
        public int CargarCarrito(Producto p);
    }
}
