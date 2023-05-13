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
        private decimal saldo;
        public decimal Saldo { get => saldo; set => saldo = value; }

        public Cliente ()
        {
            Saldo = 0;
        }

        public Cliente(string nombre, string apellido, decimal saldo) : base(nombre, apellido)
        {
            Saldo = saldo;
        }



        /// <summary>
        /// Instacion los clientes a la lista productos.
        /// </summary>
        public static List<Cliente> ListaClientes = new List<Cliente>()
        {
            new Cliente("Nonah", "Dingle", 500),
            new Cliente("Gage", "Withringten", 3737),
            new Cliente("Zenia", "Ferrotti", 9793),
            new Cliente("Diann", "Gaitung", 19855),
            new Cliente("Gena", "Lembrick", 13681),
            new Cliente("Susanna", "Childe", 4885),
            new Cliente("Broderic", "Scintsbury", 4213),
            new Cliente("Frederique", "Rowesby", 7223),
            new Cliente("Abagael", "Cramphorn", 18678),
            new Cliente("Kelsi", "Kinver", 12232),
            new Cliente("Luca", "Morkham", 16142),
            new Cliente("Brigg", "Winckles", 2880),
            new Cliente("Malorie", "McCague", 14862),
            new Cliente("Daisey", "Ateggart", 8772),
            new Cliente("Cathi", "Heighway", 16726),
            new Cliente("Ardys", "Belding", 4869),
            new Cliente("Katinka", "Huggard", 13916),
            new Cliente("Mab", "Falco", 14626),
            new Cliente("Fairfax", "Clines", 17337),
            new Cliente("Meridel", "Desorts", 14010),
            new Cliente("Goldarina", "Iannuzzelli", 4444),
            new Cliente("Alvinia", "Vian", 731),
            new Cliente("Leonie", "Jaskowicz", 11462)
        };
    }    
}
