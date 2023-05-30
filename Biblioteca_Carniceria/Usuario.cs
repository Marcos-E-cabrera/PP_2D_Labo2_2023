using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public abstract class Usuario
    {
        private string _nombre;
        private string _apellido;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }

        public Usuario()
        {
            Nombre = "XXXXXX";
            Apellido = "XXXXXX";
        }

        public Usuario( string nombre, string apellido): this()
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract string ObtenerUsuario();

        public abstract int CargarCarrito(Producto producto);
    }
}
