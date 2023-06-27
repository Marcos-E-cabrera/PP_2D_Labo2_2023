using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class MiExcepciones : Exception
    {
        public MiExcepciones()
        {
        }

        public MiExcepciones(string? message) : base(message)
        {
        }

        public MiExcepciones(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
