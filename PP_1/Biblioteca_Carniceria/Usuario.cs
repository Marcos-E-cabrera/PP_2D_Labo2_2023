using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public abstract class Usuario
    {
        string? _nombre;
        string? _apellido;
        string? _email;
        string? _password;


        public string? Nombre { get => _nombre; set => _nombre = value; }
        public string? Apellido { get => _apellido; set => _apellido = value; }
        public string? Email { get => _email; set => _email = value; }
        public string? Password { get => _password; set => _password = value; }


        #region METODOS ABSTRACT
        /// <summary>
        /// Obtengo un tipo de usuario
        /// </summary>
        /// <returns>retorno el tipo de usuario</returns>
        public abstract string ObtenerUsuario();

        public abstract int CargarCarrito(Producto p);

        #endregion
    }
}
