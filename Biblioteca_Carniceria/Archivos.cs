using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Biblioteca_Carniceria
{
    public class Archivos
    {
        public static void CrearArchivo_Historial(List<string> facura)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("Historial.txt", false);

                foreach (string linea in facura)
                {
                   streamWriter.WriteLine(linea);  
                }
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }

        public static void CrearArchivo_HistorialCliente(List<Historial> cliente)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("Historial_Cliente.txt", false);

                foreach (Historial linea in cliente)
                {
                    streamWriter.WriteLine($"{linea.NombreProducto} | {linea.Cantidad} | {linea.Total} | {linea.Nombre} | {linea.Apellido}");
                }
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }

        public static void CrearArchivo_xml(List<Producto> aux)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("productos_Deserializados_Xml.txt", false);

                foreach (Producto linea in aux)
                {
                    streamWriter.WriteLine($"{linea.Corte},{linea.Precio},{linea.Stock},{linea.Tipo}");
                }
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }

        public static void CrearArchivo_json(List<Producto> aux)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter("productos_Deserializados_json.txt", false);

                foreach (Producto linea in aux)
                {
                    streamWriter.WriteLine($"{linea.Corte},{linea.Precio},{linea.Stock},{linea.Tipo}");
                }
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
        }
    }
}
