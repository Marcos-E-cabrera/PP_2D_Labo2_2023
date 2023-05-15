using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Vendedor : Usuario
    {
        public Vendedor(string nombre, string apellido) : base(nombre, apellido)
        {
            Nombre = nombre;
            Apellido= apellido;
        }

        public override string SaludarUsuario()
        {
            return $"Hola {Nombre} {Apellido}, Haz Iniciado como Vendedor";
        }
    }
}
