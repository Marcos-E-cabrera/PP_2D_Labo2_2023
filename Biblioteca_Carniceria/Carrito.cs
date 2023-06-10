using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public  class Carrito
    {
        static bool _carritoVacio = false;
        static bool _compraEfectuada = false;
        static bool _validarFactura = false ;
        static decimal _monto;
        public static int Pago;

        public static List<Factura> ListaProductos = new List<Factura>();

        static public decimal Monto { get => _monto; set => _monto = value; }

        public Carrito() 
        {
        }

        #region COMPRAR
        public static int Comprar(List<Producto> Carrito, out decimal saldo, string nombre, string apellido, decimal auxSaldo ,int formaPago)
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
                        if (Monto <= cliente.Saldo) 
                        {
                            cliente.Saldo = cliente.Saldo - Monto;
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
                            retorno = 4; // saldo no suficiente
                        }
                    }
                    else
                    {
                        Pago = 1;

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito,cliente.Nombre,cliente.Apellido);
                        Monto = RecargoDebito(CargarMontoFinal());
                            
                        // le paso la cantidad a pagar al carrito
                        if (Monto <= cliente.Saldo)
                        {
                            cliente.Saldo = cliente.Saldo - Monto;
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
                foreach (Producto aux in Heladera.ListHeladera)
                {
                    if ( p.Nombre ==aux.Nombre )
                    {
                        aux.Stock--;
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
        public static void CrearFactura(List<Producto> productos, string nombre, string apellido)
        {
            Factura newFactura = new Factura();

            Factura.cliente.Add($"{nombre} {apellido}");

            foreach (Producto p in productos)
            {
                newFactura.NombreProducto = p.Nombre;
                newFactura.Cantidad = p.Stock;
                newFactura.PrecioUnitario = p.Precio;
                newFactura.Total = p.Stock * p.Precio;

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
