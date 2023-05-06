using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LOGIN -> Cliente
namespace Biblioteca_Carniceria
{
    public class Cliente : Usuario
    {
        #region CONSTRUCTOR
        public Cliente(string email, string password, string nombre, string apellido) : base(email, password, nombre, apellido)
        {
            email = string.Empty;
            password = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
        }
        #endregion

    }
}
