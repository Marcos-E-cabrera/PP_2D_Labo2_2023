using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public  class Carrito
    {
        #region CAMPOS
        static bool _carritoVacio = false;
        static bool _compraEfectuada = false;
        static bool _validarFactura = false ;
        static decimal _monto;
        public static int Pago;

        public static List<Factura> ListaProductos = new List<Factura>();
        #endregion

        #region PROPIEDADES
        static public decimal Monto { get => _monto; set => _monto = value; }
        #endregion

        #region CONSTRUCTOR
        public Carrito() 
        {
        }
        #endregion

        #region COMPRA
        /// <summary>
        /// Comprar la lista de productos pasada como parametro y tambien se le pasara la forma de pago 
        /// </summary>
        /// <param name="Carrito"></param>
        /// <param name="saldo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="auxSaldo"></param>
        /// <param name="formaPago"></param>
        /// <returns> ERROR: [1](Carrito vacio), [2](error de compra),[3](Saldo no suficiente) - OK: [0](TODO BIEN) </returns>
        public static int Comprar(List<Producto> Carrito, out float saldo, string nombre, string apellido, float auxSaldo ,int formaPago)
        {
            saldo = 0;

            int retorno = 1; // carrito esta vacio
            Cliente cliente = new Cliente(nombre,apellido,auxSaldo);
            if (Carrito.Count != 0)
            {
                // si no se compro y el carrito esta lleno se peudo comprar
                if (_compraEfectuada == false && _carritoVacio == false)
                {
                    // si es ok, pagara con efectivo y no lo paga con devito                  
                    if (formaPago == 0)
                    {
                        Pago = 0;

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito, cliente.Nombre, cliente.Apellido);
                        Monto = CargarMontoFinal();
                        
                        // el total apagar tiene que ser igual o menor al saldo del cliente
                        if (Monto <= (decimal)cliente.Saldo) 
                        {
                            cliente.Saldo = cliente.Saldo - (float)Monto;
                            saldo = cliente.Saldo;

                            Factura.nFactura++;

                            // Guardo la factura del cliente
                            Vendedor.CargarHistorial(ListaProductos, cliente.Nombre, cliente.Apellido);

                            _validarFactura = true;
                            _compraEfectuada = true;
                            retorno = 0; // compra exitosa
                        }
                        else
                        {
                            LimpiarFactura();
                            retorno = 3; // saldo no suficiente
                        }
                    }
                    else
                    {
                        Pago = 1;

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito,cliente.Nombre,cliente.Apellido);
                        Monto = RecargoDebito(CargarMontoFinal());
                            
                        // le paso la cantidad a pagar al carrito
                        if (Monto <= (decimal)cliente.Saldo)
                        {
                            cliente.Saldo = cliente.Saldo - (float)Monto;
                            saldo = cliente.Saldo;
                            Factura.nFactura++;
                            // Guardo la factura del cliente
                            Vendedor.CargarHistorial(ListaProductos,cliente.Nombre, cliente.Apellido);
                                
                            _validarFactura = true;
                            _compraEfectuada = true;
                            retorno = 0;
                        }
                        else
                        {
                            retorno = 3; // saldo no suficiente
                        }
                    }
                }
                else
                {
                    retorno = 2; // error de compra
                }
            }
            else
            {
                _carritoVacio = true;
            }

            foreach ( Producto p in Carrito)
            {
                foreach (Producto aux in CN_Heladera.ListHeladera)
                {
                    if ( p.Corte ==aux.Corte )
                    {
                        aux.Stock -= p.Stock;
                    }
                }
            }
           
            _compraEfectuada = false;
            return retorno;
        }

        public static int Comprar_Cliente(List<Producto> Carrito, ref Cliente cliente, int formaPago)
        {
            int retorno = 1; // carrito esta vacio
            if (Carrito.Count != 0)
            {
                // si no se compro y el carrito esta lleno se peudo comprar
                if (_compraEfectuada == false && _carritoVacio == false)
                {
                    // si es ok, pagara con efectivo y no lo paga con devito                  
                    if (formaPago == 0)
                    {
                        Pago = 0;

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito, cliente.Nombre, cliente.Apellido);
                        Monto = CargarMontoFinal();

                        // el total apagar tiene que ser igual o menor al saldo del cliente
                        if (Monto <= (decimal)cliente.Saldo)
                        {
                            cliente.Saldo = cliente.Saldo - (float)Monto;

                            Factura.nFactura++;

                            // Guardo la factura del cliente
                            Vendedor.CargarHistorial(ListaProductos, cliente.Nombre, cliente.Apellido);

                            _validarFactura = true;
                            _compraEfectuada = true;
                            retorno = 0; // compra exitosa
                        }
                        else
                        {
                            LimpiarFactura();
                            retorno = 3; // saldo no suficiente
                        }
                    }
                    else
                    {
                        Pago = 1;

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito, cliente.Nombre, cliente.Apellido);
                        Monto = RecargoDebito(CargarMontoFinal());

                        // le paso la cantidad a pagar al carrito
                        if (Monto <= (decimal)cliente.Saldo)
                        {
                            cliente.Saldo = cliente.Saldo - (float)Monto;
                            Factura.nFactura++;
                            // Guardo la factura del cliente
                            Vendedor.CargarHistorial(ListaProductos, cliente.Nombre, cliente.Apellido);

                            _validarFactura = true;
                            _compraEfectuada = true;
                            retorno = 0;
                        }
                        else
                        {
                            retorno = 3; // saldo no suficiente
                        }
                    }
                }
                else
                {
                    retorno = 2; // error de compra
                }
            }
            else
            {
                _carritoVacio = true;
            }

            foreach (Producto p in Carrito)
            {
                foreach (Producto aux in CN_Heladera.ListHeladera)
                {
                    if (p.Corte == aux.Corte)
                    {
                        aux.Stock -= p.Stock;
                    }
                }
            }

            _compraEfectuada = false;
            return retorno;
        }
        #endregion

        #region Recargo debito
        /// <summary>
        /// Agregra 5% de recargo al total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public static decimal RecargoDebito(decimal total)
        {
            decimal cincoPorCiento = total * 0.05m;
            return total += cincoPorCiento;
        }
        #endregion

        #region CREAR FACTURA
        /// <summary>
        /// le paso a factura los productos que se compro y los cargo a la lista productos
        /// </summary>
        /// <param name="productos"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public static void CrearFactura(List<Producto> productos, string nombre, string apellido)
        {
            Factura newFactura = new Factura();

            Factura.cliente.Add($"{nombre} {apellido}");

            foreach (Producto p in productos)
            {
                newFactura.NombreProducto = p.Corte;
                newFactura.Cantidad = p.Stock;
                newFactura.PrecioUnitario = p.Precio;
                newFactura.Total = (decimal)(p.Stock * p.Precio);

                ListaProductos.Add(new Factura(newFactura.NombreProducto,newFactura.Cantidad,newFactura.PrecioUnitario,newFactura.Total));
            }
        }
        #endregion

        #region MONTO FINAL
        private static decimal CargarMontoFinal()
        {
            decimal result = 0;

            foreach ( Factura f in ListaProductos )
            {
                Factura.MontoFinal += f.Total;
                result = Factura.MontoFinal;
            }

            return result;
        }
        #endregion

        #region LIMPIAR FACTURA
        public static void LimpiarFactura()
        {
            ListaProductos.Clear();
        }
        #endregion
    }
}
