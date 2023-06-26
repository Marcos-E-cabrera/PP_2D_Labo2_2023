using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// LOGIN -> Cliente
namespace Biblioteca_Carniceria
{
    public class Cliente : Usuario, ICarrito
    {
        #region CAMPOS
        float _saldo;
        public static float auxMonto;

        // flag saldo
        bool _clienteCargado;

        // flag Carrito
        bool _stockMax = false;
        bool _productoCargado = false;
        
        public List<Producto> ListCarrito = new List<Producto>(); // Lista carrito ( contiene los productos en el carrito)
        
        #endregion

        #region PROPIEDADES
        
        public float Saldo { get => _saldo; set => _saldo = value; }
        #endregion

        #region CONSTRUCTORES
        public Cliente ()
        {
            Usuario.Id ++;
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.Email = string.Empty;
            this.Password = string.Empty;

            this.Saldo = 0;
        }

        public Cliente(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public Cliente(string nombre, string apellido, float saldo) : this (nombre,apellido)
        {
            Saldo = saldo;
        }


        public Cliente(string nombre, string apellido, float saldo, string email, string password ) : this ( nombre,apellido,saldo)
        {
            this.Email = email;
            this.Password = password;
        }
        #endregion

        #region METODOS CARRITO

        /// <summary>
        /// EL usuario ingresara un producto como parametro y lo cargara a una lista carrito para poder comprar estos productos
        /// </summary>
        /// <param name="producto"></param>
        /// <returns> ERROR: [1](Sin stock), [2](Saldo no suficiente), [3](Tope de producto) - OK: [0](TODO BIEN) </returns>
        public int CargarCarrito(Producto producto)
        {
            Producto aux = new Producto();

            int retorno = 1; // SIN STOCK

            if (producto.Stock > 0) // pregunta si el produto tiene stock
            {
                // el saldo tiene q ser mayor a 0 y mayor al precio del producto
                if (Saldo > 0 && producto.Precio <= Saldo)
                {
                    auxMonto = Saldo;
                    foreach (Producto producto_Carrito in ListCarrito)
                    {
                        // al saldo le voy restando eel precio del producto
                        auxMonto -= producto.Precio;   // Actualizar el saldo

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
                        ListCarrito.Add(new Producto(aux.Corte, aux.Precio, 1, (int)aux.Tipo));
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

            return retorno;
        }
        #endregion

        #region TIPO DE USUARIO
        /// <summary>
        /// El usuario obtendra el tipo de usuario que es
        /// </summary>
        /// <returns>Tipo Cliente</returns>
        public override string ObtenerUsuario()
        {
            return "Cliente";
        }
        #endregion
    }
}
