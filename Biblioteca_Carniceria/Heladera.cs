using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    // Base de datos de heladera
    public class Heladera : Producto
    {
        // Creo una lista de Productos 
        public static List<Producto> ListHeladera =  new List<Producto>();

        public Heladera() 
        {
            #region VACUNO
            ListHeladera.Add(new Producto(eCortes.Asado, 1000, 0, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Vacio, 1000, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.BifeDeChorizo, 700, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Entraña, 800, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Matambre,600, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Cuadril,900, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.LomoVetado,1200, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.ColitaDeCuadril,988, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.TapaDeAsado,600, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Marucha,556, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.Falda,875, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.RoastBeef,654, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.Cadera,700, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.CaderaDeTernera,500, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.Callos,267, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.ChuletaDeTerneraRosada,880, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.ChuletónDeVaca,2000, 10, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.Contra,1000, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.EntrecotDeTerneraRosada,1000, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.EtrecotDeTerneraBlanca,3000, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.Lengua,1300, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.MorcilloDeTerneraBlanca,1023, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.Osobuco,1000, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.PerdizDeTernera,1000, 10, " ternero"));
            ListHeladera.Add(new Producto(eCortes.PicañaDeVaca,1000, 15, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.RedondoDeTerneraRosada,1000, 18, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.RotiDeTerneraBlanca,1000, 17, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.SolomilloDeTerneraRosada,1000, 25, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.SolomilloDeVaca,1000, 28, " vacuno"));
            ListHeladera.Add(new Producto(eCortes.TapaDeTerneraRosada,1000, 13, " vacuno"));
            #endregion

            #region CERDO
            ListHeladera.Add(new Producto(eCortes.ChuletaDeCerdo,1000, 8, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.CostillaAdobada,1000, 10, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.Ibéricos,1000, 12, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.LomoAdobado,1000, 10, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.PancetaDeCerdo,1000, 6, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.Picadillo, 1000,5, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.SolomilloDeCerdo,1000, 12, " cerdo"));
            ListHeladera.Add(new Producto(eCortes.TiraDeCostillaDeCerdo,1000, 10, " cerdo"));
            #endregion

            #region CORDERO

            ListHeladera.Add(new Producto(eCortes.Chuletillas,3000, 14, "cordero"));
            ListHeladera.Add(new Producto(eCortes.ChuletillasDeLechazo,1000, 14, "cordero"));
            ListHeladera.Add(new Producto(eCortes.ChuletillasDeRecental,1000, 14, "cordero"));
            ListHeladera.Add(new Producto(eCortes.Delantero,1000, 10, "cordero"));
            ListHeladera.Add(new Producto(eCortes.DelanteroLechazo,1000, 15, "cordero"));
            ListHeladera.Add(new Producto(eCortes.Lechazo,1000, 16, "cordero"));
            ListHeladera.Add(new Producto(eCortes.Manitas,1000,17, "cordero"));
            ListHeladera.Add(new Producto(eCortes.ManitasDeLechazo,1000, 17, "cordero"));
            ListHeladera.Add(new Producto(eCortes.Pierna, 1000,18, "cordero"));
            ListHeladera.Add(new Producto(eCortes.PiernaYPaletillaDeLechazo,1000, 18, "cordero"));
            #endregion

            #region POLLO
            ListHeladera.Add(new Producto(eCortes.Pechuga,1000, 35, " pollo"));
            ListHeladera.Add(new Producto(eCortes.Muslos,1000, 25, " pollo"));
            ListHeladera.Add(new Producto(eCortes.Alas,1000, 20, " pollo"));
            ListHeladera.Add(new Producto(eCortes.PolloEntero,1000, 22, " pollo"));
            #endregion

            #region OTROS
            ListHeladera.Add(new Producto(eCortes.Hamburguesas,200, 21, "Producto procesado de carne"));
            ListHeladera.Add(new Producto(eCortes.Salchichas,150, 15, "Producto procesado de carne"));
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
                    l = l.OrderBy(p => p.Detalle).ToList();
                    break;
            }
            return l;
        }
        #endregion

       
        
    }



}

