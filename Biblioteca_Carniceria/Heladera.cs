using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// PRODUCTO -> HELADERA
namespace Biblioteca_Carniceria
{
    public class Heladera : Producto
    {
        public List<Producto> ListaProductos = new List<Producto>();

        public Heladera()
        {
            // hardcodeo de productos
            // Vacuno
            ListaProductos.Add(new Producto("Asado", eCortes.Asado, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Vacio", eCortes.Vacio, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("BifeDeChorizo", eCortes.BifeDeChorizo, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Entraña", eCortes.Entraña, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Matambre", eCortes.Matambre, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Cuadril", eCortes.Cuadril, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("LomoVetado", eCortes.LomoVetado, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("ColitaDeCuadril", eCortes.ColitaDeCuadril, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("TapaDeAsado", eCortes.TapaDeAsado, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Marucha", eCortes.Marucha, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Falda", eCortes.Falda, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("RoastBeef", eCortes.RoastBeef, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Cadera", eCortes.Cadera, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("CaderaDeTernera", eCortes.CaderaDeTernera, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Callos", eCortes.Callos, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("ChuletaDeTerneraRosada", eCortes.ChuletaDeTerneraRosada, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("ChuletónDeVaca", eCortes.ChuletónDeVaca, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Contra", eCortes.Contra, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("EntrecotDeTerneraRosada", eCortes.EntrecotDeTerneraRosada, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("EtrecotDeTerneraBlanca", eCortes.EtrecotDeTerneraBlanca, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Lengua", eCortes.Lengua, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("MorcilloDeTerneraBlanca", eCortes.MorcilloDeTerneraBlanca, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Osobuco", eCortes.Osobuco, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("PerdizDeTernera", eCortes.PerdizDeTernera, 10, "Corte ternero"));
            ListaProductos.Add(new Producto("Picaña de vaca", eCortes.PicañaDeVaca, 15, "Corte vacuno"));
            ListaProductos.Add(new Producto("Redondo de ternera rosada", eCortes.RedondoDeTerneraRosada, 18, "Corte vacuno"));
            ListaProductos.Add(new Producto("Roti de ternera blanca", eCortes.RotiDeTerneraBlanca, 17, "Corte vacuno"));
            ListaProductos.Add(new Producto("Solomillo de ternera rosada", eCortes.SolomilloDeTerneraRosada, 25, "Corte vacuno"));
            ListaProductos.Add(new Producto("Solomillo de vaca", eCortes.SolomilloDeVaca, 28, "Corte vacuno"));
            ListaProductos.Add(new Producto("Tapa de ternera rosada", eCortes.TapaDeTerneraRosada, 13, "Corte vacuno"));

            // Cerdo
            ListaProductos.Add(new Producto("Chuleta de cerdo", eCortes.ChuletaDeCerdo, 8, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Costilla adobada", eCortes.CostillaAdobada, 10, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Ibéricos", eCortes.Ibéricos, 12, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Lomo adobado", eCortes.LomoAdobado, 10, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Panceta de cerdo", eCortes.PancetaDeCerdo, 6, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Picadillo", eCortes.Picadillo, 5, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Solomillo de cerdo", eCortes.SolomilloDeCerdo, 12, "Corte de cerdo"));
            ListaProductos.Add(new Producto("Tira de costilla de cerdo", eCortes.TiraDeCostillaDeCerdo, 10, "Corte de cerdo"));

            // Cordero
            ListaProductos.Add(new Producto("Chuletillas", eCortes.Chuletillas, 14, "Corte de cordero"));
            ListaProductos.Add(new Producto("Chuletillas de lechazo", eCortes.ChuletillasDeLechazo, 14, "Corte de cordero"));
            ListaProductos.Add(new Producto("Chuletillas de recental", eCortes.ChuletillasDeRecental, 14, "Corte de cordero"));
            ListaProductos.Add(new Producto("Delantero", eCortes.Delantero, 10, "Corte de cordero"));
            ListaProductos.Add(new Producto("Delantero de lechazo", eCortes.DelanteroLechazo, 15, "Corte de cordero"));
            ListaProductos.Add(new Producto("Lechazo", eCortes.Lechazo, 16, "Corte de cordero"));
            ListaProductos.Add(new Producto("Manitas", eCortes.Manitas, 17, "Corte de cordero"));
            ListaProductos.Add(new Producto("Manitas de lechazo", eCortes.ManitasDeLechazo, 17, "Corte de cordero"));
            ListaProductos.Add(new Producto("Pierna", eCortes.Pierna, 18, "Corte de cordero"));
            ListaProductos.Add(new Producto("Pierna y paletilla de lechazo", eCortes.PiernaYPaletillaDeLechazo, 18, "Corte de cordero"));

            // Pollo
            ListaProductos.Add(new Producto("Pechuga de pollo", eCortes.Pechuga, 35, "Corte de pollo"));
            ListaProductos.Add(new Producto("Muslos de pollo", eCortes.Muslos, 25, "Corte de pollo"));
            ListaProductos.Add(new Producto("Alas de pollo", eCortes.Alas, 20, "Corte de pollo"));
            ListaProductos.Add(new Producto("Pollo entero", eCortes.PolloEntero, 22, "Corte de pollo"));

            // otros
            ListaProductos.Add(new Producto("Hamburguesas", eCortes.Hamburguesas, 21, "Producto procesado de carne"));
            ListaProductos.Add(new Producto("Salchichas", eCortes.Salchichas, 15, "Producto procesado de carne"));

        }

    }
}
