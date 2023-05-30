using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
    

namespace Biblioteca_Carniceria
{
    public class Vendedor : Usuario
    {
        // variables globales
        public static decimal MontoCliene;

        // flag saldo
        bool _clienteCargado;

        // flag Carrito
        bool _stockMax;
        bool _productoCargado;

        /// <summary>
        /// Lista harcodeada de clientes. El vendedor va a seleccionar uno de estos clientes.
        /// </summary>
        public List<Cliente> ListClientes;
        public List<Producto> ListCarrito; // Lista carrito ( contiene los productos en el carrito)
        public static List<Historial> ListaHistorial = new List<Historial>();

        public Vendedor()
        {
            ListClientes = new List<Cliente>();
            ListCarrito = new List<Producto>();

            GenerarClientes();
            MontoCliene = 0;
            _clienteCargado = false;
            _stockMax = false;
            _productoCargado = false;
        }

        #region SELECCION DE CLIENTE

        #region Generar Cliente
        /// <summary>
        /// Genera una lista de clientes
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

        #region Seleccionar Cliente
        /// <summary>
        /// Obtiene un cliente de la lista clintes y lo devuelve.
        /// </summary>
        /// <param name="index"> index del cliente que se quiere obtener</param>
        /// <returns>Retorna el cliente obtenido del index</returns>
        public Cliente getCliente(int index)
        {
            Cliente cliente = new Cliente();

            if (index < ListClientes.Count && index >= 0)
            {
                cliente = ListClientes[index];
                getMontoCliente(cliente);
                _clienteCargado = true;
            }
            
            return cliente;
        }
        #endregion

        #region Carga de Monto
        /// <summary>
        /// Carga el dinero del cliente en la variable estatica MontoCliente
        /// </summary>
        /// <param name="cliente"></param>
        public void getMontoCliente(Cliente cliente)
        {
            MontoCliene = cliente.Saldo;
        }
        #endregion

        #endregion

        #region REPONER

       

        #region Reponer stock
        /// <summary>
        /// Valida la cantidad del stock y determina si es valido o no
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns> si hay error devuelve 1 ( es menor a 0 o menor al stock original)); 2 ( es una letra ) y 0 (si esta ok)</returns>
        public static int Reponer(Producto producto, string cantidad)
        {
            int retorno;
            int aux;

            if (int.TryParse(cantidad, out aux))
            {
                if (aux > 0 )
                {
                    producto.Stock += aux;
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

        #endregion

        #region VENTA


        /// <summary>
        /// Valida la carga de un producto para ser cargado al carrito
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>retorna 0 (OK)< 1(Cliente no selecionado), 2(sin stock), 3(no alcanza el saldo), 4(Tope de producto)</returns>
        public override int CargarCarrito(Producto producto)
        {
            Producto aux = new Producto();

            int retorno = 1; // cliente no cargado

            if (_clienteCargado)
            {
                if (producto.Stock > 0) // pregunta si el produto tiene stock
                {
                    // el saldo tiene q ser mayor a 0 y mayor al precio del producto
                    if (MontoCliene > 0 && producto.Precio <= MontoCliene)
                    {
                        foreach (Producto producto_Carrito in ListCarrito)
                        {
                            // al saldo le voy restando eel precio del producto
                            MontoCliene -= producto.Precio;   // Actualizar el saldo

                            // SI el producto_Carrito = al producto seleccionado se acumula
                            if (producto_Carrito == producto) // sobrecarga de operadores
                            {
                                // Si el producto ya está en la lista de carrito, aumentar su cantidad
                                if (producto_Carrito.Stock < producto.Stock)  // la cantidad que se compra tiene q ser menor al stock del producto
                                {
                                    // El stock pasara a ser cantidad en la lista del carrito
                                    producto_Carrito.Stock++;
                                    // producto ya carcado
                                    _productoCargado = true;
                                    retorno = 0;
                                }
                                else
                                {
                                    retorno = 4; // tope de producto
                                    _stockMax = true;
                                }
                                break;
                            }
                        }


                        // Si el producto no está en la lista de carrito, agregarlo como un nuevo producto
                        if (!_productoCargado && !_stockMax)
                        {
                            aux = producto;
                            ListCarrito.Add(new Producto(aux.Nombre, aux.Precio, 1, aux.Tipo));
                            retorno = 0;
                        }

                        // se sumo un producto al carrito
                        _productoCargado = false;

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



        #region Cargar factura al historial Historial
        public static void CargarHistorial(List<Factura> factura,string nombre, string apellido)
        {
            Historial newHistorial = new Historial();

            foreach (Factura f in factura)
            {
                newHistorial.NombreProducto = f.Nombre.ToString();
                newHistorial.Cantidad = f.Cantidad;
                newHistorial.Total = f.Total;
                newHistorial.Nombre = nombre;
                newHistorial.Apellido = apellido;

                ListaHistorial.Add(new Historial(newHistorial.NombreProducto, newHistorial.Cantidad, newHistorial.Total, newHistorial.Nombre, newHistorial.Apellido));
            }
        }
        #endregion


        public void LimpiarCarrito()
        {
            ListCarrito.Clear();
        }


        public override string ObtenerUsuario()
        {
            return "Vendedor";
        }

    }
}

