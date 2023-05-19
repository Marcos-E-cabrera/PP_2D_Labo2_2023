using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class CompraCarrito  : Factura
    {
        private bool carritoVacio;
        private bool compraEfectuada;
        private bool efectivo;
        private bool validarFactura;

        private Carrito carrito_aux;
        private Factura factura;

        public List<Factura> FacturaList = new List<Factura>();
        public List<Historial> Historials = new List<Historial>();

        public CompraCarrito() 
        {
            carritoVacio = false;
            compraEfectuada = false;
            efectivo = false;
            validarFactura = false;
            carrito_aux = new Carrito();
            factura = new Factura();
        }

        public bool PagoPorEfectivo()
        {
            bool retorno = true; 
            int aux = 1;
            string pago;

            do
            {
                Console.WriteLine("[0] efectivo o [1] debito");
                pago = Console.ReadLine();

            } while (!int.TryParse(pago, out aux)) ;

            switch (aux)
            {
                case 0:
                    retorno = true;
                    break;
                case 1:
                    retorno = false;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            return retorno;
        }

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

        public void Comprar(List<Producto> Carrito, decimal saldo, Cliente cliente)
        {
            // pregunto si el carrito esta vacio
            if (Carrito.Count == 0)
            {
                Console.WriteLine("El Carrito esta vacio");
                carritoVacio = true;
            }
            else
            {
                // si no se compro y el carrito esta lleno se peudo comprar
                if (compraEfectuada == false && carritoVacio == false)
                {
                    // si es ok, pagara con efectivo y no lo paga con devito
                    if (PagoPorEfectivo())
                    {
                        efectivo = true; // se pagara con efectivo

                        // cargo los productos comprados a la factura
                        CrearFactura(Carrito);

                        // le paso la cantidad a pagar al carrito
                        carrito_aux.Total = factura.Total;

                        // el total apagar tiene que ser igual o menor al saldo del cliente
                        if (carrito_aux.Total <= carrito_aux.Saldo)
                        {
                            Console.WriteLine("Compra exitosa!!!", "Compra");

                            // Guardo la factura del cliente
                            AgregarAlHistorial(cliente.Nombre, cliente.Apellido);

                            // estome da el gasto total
                            carrito_aux.Saldo += carrito_aux.Total;

                            validarFactura = true;
                            compraEfectuada = true;
                        }
                        else
                        {
                            Console.WriteLine("Error, Saldo no suficiente");
                        }
                    }
                    else
                    {
                        if (AvisoDeRecargo())
                        {
                            // sepagara con devito
                            efectivo = false;

                            // cargo los productos comprados a la factura
                            CrearFactura(Carrito);

                            // le paso la cantidad a pagar al carrito
                            carrito_aux.Total = RecargoDevito(factura.Total);

                            if (carrito_aux.Aux <= carrito_aux.Saldo)
                            {
                                Console.WriteLine("Compra exitosa!!!");
                                // Guardo la factura del cliente
                                AgregarAlHistorial(cliente.Nombre, cliente.Apellido);

                                // estome da el gasto total
                                carrito_aux.Saldo += carrito_aux.Total;
                                validarFactura = true;
                                compraEfectuada = true;
                            }
                            else
                            {
                                Console.WriteLine("Error, Saldo no suficiente");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error, Deviito cancelado");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error, de compra");
                }
            }
        }

        /// <summary>
        /// Agregra 5% de recargo al total
        /// </summary>
        /// <param name="total"></param>
        /// <returns></returns>
        public decimal RecargoDevito(decimal total)
        {
            decimal cincoPorCiento = total * 0.05m;

            return total += cincoPorCiento;
        }

        public void CrearFactura(List<Producto> aux)
        {
            Factura factura = new Factura();

            foreach (Producto prod in aux)
            {
                factura.Nombre = prod.Nombre.ToString();
                factura.Cantidad = prod.Stock;
                factura.PrecioUnitario = prod.Precio;
                factura.Total = prod.Stock * prod.Precio;

                Factura.ListaFactura.Add(new Factura(factura.Nombre, factura.Cantidad, factura.Total, factura.PrecioUnitario));
            }
        }

        public void AgregarAlHistorial(string nombre, string apellido)
        {
            Historial historial = new Historial();
            foreach (Factura factura in Factura.ListaFactura)
            {
                historial.NombreProducto = factura.Nombre.ToString();
                historial.Cantidad = factura.Cantidad;
                historial.Total = factura.Total;

                Historial.listaHistorial.Add(new Historial(historial.NombreProducto, historial.Cantidad, historial.Total, nombre, apellido));
            }
        }

    }
}
