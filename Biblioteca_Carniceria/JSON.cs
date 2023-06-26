using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Carniceria
{
    public class JSON
    {
        public static void Serializacion()
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(Heladera.ListHeladera, opciones);

            using (StreamWriter file = new StreamWriter("productos.json"))
            {
                file.Write(jsonString);
            }
        }

        public static List<Producto> Deserializacion()
        {
            List<Producto> productos_Deserializados;

            string jsonString = File.ReadAllText("productos.json");

            productos_Deserializados = JsonSerializer.Deserialize<List<Producto>>(jsonString);

            return productos_Deserializados;
        }

    }
}
