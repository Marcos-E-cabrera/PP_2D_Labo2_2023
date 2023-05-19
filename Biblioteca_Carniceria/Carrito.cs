using Biblioteca_Carniceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Carrito
    {
        private decimal saldo;
        private decimal total;
        private decimal aux;

        public decimal Saldo { get => saldo; set => saldo = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Aux { get => aux; set=> aux = value; }

        public Carrito()
        {
            Total = 0;
            Aux = 0;
        }
    }
}
