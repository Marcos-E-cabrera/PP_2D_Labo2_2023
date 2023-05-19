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
        // atributos
        private string nombre;
        private string apellido;
        private decimal saldo;

        // Propiedades
        public decimal Saldo { get => saldo; set => saldo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        // constructores
        public Cliente ()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Saldo = 0;
        }

        public Cliente(string nombre, string apellido, decimal saldo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Saldo = saldo;
        }






    }    
}
