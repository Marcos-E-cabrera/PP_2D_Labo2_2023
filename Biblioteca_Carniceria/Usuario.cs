using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public abstract class Usuario
    {
        private string nombre;
        private string apellido;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public Usuario() 
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }

        public Usuario( string nombre, string apellido) : this()
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public abstract string SaludarUsuario();
    }
}
