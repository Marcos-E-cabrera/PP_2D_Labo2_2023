using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Carrito
    {
        bool _carritoVacio = false;
        bool _compraEfectuada = false;
        bool _validarFactura = false ;
        decimal _monto;

        public List<Factura> ListaFactura;

        public decimal Monto { get => _monto; set => _monto = value; }

        public Carrito() 
        {
            ListaFactura = new List<Factura>();
        }

        #region Aviso de Recargo
        public bool AvisoDeRecargo()
        {
            bool retorno = false;
            char aux;
            string recargo;

            Console.WriteLine("Con debito Tendras un 5% de recargo, aceptar (S/N):");
            recargo = Console.ReadLine();

            if (char.TryParse(recargo, out aux) && aux == 'S')
            {
                retorno = true;
            }
          
            return retorno;
        }
        #endregion

        #region Compra con Efectivo
        public int Comprar(List<Producto> Carrito, decimal saldo, Cliente cliente, bool esEfevtivo)
        {
            int retorno = 1; // carrito esta vacio
            Factura factura = new Factura();
            Vendedor vendedor = new Vendedor();

            if (Carrito.Count != 0)
            {
                // si no se compro y el carrito esta lleno se peudo comprar
                if (_compraEfectuada == false && _carritoVacio == false)
                {
                    // si es ok, pagara con efectivo y no lo paga con devito                  
                    if (esEfevtivo == true)
                    {
                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito);
                        Monto = CargarMontoFinal();
                        
                        // el total apagar tiene que ser igual o menor al saldo del cliente
                        if (Monto <= cliente.Saldo) 
                        {
                            cliente.Saldo = cliente.Saldo - Monto;
                            Factura.nFactura++;

                            // Guardo la factura del cliente
                            Vendedor.CargarHistorial(ListaFactura, cliente.Nombre, cliente.Apellido);

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
                        if (AvisoDeRecargo())
                        {
                            // sepagara con devito
                            esEfevtivo = false;

                            // cargo los productos comprados a la factura
                            CrearFactura(Carrito);
                            Monto = RecargoDebito(CargarMontoFinal());
                            
                            // le paso la cantidad a pagar al carrito
                            if (Monto <= cliente.Saldo)
                            {
                                cliente.Saldo = cliente.Saldo - Monto;
                                Factura.nFactura++;
                                // Guardo la factura del cliente
                                Vendedor.CargarHistorial(ListaFactura,cliente.Nombre, cliente.Apellido);
                                
                                _validarFactura = true;
                                _compraEfectuada = true;
                                retorno = 0;
                            }
                            else
                            {
                                retorno = 4; // saldo no suficiente
                            }
                        }
                        else
                        {
                            retorno = 3; // debito cancelado
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
        public decimal RecargoDebito(decimal total)
        {
            decimal cincoPorCiento = total * 0.05m;
            return total += cincoPorCiento;
        }
        #endregion

        #region Creacion de la factura
        public void CrearFactura(List<Producto> productos)
        {
            Factura newFactura = new Factura();

            foreach (Producto p in productos)
            {
                newFactura.Nombre = p.Nombre;
                newFactura.Cantidad = p.Stock;
                newFactura.PrecioUnitario = p.Precio;
                newFactura.Total = p.Stock * p.Precio; 

                ListaFactura.Add(new Factura(newFactura.Nombre,newFactura.Cantidad,newFactura.PrecioUnitario,newFactura.Total));
            }
        }
        #endregion

        private decimal CargarMontoFinal()
        {
            decimal result = 0;

            foreach ( Factura f in ListaFactura )
            {
                Factura.MontoFinal += f.Total;
                result = Factura.MontoFinal;
            }

            return result;
        }

        public void LimpiarFactura()
        {
            ListaFactura.Clear();
        }
    }
}
