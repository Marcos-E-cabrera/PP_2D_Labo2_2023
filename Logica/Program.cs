using Biblioteca_Carniceria;
using System.ComponentModel;

namespace Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Vendedor vendedor = new Vendedor();
            Producto producto = new Producto();
            Heladera heladera = new Heladera();
            Carrito carrito = new Carrito();
            Historial historial = new Historial();


            Console.WriteLine("\n**************** SELECCION DE CLIENTE *******************");
            Cliente cliente3 = new Cliente("Marcos", "Cabrera", 10000);
            Console.WriteLine($"Cliente: {cliente3.Nombre} {cliente3.Apellido}, Saldo: {cliente3.Saldo}");  

            Console.WriteLine("[ VENDER ]");
            heladera.getProducto(2,out producto);
            cliente3.CargarCarrito(producto);
            cliente3.CargarCarrito(producto);
            //producto = cliente3.getProducto(4);
            //cliente3.CargarCarrito(producto);
            //producto = cliente3.getProducto(5);
            //cliente3.CargarCarrito(producto);


            Console.WriteLine("[ COMPRAR ]");
            //carrito.Comprar(cliente3.ListCarrito, cliente3.Saldo, cliente3, false);

            Console.WriteLine("[ CARRITO ]: ");
            foreach (Producto p in vendedor.ListCarrito)
            {
                Console.WriteLine($"{p.Nombre},{p.Stock},{p.Precio},{p.Tipo}");
            }

            Console.WriteLine("\n[ LIMPIAR CARRITO ]");
            vendedor.LimpiarCarrito();

            Console.WriteLine($"\n[ FACTURA ]: {Factura.nFactura} ");
            //foreach (Factura p in carrito.ListaFactura)
            //{
            //    Console.WriteLine($"{p.Nombre},{p.Cantidad},{p.PrecioUnitario},{p.Total}");
            //}
            //Console.WriteLine($"TOTAL: {carrito.Monto}");

            //Console.WriteLine("\n[ LIMPIAR FACTURA ]");
            //carrito.LimpiarFactura();

            Console.WriteLine("\n[ HISTORIAL ]: ");
            foreach (Historial h in Vendedor.ListaHistorial)
            {
                Console.WriteLine($"{h.NombreProducto},{h.Cantidad},{h.Total},{h.Nombre},{h.Apellido}");
            }

        }
    }
}
