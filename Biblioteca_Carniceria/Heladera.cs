using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    // Base de datos de heladera
    public class Heladera : Producto
    {
        public static List<Producto> ListHeladera = new List<Producto>();
        public ConexionSql conexionSql;

        public Heladera()
        {
            conexionSql = new ConexionSql();
            Read_Heladera();
        }

        // LEE LA BBDD DE LA HELADERA Y LOS CARGA EN LA LISTA PARA PODER SER USADAS
        public void Read_Heladera()
        {
            try
            {

                ConexionSql.command.CommandText = "SELECT * FROM HELADERA";
                ConexionSql.connection.Open();
                ConexionSql.reader = ConexionSql.command.ExecuteReader();

                while (ConexionSql.reader.Read())
                {
                    ListHeladera.Add(new Producto(ConexionSql.reader["NOMBRE"].ToString(), 
                                                  float.Parse(ConexionSql.reader["PRECIO"].ToString()), 
                                                  int.Parse(ConexionSql.reader["STOCK"].ToString()),
                                                  int.Parse(ConexionSql.reader["ID_TIPO"].ToString()) 
                                                  ));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                ConexionSql.connection.Close();
            }
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
            if (index < Heladera.ListHeladera.Count && index >= 0)
            {
                producto = Heladera.ListHeladera[index];
            }
            aux = producto;
        }

        public static void getProductoHeladeraCliente(int index, out Producto aux)
        {
            List<Producto> ListHeladera_cliente = new List<Producto>();
            ListHeladera_cliente.Clear();

            Producto producto = new Producto();

            foreach (Producto p in Heladera.ListHeladera)
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

