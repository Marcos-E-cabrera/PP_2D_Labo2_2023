using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    // Base de datos de heladera
    public class Heladera : Producto
    {
        public static List<Producto> ListHeladera =  new List<Producto>();

        public Heladera() 
        {
            #region VACUNO
            ListHeladera.Add(new Producto(eCortes.Asado, 1000, 0, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Vacio, 1000, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Bife_De_Chorizo, 700, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Entraña, 800, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Matambre,600, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Cuadril,900, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Lomo_Vetado,1200, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Colita_De_Cuadril,988, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Tapa_De_Asado,600, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Marucha,556, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Falda,875, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.RoastBeef,654, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Cadera,700, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Cadera_De_Ternera,500, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Callos,267, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Chuletón_De_Vaca,2000, 10, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Contra,1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Entrecot_De_Ternera_Rosada,1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Etrecot_De_Ternera_Blanca,3000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Lengua,1300, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Morcillo_De_Ternera_Blanca,1023, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Osobuco,1000, 10, eTipo.Ternero));
            ListHeladera.Add(new Producto(eCortes.Picaña_De_Vaca,1000, 15, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Redondo_De_Ternera_Rosada,1000, 18, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Roti_De_Ternera_Blanca,1000, 17, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Solomillo_De_Ternera_Rosada,1000, 25, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Solomillo_De_Vaca,1000, 28, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Tapa_De_Ternera_Rosada,1000, 13, eTipo.Vacuno));
            ListHeladera.Add(new Producto(eCortes.Perdiz_De_Ternera,1000, 10, eTipo.Ternero));
            #endregion

            #region CERDO
            ListHeladera.Add(new Producto(eCortes.Chuleta_De_Cerdo,1000, 8, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Costilla_Adobada,1000, 10, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Ibéricos,1000, 12, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Lomo_Adobado,1000, 10, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Picadillo, 1000,5, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Solomillo_De_Cerdo,1000, 12, eTipo.Cerdo));
            ListHeladera.Add(new Producto(eCortes.Tira_De_Costilla_De_Cerdo,1000, 10, eTipo.Cerdo));
            #endregion

            #region CORDERO

            ListHeladera.Add(new Producto(eCortes.Chuletillas,3000, 14, eTipo.Cordero));
            ListHeladera.Add(new Producto(eCortes.Chuletillas_De_Recental,1000, 14, eTipo.Cordero));
            ListHeladera.Add(new Producto(eCortes.Delantero,1000, 10, eTipo.Cordero));
            ListHeladera.Add(new Producto(eCortes.Manitas,1000,17, eTipo.Cordero));
            ListHeladera.Add(new Producto(eCortes.Pierna, 1000,18, eTipo.Cordero));
            #endregion

            #region POLLO
            ListHeladera.Add(new Producto(eCortes.Pechuga,1000, 35, eTipo.Pollo));
            ListHeladera.Add(new Producto(eCortes.Muslos,1000, 25, eTipo.Pollo));
            ListHeladera.Add(new Producto(eCortes.Alas,1000, 20, eTipo.Pollo));
            ListHeladera.Add(new Producto(eCortes.Pollo_Entero,1000, 22, eTipo.Pollo));
            #endregion

            #region OTROS
            ListHeladera.Add(new Producto(eCortes.Hamburguesas,200, 21, eTipo.Procesado));
            ListHeladera.Add(new Producto(eCortes.Salchichas,150, 15, eTipo.Procesado));
            #endregion
        }


        #region Genera una ListHeladera limpia para el cliente
        /// <summary>
        /// Filtra los productos que estan sin stock (0) y los elimina de la lista
        /// </summary>
        /// <returns> Retorna la lista de heladera filtrada </returns>
        public List<Producto> HeladeraCliente()
        {
            List<Producto> ListHeladera_cliente = new List<Producto>();

            foreach (Producto producto in ListHeladera)
            {
                if (producto.Stock != 0)
                {
                    ListHeladera_cliente.Add(producto);
                }
            }

            return ListHeladera_cliente;
        }
        #endregion

        #region Ordena la Heladera
        /// <summary>
        /// Ordeno la lista por el criterio pasado.
        /// </summary>
        /// <param name="Criterio"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public List<Producto> OrdenaarHeladera(int Criterio, List<Producto> l)
        {
            switch (Criterio)
            {
                case 0:
                    l = l.OrderBy(p => p.Nombre).ToList();
                    break;
                case 1:
                    l = l.OrderBy(p => p.Precio).ToList();
                    break;

                case 2:
                    l = l.OrderBy(p => p.Stock).ToList();
                    break;
                case 3:
                    l = l.OrderBy(p => p.Tipo).ToList();
                    break;
            }
            return l;
        }
        #endregion

        #region selecionar producto
        /// <summary>
        /// Obtiene un producto de la lista productos y lo devuelve.
        /// </summary>
        /// <param name="index"> index del producto que se quiere obtener</param>
        /// <returns>Retorna el producto obtenido del index</returns>
        public void getProducto(int index, out Producto aux)
        {
            Producto producto = new Producto();
            if (index < Heladera.ListHeladera.Count && index >= 0)
            {
                producto = Heladera.ListHeladera[index];
            }
            aux = producto;
        }
        #endregion

        #region Actualizar heladera
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

