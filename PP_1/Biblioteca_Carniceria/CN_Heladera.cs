using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Biblioteca_Carniceria
{

    public class CN_Heladera : Producto
    {
        public static List<Producto> ListHeladera = new List<Producto>();

        public CN_Heladera()
        {
            #region VACUNO
            ListHeladera.Add(new Producto("Asado", 1000, 0, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Vacio", 1000, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Bife De Chorizo", 700, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Entraña", 800, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Matambre", 600, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Cuadril", 900, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Lomo Vetado", 1200, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Colita De Cuadril", 988, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Tapa De Asado", 600, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Marucha", 556, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Falda", 875, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("RoastBeef", 654, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Cadera", 700, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Cadera De Ternera", 500, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Callos", 267, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Chuletón De Vaca", 2000, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Contra", 1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Entrecot De Ternera Rosada", 1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Etrecot De Ternera Blanca", 3000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Lengua", 1300, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Morcillo De Ternera Blanca", 1023, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Osobuco", 1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto("Picaña De Vaca", 1000, 15, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Redondo De Ternera Rosada", 1000, 18, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Roti De Ternera Blanca", 1000, 17, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Solomillo De Ternera Rosada", 1000, 25, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Solomillo De Vaca", 1000, 28, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Tapa De Ternera Rosada", 1000, 13, eTipo.Vacuno));
            ListHeladera.Add(new Producto("Perdiz De Ternera", 1000, 10, eTipo.Ternero));
            #endregion
            #region CERDO
            ListHeladera.Add(new Producto("Chuleta De Cerdo", 1000, 8, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Costilla Adobada", 1000, 10, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Ibéricos", 1000, 12, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Lomo Adobado", 1000, 10, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Picadillo", 1000, 5, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Solomillo De Cerdo", 1000, 12, eTipo.Cerdo));
            ListHeladera.Add(new Producto("Tira De Costilla De Cerdo", 1000, 10, eTipo.Cerdo));
            #endregion
            #region CORDERO
            ListHeladera.Add(new Producto("Chuletillas", 3000, 14, eTipo.Cordero));
            ListHeladera.Add(new Producto("Chuletillas De Recental", 1000, 14, eTipo.Cordero));
            ListHeladera.Add(new Producto("Delantero", 1000, 10, eTipo.Cordero));
            ListHeladera.Add(new Producto("Manitas", 1000, 17, eTipo.Cordero));
            ListHeladera.Add(new Producto("Pierna", 1000, 18, eTipo.Cordero));
            #endregion
            #region POLLO
            ListHeladera.Add(new Producto("Pechuga", 1000, 35, eTipo.Pollo));
            ListHeladera.Add(new Producto("Muslos", 1000, 25, eTipo.Pollo));
            ListHeladera.Add(new Producto("Alas", 1000, 20, eTipo.Pollo));
            ListHeladera.Add(new Producto("Pollo Entero", 1000, 22, eTipo.Pollo));
            #endregion
            #region OTROS
            ListHeladera.Add(new Producto("Hamburguesas", 200, 21, eTipo.Procesado));
            ListHeladera.Add(new Producto("Salchichas", 150, 15, eTipo.Procesado));
            #endregion
        }


        #region HELADERA CLIENTE
        /// <summary>
        /// Filtra los productos que estan sin stock (0) y los elimina de la lista
        /// </summary>
        /// <returns> Retorna la lista de heladera filtrada </returns>
        public static List<Producto> HeladeraCliente()
        {
            List<Producto> ListHeladera_cliente = new List<Producto>();
            ListHeladera_cliente.Clear();

            foreach (Producto producto in ListHeladera)
            {
                if (producto.Stock != 0)
                    ListHeladera_cliente.Add(producto);
            }

            return ListHeladera_cliente;
        }
        #endregion

        #region ORDENAMIENTO DE HELADERA
        /// <summary>
        /// Ordeno la lista por el criterio pasado.
        /// </summary>
        /// <param name="criterio"></param>
        public static void OrdenarHeladera(int criterio)
        {
            List<Producto> list = new List<Producto>();
            list.Clear();
            switch (criterio)
            {
                case 0:

                    list = ListHeladera.OrderBy(h => h.Corte).ToList();
                    ListHeladera.Clear();
                    ListHeladera.AddRange(list);
                    break;
                case 1:
                    list = ListHeladera.OrderBy(h => h.Precio).ToList();
                    ListHeladera.Clear();
                    ListHeladera.AddRange(list);
                    break;
                case 2:
                    list = ListHeladera.OrderBy(h => h.Stock).ToList();
                    ListHeladera.Clear();
                    ListHeladera.AddRange(list);
                    break;
                case 3:
                    list = ListHeladera.OrderBy(h => h.Tipo).ToList();
                    ListHeladera.Clear();
                    ListHeladera.AddRange(list);
                    break;
            }
        }
        #endregion

        #region OBTENER PRODUCTO
        /// <summary>
        /// Obtiene un producto de la lista productos y lo devuelve.
        /// </summary>
        /// <param name="index"> index del producto que se quiere obtener</param>
        /// <returns>Retorna el producto obtenido del index</returns>
        public static void getProducto(int index, out Producto aux)
        {
            Producto producto = new Producto();
            if (index < CN_Heladera.ListHeladera.Count && index >= 0)
            {
                producto = CN_Heladera.ListHeladera[index];
            }
            aux = producto;
        }

        public static void getProductoHeladeraCliente(int index, out Producto aux)
        {
            List<Producto> ListHeladera_cliente = new List<Producto>();
            ListHeladera_cliente.Clear();

            Producto producto = new Producto();

            foreach (Producto p in CN_Heladera.ListHeladera)
            {
                if (p.Stock != 0)
                {
                    ListHeladera_cliente.Add(p);
                }
            }

            if (index < ListHeladera_cliente.Count && index >= 0)
            {
                producto = ListHeladera_cliente[index];
            }

            aux = producto;
        }
        #endregion

        #region ACTUALIZAR HELADERA
        /// <summary>
        /// Actualiza la lista de la heladera principal
        /// </summary>
        /// <param name="producto"></param>
        public static List<Producto> CargarHeladera(int index, Producto producto)
        {
            ListHeladera[index] = producto;
            return ListHeladera;
        }

        #endregion

    }




}

