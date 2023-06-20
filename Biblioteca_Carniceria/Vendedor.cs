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
        #region CAMPOS
        public static decimal MontoCliene;
        public static bool clienteCargado = false;

        private bool _stockMax = false;
        private bool _productoCargado = false;

        #region LISTAS

        public List<Cliente> ListClientes; // Lista de Clientes
        public List<Producto> ListCarrito; // Lista carrito ( contiene los productos en el carrito)

        public static List<Historial> ListaHistorial = new List<Historial>(); // Lista de Historial de ventas
        public static List<Producto> ListaProductos = new List<Producto>(); // lista de Productos 
        #endregion

        #endregion

        #region CONSTRUCTOR
        public Vendedor()
        {
            ListaProductos = Heladera.ListHeladera;
            ListClientes = new List<Cliente>();
            ListCarrito = new List<Producto>();
            MontoCliene = 0;

            GenerarClientes();
        }
        #endregion

        #region SELECCION DE CLIENTE

        #region GENERACION DE CLIENTES
        /// <summary>
        /// Genera una lista de clientes ( NOMBRE, APELLIDO, SALDO)
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

        #region OBTENER MONTO
        /// <summary>
        /// Carga el dinero del cliente seleccionado en la variable estatica MontoCliente
        /// </summary>
        /// <param name="cliente"></param>
        public void getMontoCliente(Cliente cliente)
        {
            MontoCliene = cliente.Saldo;
        }
        #endregion

        #endregion

        #region MANTENIMIENTO  HELADERA 

        #region AGREGAR PRODUCTO
        /// <summary>
        /// Se le ingresa como parametro un nombre, precio, stock y tipo(enum)  y lo agrega a la lista de productos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        /// <param name="tipo"></param>
        /// <returns> ERROR: [1](Parametros mal ingresados), [2](ya existe) - OK: [0](TODO BIEN) </returns>
        public static int Agregar(string nombre, decimal precio, int stock, string tipo )
        {
            int rta = 1; // error[1] parametros mal ingresados
            bool valido = true;

            eTipo tipoAux = (eTipo)Enum.Parse(typeof(eTipo), tipo);
            Producto producto = new Producto();
            producto.Nombre = nombre;
            producto.Precio = precio;
            producto.Stock = stock;
            producto.Tipo = tipoAux;


            if (nombre != "" && precio > 0 && stock > 0)
            {
                foreach (Producto p in ListaProductos)
                {
                    if (producto.Nombre == p.Nombre)
                    {
                        rta = 2; // error [2] ya existe
                        break;
                    }
                }

                if (valido && rta != 2)
                {
                    ListaProductos.Add(new Producto(producto.Nombre, producto.Precio, producto.Stock, producto.Tipo));
                    rta = 0;
                }
            }


            return rta;
        }

        #endregion

        #region REPONER PRODUCTO
        /// <summary>
        /// Se le ingresa un producto y la cantidad a reponer, si es valida lo reponer y si no devuelve un error
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        /// <returns> ERROR: [1](es menor a 0 o menor al stock original), [2]( es una letra ) - OK: [0](TODO BIEN) </returns>
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

        #region METODOS CARRITO

        #region CARGA DE PRODUCTO

        /// <summary>
        /// EL usuario ingresara un producto como parametro y lo cargara a una lista carrito para poder comprar estos productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns> ERROR: [1]Cliente no seleccionado), [2](Sin stock), [3](Saldo no suficiente), [4](Tope de producto) - OK: [0](TODO BIEN) </returns>
        public override int CargarCarrito(Producto producto)
        {
            Producto aux = new Producto();

            int retorno = 1; // cliente no cargado

            if (clienteCargado)
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
                            ListCarrito.Add(new Producto(aux.Nombre, aux.Precio, 1 , aux.Tipo));
                            retorno = 0;
                        }

                        // se sumo un producto al carrito
                        _productoCargado = false;

                    }
                    else
                    {
                        retorno = 3;
                    }
                }
                else
                {
                    retorno = 2;
                }
            }
            
            return retorno;
        }
        #endregion

        #region CARGAR HISTORIAL
        /// <summary>
        /// Recibe la factura y el nombre del cliente y lo guarda en la lista historial para mantener un control de ventas
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public static void CargarHistorial(List<Factura> factura,string nombre, string apellido)
        {
            Historial newHistorial = new Historial();

            foreach (Factura f in factura)
            {
                newHistorial.NombreProducto = f.NombreProducto;
                newHistorial.Cantidad = f.Cantidad;
                newHistorial.Total = f.Total;
                newHistorial.Nombre = nombre;
                newHistorial.Apellido = apellido;

                ListaHistorial.Add(new Historial(newHistorial.NombreProducto, newHistorial.Cantidad, newHistorial.Total, newHistorial.Nombre, newHistorial.Apellido));
            }

        }
        #endregion

        #region LIMPIAR CARRITO
        /// <summary>
        /// Liempia el carrito
        /// </summary>
        public void LimpiarCarrito()
        {
            ListCarrito.Clear();
        }
        #endregion

        #endregion

        #region TIPO DE USUARIO
        /// <summary>
        /// El usuario obtendra el tipo de usuario que es
        /// </summary>
        /// <returns>Tipo Vendedor</returns>
        public override string ObtenerUsuario()
        {
            return "Vendedor";
        }
        #endregion
    }
}

