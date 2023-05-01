using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Usuario
    {
        private string email;
        private string password;

        public string Email { get; }
        public string Password { get; }

        protected Usuario(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }
       
    }
}
