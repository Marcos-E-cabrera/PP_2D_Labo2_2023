using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Comprador : Usuario
    {
        private decimal saldo;
        private string nombre;
        private string apellido;

        public decimal Saldo { get; }
        public string Nombre { get; }
        public string Apellido { get; }

        public Comprador(string email, string password, decimal saldo, string nombre, string apellido) : base(email, password)
        {
            this.Saldo = Saldo;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }


    }
}
