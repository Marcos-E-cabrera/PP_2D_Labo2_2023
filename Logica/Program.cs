using Biblioteca_Carniceria;
using System.ComponentModel;

namespace Logica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool salir = false;
            bool aniadir = false;
            char seguir;

            // Logica del programa
            Vendedor vendedor = new Vendedor();
            Producto producto = new Producto();
            Cliente cliente = new Cliente();
            CompraCarrito compraCarrito = new CompraCarrito();

            while (!salir) 
            {
                Console.WriteLine("ABM VENDEDOR");
                Console.WriteLine("[1] Seleccionar cliente");
                Console.WriteLine("[2] Reponer Stock");
                Console.WriteLine("[3] Añadir al Carrito");
                Console.WriteLine("[4] Ver Carrito");
                Console.WriteLine("[5] Comprar");
                Console.WriteLine("[6] Ver Factura");
                Console.WriteLine("[7] ver Historial");
                Console.WriteLine("[8] Ordenar Heladera");

                Console.WriteLine("[9] Salir");

                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                Console.Clear();
                
                switch (opcion)
                {
                    case 1:                      
                        // Selecciono cliente para vendedor
                        cliente = vendedor.SeleccionDeCliente();
                        vendedor.MostrarClienteSeleccionado(cliente);
                        vendedor.CargarSalso(cliente);
                        break;
                    case 2:
                        // muestro la heladera
                        vendedor.MostrarHeladera();
                        // Selecciono un producto para cambiar el stock
                        producto = vendedor.SeleccionarProducto();
                        // mostrar producto selecionado
                        vendedor.MostrarProductoSeleccionado(producto);

                        Console.Write("Ingrese el stock:  ");
                        string stock = Console.ReadLine();
                        // reponer stock
                        vendedor.ReponerStock(producto, stock);
                        // mostrar producto selecionado
                        vendedor.MostrarProductoSeleccionado(producto);
                        // actualizar heladera
                        vendedor.ActualizarHeladera(producto);
                        // mostrar heladera
                        vendedor.MostrarHeladera();
                        break;
                    case 3:
                        if (vendedor.CargaDeCliente())
                        {
                            while ( !aniadir )
                            {
                                vendedor.MostrarHeladera();
                                producto = vendedor.SeleccionarProducto();

                                vendedor.CargaCarrito(producto);

                                Console.Write("Seguir añadiendo productos al carrito (N/S): ");
                                string auxSeguir = Console.ReadLine();

                                if (char.TryParse(auxSeguir, out seguir) && seguir == 'N')
                                {
                                    aniadir = true;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cliente no seleccionado");
                        }
                        aniadir = false;

                        break;
                    case 4:
                        vendedor.MostrarCarrito();
                        break;
                    case 5:
                        compraCarrito.Comprar(Vendedor.ListCarrito, Vendedor.SaldoCliente, cliente);
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 9:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();

            } 




        }
    }
}