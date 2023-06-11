using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public abstract class Usuario
    {
        string _nombre;
        string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        #region METODOS ABSTRACT
        /// <summary>
        /// Obtengo un tipo de usuario
        /// </summary>
        /// <returns>retorno el tipo de usuario</returns>
        public abstract string ObtenerUsuario();

        /// <summary>
        /// EL usuario tendra un metodo que le permitira cargar productos al carrito
        /// </summary>
        /// <param name="producto"></param>
        /// <returns> Retornara un valor dependiendo si esta OK o NO</returns>
        public abstract int CargarCarrito(Producto producto);
        #endregion
    }
}
