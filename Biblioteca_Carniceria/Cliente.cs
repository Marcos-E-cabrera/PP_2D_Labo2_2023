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
        #region CAMPOS
        private double saldo;
        #endregion

        #region PROPIEDADES
        public double Saldo 
        {
            get { return saldo; }
            set { saldo = value; }
        }
        #endregion

        #region CONSTRUCTOR
        public Cliente(string email, string password, string nombre, string apellido, int saldo) : base(email, password, nombre, apellido)
        {
            this.Saldo = saldo;
            email = string.Empty;
            password = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
        }
        #endregion

    }
}
