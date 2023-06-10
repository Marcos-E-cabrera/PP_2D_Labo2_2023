using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LOGIN -> Cliente
namespace Biblioteca_Carniceria
{
    public class Cliente : Usuario
    {
        // atributos
        string _nombre;
        string _apellido;

        // variables globales
        //int _indexCliente;
        //int _indexProducto;
        decimal _saldo;
        decimal _auxMonto;

        // flag saldo
        private bool _clienteCargado;

        // flag Carrito
        private bool _stockMax = false;
        private bool _productoCargado = false;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public decimal Saldo { get => _saldo; set => _saldo = value; }

        //public int IndexCliente { get => _indexCliente; set => _indexCliente = value; }
        //public int IndexProducto { get => _indexProducto; set => _indexProducto = value; }
        public decimal AuxMonto { get => _auxMonto = Saldo; set => _auxMonto = value; }

        public List<Producto> ListCarrito = new List<Producto>(); // Lista carrito ( contiene los productos en el carrito)

        // constructores
        public Cliente ()
        {
            Nombre = "XXXXXX";
            Apellido = "XXXXXX";
            Saldo = 0;
        }

        public Cliente(string nombre, string apellido) : this()
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public Cliente(string nombre, string apellido, decimal saldo) : this (nombre,apellido)
        {
            Saldo = saldo;
        }

        #region VENTA


        /// <summary>
        /// Valida la carga de un producto para ser cargado al carrito
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>retorna 0 (OK), 1(sin stock), 2(no alcanza el saldo), 3(Tope de producto)</returns>
        public override int CargarCarrito(Producto producto)
        {
            Producto aux = new Producto();

            int retorno = 1; // cliente no cargado

            if (producto.Stock > 0) // pregunta si el produto tiene stock
            {
                // el saldo tiene q ser mayor a 0 y mayor al precio del producto
                if (Saldo > 0 && producto.Precio <= Saldo)
                {
                    foreach (Producto producto_Carrito in ListCarrito)
                    {
                        // al saldo le voy restando eel precio del producto
                        AuxMonto -= producto.Precio;   // Actualizar el saldo

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
                                retorno = 3; // tope de producto
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
                    retorno = 2;
                }
            }
            else
            {
                retorno = 1;
            }

            return retorno;
        }
        #endregion



        public override string ObtenerUsuario()
        {
            return "Cliente";
        }



    }
}
