using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Heladera : Producto
    {
        public List<Producto> ListaProductos = new List<Producto>();

        public Heladera()
        {
            // hardcodeo de productos
            ListaProductos.Add(new Producto("Asado", eCortes.Asado, 10, "Corte vacuno"));
            ListaProductos.Add(new Producto("Vacio", eCortes.Vacio, 0, "Corte vacuno"));
            ListaProductos.Add(new Producto("Bife de Chorizo", eCortes.BifeDeChorizo, 15, "Corte vacuno"));
            ListaProductos.Add(new Producto("Entraña", eCortes.Entraña, 13, "Corte vacuno"));
            ListaProductos.Add(new Producto("Matambre", eCortes.Matambre, 16, "Corte vacuno"));
            ListaProductos.Add(new Producto("Bondiola", eCortes.Bondiola, 0, "Cerdo"));
            ListaProductos.Add(new Producto("Chuletas", eCortes.Chuletas, 9, "Cerdo"));
            ListaProductos.Add(new Producto("Panceta", eCortes.Panceta, 7, "Cerdo"));
            ListaProductos.Add(new Producto("Costillas", eCortes.Costillas, 8, "Cerdo"));
            ListaProductos.Add(new Producto("Lomo", eCortes.Lomo, 20, "Cerdo"));
            ListaProductos.Add(new Producto("Pechuga", eCortes.Pechuga, 6, "Pollo"));
            ListaProductos.Add(new Producto("Muslos", eCortes.Muslos, 4, "Pollo"));
            ListaProductos.Add(new Producto("Alas", eCortes.Alas, 3, "Pollo"));
            ListaProductos.Add(new Producto("Pollo Entero", eCortes.PolloEntero, 5, "Pollo"));
            ListaProductos.Add(new Producto("Pavo", eCortes.Pavo, 18, "Pavo"));
        }
        
    }
}
