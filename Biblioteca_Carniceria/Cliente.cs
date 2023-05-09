using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LOGIN -> Cliente
namespace Biblioteca_Carniceria
{
    public class Cliente
    {
        #region CAMPOS
        private string nombre;
        private string apellido;
        private int saldo;
        #endregion

        #region PROPIEDADES
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Saldo { get; set; }
        #endregion

        #region CONSTRUCTOR
        public Cliente()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Saldo = 0;
        }

        public Cliente(string nombre, string apellido, int saldo) : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Saldo = saldo;
        }
        #endregion

    }
}
