using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Carniceria
{
    public class XML
    {
        public static void Serializacion()
        {
            // SERIALIZACION XML
            using (StreamWriter streamWriter = new StreamWriter("Productos.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));

                xmlSerializer.Serialize(streamWriter, CN_Heladera.ListHeladera);
            }
        }

        public static List<Producto> Deserializacion()
        {
            List<Producto> productos_Deserializados;

            // DESERIALIZACION XML
            using (StreamReader streamReader = new StreamReader("Productos.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Producto>));

                productos_Deserializados = (List<Producto>)xmlSerializer.Deserialize(streamReader);
            }

            return productos_Deserializados;
        }

    }
}
