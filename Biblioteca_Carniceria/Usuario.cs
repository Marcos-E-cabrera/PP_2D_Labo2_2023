using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public abstract class Usuario
    {
        #region PROPIEDADES
        private string email;
        private string password;
        private string nombre;
        private string apellido;
        #endregion

        #region PROPIEDADES
        public string Nombre { get; }
        public string Apellido { get; }

        public string Email { get; }
        public string Password { get; }
        #endregion

        #region CONSTRUCTORES
        protected Usuario(string email, string password, string nombre, string apellido)
        {
            this.Email = email;
            this.Password = password;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        #endregion

    }
}
