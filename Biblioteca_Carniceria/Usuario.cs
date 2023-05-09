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
        #endregion

        #region PROPIEDADES
        public string Email { get; set; }
        public string Password { get; set; }
        #endregion

        #region CONSTRUCTORES
        protected Usuario ()
        {
            Email = string.Empty;
            Password = string.Empty;
        }

        protected Usuario(string email, string password) : this () 
        {
            this.Email = email;
            this.Password = password;
        }
        #endregion

    }
}
