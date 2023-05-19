using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Vendedor : Heladera
    {
        // variables globales
        private static int indexCliente;
        private static int indexProducto;
        private static decimal saldoCliente;

        // flag saldo
        private bool clienteCargado;

        // flag Carrito
        private bool stockMax;
        private bool productoCargado;

        /// <summary>
        /// Lista harcodeada de clientes. El vendedor va a seleccionar uno de estos clientes.
        /// </summary>
        private List<Cliente> ListClientes = new List<Cliente>();

        public static List<Producto> ListCarrito = new List<Producto>(); // Lista carrito ( contiene los productos en el changito)

        public static decimal SaldoCliente { get => saldoCliente; set => saldoCliente = value; }
        public static int IndexCliente { get => indexCliente; set => indexCliente = value; }
        public static int IndexProducto { get => indexProducto; set => indexProducto = value; }

        public Vendedor()
        {
            GenerarClientes();
            SaldoCliente = 0;
            clienteCargado= false;
            stockMax = false;
            productoCargado = false;
        }

        // PUNTO 1 - SELECCION DE CLIENTE
        #region Generar Cliente
        /// <summary>
        /// Genero una lista de cliente para ser seleccionado
        /// </summary>
        private void GenerarClientes()
        {
            ListClientes.Add(new Cliente("Nonah", "Dingle", 500));
            ListClientes.Add(new Cliente("Gage", "Withringten", 3737));
            ListClientes.Add(new Cliente("Zenia", "Ferrotti", 9793));
            ListClientes.Add(new Cliente("Diann", "Gaitung", 19855));
            ListClientes.Add(new Cliente("Gena", "Lembrick", 13681));
            ListClientes.Add(new Cliente("Susanna", "Childe", 4885));
            ListClientes.Add(new Cliente("Broderic", "Scintsbury", 4213));
            ListClientes.Add(new Cliente("Frederique", "Rowesby", 7223));
            ListClientes.Add(new Cliente("Abagael", "Cramphorn", 18678));
            ListClientes.Add(new Cliente("Kelsi", "Kinver", 12232));
            ListClientes.Add(new Cliente("Luca", "Morkham", 16142));
            ListClientes.Add(new Cliente("Brigg", "Winckles", 2880));
            ListClientes.Add(new Cliente("Malorie", "McCague", 14862));
            ListClientes.Add(new Cliente("Daisey", "Ateggart", 8772));
            ListClientes.Add(new Cliente("Cathi", "Heighway", 16726));
            ListClientes.Add(new Cliente("Ardys", "Belding", 4869));
            ListClientes.Add(new Cliente("Katinka", "Huggard", 13916));
            ListClientes.Add(new Cliente("Mab", "Falco", 14626));
            ListClientes.Add(new Cliente("Fairfax", "Clines", 17337));
            ListClientes.Add(new Cliente("Meridel", "Desorts", 14010));
            ListClientes.Add(new Cliente("Goldarina", "Iannuzzelli", 4444));
            ListClientes.Add(new Cliente("Alvinia", "Vian", 731));
            ListClientes.Add(new Cliente("Leonie", "Jaskowicz", 11462));
        }
        #endregion

        #region Mostrar Clientes
        /// <summary>
        /// Permite Listar un grupo de clientes para porder venderle
        /// </summary>
        /// <returns></returns>
        public void MostrarCliente(List<Cliente> cliente) // Despues pasarlo al datagridview
        {
            Console.WriteLine("Nombre,Apellido,Saldo");
            foreach (Cliente aux in cliente)
            {
                Console.WriteLine($"{aux.Nombre}, {aux.Apellido}, ${aux.Saldo}");
            }
        }
        #endregion

        #region Mostrar Cliente seleccionado
        /// <summary>
        /// Muestra el Cliente pasado como parametro
        /// </summary>
        /// <param name="cliente"></param>
        public void MostrarClienteSeleccionado(Cliente cliente) // Despues pasarlo al datagridview
        {
           Console.WriteLine($"{cliente.Nombre}, {cliente.Apellido}, ${cliente.Saldo}");
        }
        #endregion

        #region Seleccionar Cliente
        /// <summary>
        /// Pide seleccionar un cliente de la ListCliente y lo devuelve para poder ser usado
        /// </summary>
        /// <returns> retorna el cliente selecionado</returns>
        public Cliente SeleccionDeCliente()
        {
            Cliente clienteSelecionado = new Cliente();

            MostrarCliente(ListClientes);

            Console.WriteLine("Selecione el indice del cliente: ");
            indexCliente = int.Parse(Console.ReadLine());

            if (IndexCliente < ListClientes.Count && IndexCliente >= 0)
            {
                clienteSelecionado = ListClientes[IndexCliente];
                CargarSalso(clienteSelecionado);
                clienteCargado = true;
            }           

            return clienteSelecionado;
        }
        #endregion

        // PUNTO 2 - REPONER

        #region Mostrar Heladera
        /// <summary>
        /// Muestra la listHeladera
        /// </summary>
        /// <param name="lista"></param>
        public void MostrarHeladera()
        {
            Console.WriteLine("Nombre, Precio, Stock. Detalle");
            foreach (Producto producto in ListHeladera)
            {
                Console.WriteLine($"{producto.Nombre}, {producto.Precio}, {producto.Stock}, {producto.Detalle}");
            }
        }
        #endregion

        #region Mostrar producto seleccionado
        /// <summary>
        /// Muestra el producto seleccionado
        /// </summary>
        /// <param name="producto"></param>
        public void MostrarProductoSeleccionado(Producto producto)
        {
            Console.WriteLine($"{producto.Nombre}, {producto.Precio}, {producto.Stock}, {producto.Detalle}");
        }
        #endregion

        #region selecionar producto
        /// <summary>
        /// Selecciona un producto de la lista
        /// </summary>
        /// <returns> devuelve el producto seleccionado</returns>
        public Producto SeleccionarProducto ()
        {
            Producto producto = new Producto();
           
            Console.WriteLine("Selecione el indice del producto: ");
            indexProducto = int.Parse(Console.ReadLine());

            if (IndexProducto < ListHeladera.Count && IndexProducto >= 0)
            {
                producto = ListHeladera[IndexProducto];
            }

            return producto;
        }
        #endregion

        #region Reponer stock
        /// <summary>
        /// Valida la cantidad del stock y determina si es valido o no
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns> si hay error devuelve 1 ( es menor a 0 o menor al stock original)); 2 ( es una letra ) y 0 (si esta ok)</returns>
        public int ReponerStock(Producto producto, string cantidad)
        {
            int retorno;
            int aux;

            if (int.TryParse(cantidad, out aux))
            {
                if (aux > 0 && producto.Stock <= aux)
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
        #endregion

        // PUNTO 3 - VENTA
        #region Carga de SAaldo
        /// <summary>
        /// Cargo el saldo del cliente a la variable goblal para poder hacer compras
        /// </summary>
        /// <param name="cliente"></param>
        public void CargarSalso( Cliente cliente )
        {
            SaldoCliente = cliente.Saldo;
            Console.WriteLine($"Se cargo el saldo: ${SaldoCliente}");
        }
        #endregion

        #region aviso de carga de cliente 
        public bool CargaDeCliente ()
        {
            return clienteCargado;
        }
        #endregion

        #region Carga de carrito
        /// <summary>
        /// Valida la carga de un producto para ser cargado al carrito
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>retorna 0 (OK)< 1(Cliente no selecionado), 2(sin stock), 3(no alcanza el saldo)</returns>
        public int CargaCarrito(Producto producto) // ARREGLAR ACA!!
        {
            Producto aux = new Producto();

            int retorno = 1; // cliente no cargado

            if (CargaDeCliente())
            {
                if ( producto.Stock > 0 ) // pregunta si el produto tiene stock
                {
                    // el saldo tiene q ser mayor a 0 y mayor al precio del producto
                    if (saldoCliente > 0 && producto.Precio <= saldoCliente)
                    {                      
                        foreach (Producto producto_Carrito in ListCarrito) 
                        {
                            // al saldo le voy restando eel precio del producto
                            saldoCliente -= producto.Precio;   // Actualizar el saldo

                            // SI el producto_Carrito = al producto seleccionado se acumula
                            if (producto_Carrito == producto) // sobrecarga de operadores
                            {
                                // Si el producto ya está en la lista de carrito, aumentar su cantidad
                                if (producto_Carrito.Stock < producto.Stock)  // la cantidad que se compra tiene q ser menor al stock del producto
                                {
                                    // El stock pasara a ser cantidad en la lista del carrito
                                    producto_Carrito.Stock++;
                                     // producto ya carcado
                                    productoCargado = true;
                                    retorno = 0;
                                }
                                else
                                {
                                    Console.WriteLine("stock de producto alcanzado");
                                    stockMax = true;
                                }
                                break;
                            }
                        }


                        // Si el producto no está en la lista de carrito, agregarlo como un nuevo producto
                        if (!productoCargado && !stockMax)
                        {
                            aux = producto;
                            retorno = 0;
                            ListCarrito.Add(new Producto(aux.Nombre,aux.Precio,1, aux.Detalle));
                            Console.WriteLine("Se añadio correctamente!!");
                        }

                        // se sumo un producto al carrito
                        productoCargado = false;
                    }
                    else
                    {
                        retorno = 3;
                        Console.WriteLine("El saldo no es suficiente para comprar el producto");
                    }
                }
                else
                {
                    retorno = 2;
                    Console.WriteLine("No hay stock en ese producto");
                }
            }
            else
            {
                Console.WriteLine("Cliente no seleccionado");
            }

            return retorno;
        }
        #endregion

        #region Mostrar carrito
        public void MostrarCarrito ()
        {
            Console.WriteLine("Nombre,precio,cantidad,detalle");
            foreach (Producto aux in ListCarrito)
            {
                Console.WriteLine($"{aux.Nombre}, {aux.Precio}, {aux.Stock}, {aux.Detalle}");
            }
        }
        #endregion

      

        // ACTUALIZAR HELADERA
        #region Actualizacion de la lista heladera
        /// <summary>
        /// Actualiza la lista de la heladera principal
        /// </summary>
        /// <param name="producto"></param>
        public void ActualizarHeladera(Producto producto)
        {
      
            foreach ( Producto aux in ListHeladera )
            {
                if ( ListHeladera[IndexProducto] == aux )
                {
                    aux.Stock = producto.Stock;
                }
            }
        }
        #endregion

    }
}

