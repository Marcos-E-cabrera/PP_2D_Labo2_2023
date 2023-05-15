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

        public List<Producto> ListaCarrito = new List<Producto>();

        public decimal Saldo { get => saldo; set => saldo = value; }
        public decimal Total { get => total; set => total = value; }
        public decimal Aux { get => aux; set=> aux = value; }

        public Carrito()
        {
            Total = 0;
            Aux = 0;
        }

        /// <summary>
        /// Agregra 5% de recargo al total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public decimal RecargoDevito(decimal total)
        {
            decimal cincoPorCiento = total * 0.05m;

            return total += cincoPorCiento;
        }

    }
}
