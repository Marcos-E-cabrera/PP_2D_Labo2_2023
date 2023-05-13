using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Producto
    {
        private eCortes nombre;
        private int precio;
        private int stock;
        private string detalle;

        public eCortes Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Detalle { get => detalle; set => detalle = value; }

        public Producto()
        {
            Nombre = new eCortes();
            precio = 0;
            Stock = 0;
            Detalle= string.Empty;
        }

        public Producto(eCortes nombre, int precio, int stock, string detalle) : this()
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Detalle = detalle;
        }

        /// <summary>
        /// Instacion los productos a la lista productos.
        /// </summary>
        public static List<Producto> ListaProductos = new List<Producto>()
        { 
            #region VACUNO

            new Producto(eCortes.Asado, 1000, 0, " vacuno"),
            new Producto(eCortes.Vacio, 1000, 10, " vacuno"),
            new Producto(eCortes.BifeDeChorizo, 700, 10, " vacuno"),
            new Producto(eCortes.Entraña, 800, 10, " vacuno"),
            new Producto(eCortes.Matambre,600, 10, " vacuno"),
            new Producto(eCortes.Cuadril,900, 10, " ternero"),
            new Producto(eCortes.LomoVetado,1200, 10, " ternero"),
            new Producto(eCortes.ColitaDeCuadril,988, 10, " ternero"),
            new Producto(eCortes.TapaDeAsado,600, 10, " vacuno"),
            new Producto(eCortes.Marucha,556, 10, " ternero"),
            new Producto(eCortes.Falda,875, 10, " ternero"),
            new Producto(eCortes.RoastBeef,654, 10, " ternero"),
            new Producto(eCortes.Cadera,700, 10, " ternero"),
            new Producto(eCortes.CaderaDeTernera,500, 10, " ternero"),
            new Producto(eCortes.Callos,267, 10, " ternero"),
            new Producto(eCortes.ChuletaDeTerneraRosada,880, 10, " ternero"),
            new Producto(eCortes.ChuletónDeVaca,2000, 10, " vacuno"),
            new Producto(eCortes.Contra,1000, 10, " ternero"),
            new Producto(eCortes.EntrecotDeTerneraRosada,1000, 10, " ternero"),
            new Producto(eCortes.EtrecotDeTerneraBlanca,3000, 10, " ternero"),
            new Producto(eCortes.Lengua,1300, 10, " ternero"),
            new Producto(eCortes.MorcilloDeTerneraBlanca,1023, 10, " ternero"),
            new Producto(eCortes.Osobuco,1000, 10, " ternero"),
            new Producto(eCortes.PerdizDeTernera,1000, 10, " ternero"),
            new Producto(eCortes.PicañaDeVaca,1000, 15, " vacuno"),
            new Producto(eCortes.RedondoDeTerneraRosada,1000, 18, " vacuno"),
            new Producto(eCortes.RotiDeTerneraBlanca,1000, 17, " vacuno"),
            new Producto(eCortes.SolomilloDeTerneraRosada,1000, 25, " vacuno"),
            new Producto(eCortes.SolomilloDeVaca,1000, 28, " vacuno"),
            new Producto(eCortes.TapaDeTerneraRosada,1000, 13, " vacuno"),
            #endregion

            #region CERDO
            new Producto(eCortes.ChuletaDeCerdo,1000, 8, " cerdo"),
            new Producto(eCortes.CostillaAdobada,1000, 10, " cerdo"),
            new Producto(eCortes.Ibéricos,1000, 12, " cerdo"),
            new Producto(eCortes.LomoAdobado,1000, 10, " cerdo"),
            new Producto(eCortes.PancetaDeCerdo,1000, 6, " cerdo"),
            new Producto(eCortes.Picadillo, 1000,5, " cerdo"),
            new Producto(eCortes.SolomilloDeCerdo,1000, 12, " cerdo"),
            new Producto(eCortes.TiraDeCostillaDeCerdo,1000, 10, " cerdo"),
            #endregion

            #region CORDERO

            new Producto(eCortes.Chuletillas,3000, 14, "cordero"),
            new Producto(eCortes.ChuletillasDeLechazo,1000, 14, "cordero"),
            new Producto(eCortes.ChuletillasDeRecental,1000, 14, "cordero"),
            new Producto(eCortes.Delantero,1000, 10, "cordero"),
            new Producto(eCortes.DelanteroLechazo,1000, 15, "cordero"),
            new Producto(eCortes.Lechazo,1000, 16, "cordero"),
            new Producto(eCortes.Manitas,1000,17, "cordero"),
            new Producto(eCortes.ManitasDeLechazo,1000, 17, "cordero"),
            new Producto(eCortes.Pierna, 1000,18, "cordero"),
            new Producto(eCortes.PiernaYPaletillaDeLechazo,1000, 18, "cordero"),
            #endregion

            #region POLLO
            new Producto(eCortes.Pechuga,1000, 35, " pollo"),
            new Producto(eCortes.Muslos,1000, 25, " pollo"),
            new Producto(eCortes.Alas,1000, 20, " pollo"),
            new Producto(eCortes.PolloEntero,1000, 22, " pollo"),
            #endregion

            #region OTROS
            new Producto(eCortes.Hamburguesas,200, 21, "Producto procesado de carne"),
            new Producto(eCortes.Salchichas,150, 15, "Producto procesado de carne"),
            #endregion
        };

        /// <summary>
        /// Filtra los productos que estan sin stock (0) y los elimina de la lista
        /// </summary>
        /// <returns> Retorna la lista de heladera filtrada </returns>
        public List<Producto> HeladeraCliente()
        {
            List<Producto> heladeraCliente = new List<Producto>();

            foreach (Producto producto in ListaProductos)
            {
                if (producto.Stock != 0 )
                {
                    heladeraCliente.Add(producto);
                }
            }

            return heladeraCliente;
        }

        /// <summary>
        /// Ordeno la lista por el criterio pasado.
        /// </summary>
        /// <param name="Criterio"></param>
        /// <param name="l"></param>
        /// <returns></returns>
        public List<Producto> OrdenarProductos(int Criterio, List<Producto> l)
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


        /// <summary>
        /// Valida la cantidad del stock y determina si es valido o no
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns> si hay error devuelve 1 ( es menor a 0 o menor al stock original), 2 ( es una letra ) y 0 (si esta ok)</returns>
        public int ReponerStock ( Producto producto, string cantidad)
        {
            int retorno;
            int aux;

            if (int.TryParse(cantidad, out aux))
            {
                if (aux > 0  && producto.Stock <= aux)
                {
                    // Actualizar el stock del producto
                    producto.Stock = aux;
                    retorno = 0;
                }
                else
                {
                    retorno = 1;
                }
            }
            else
            {
                retorno = 2;
            }

            return retorno;
        }
    }   
}
