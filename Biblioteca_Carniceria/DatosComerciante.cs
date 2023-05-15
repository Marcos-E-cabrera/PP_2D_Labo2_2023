using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class DatosComerciante
    {
        private string cuit;
        private string telefono;

        private DateTime fechaHoraActual = DateTime.Now;
        private string fecha;
        private string hora;

        public string Cuit { get => cuit; set => cuit = value; } 
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fecha { get => fecha; set => fecha = value; } 
        public string Hora { get => hora; set => hora = value; }

        public DatosComerciante()
        {
            Cuit = "20-28294141-5";
            Telefono = "(011) 5555-5555";
            Fecha = fechaHoraActual.ToString("dd/MM/yyyy");
            Hora = fechaHoraActual.ToString("HH:mm:ss");
        }
    }



}
