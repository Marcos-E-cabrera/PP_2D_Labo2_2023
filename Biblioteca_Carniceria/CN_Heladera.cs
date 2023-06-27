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
    public delegate void MeAction();

    public class CN_Heladera : Producto
    {
        public event MeAction stockEnCero;

        public static List<Producto> ListHeladera = new List<Producto>();

        public CN_Heladera()
        {
            ListHeladera = CD_Productos.CreacionListaProductos();
        }

        public void CheckearHeladera(int id,
            Action correcto,
            Action<string> incorrecto)
        {
            Producto productoBuscado = ListHeladera.Find(i => i.Id == id);

            if (productoBuscado.Stock <= 0)
            {
                CD_Productos.Update(productoBuscado.Corte, productoBuscado.Precio, 17, productoBuscado.Tipo.ToString(), productoBuscado.Id);
                stockEnCero.Invoke();
            }
            else
            {
                incorrecto.Invoke("Producto no encontrado");
                return;
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

