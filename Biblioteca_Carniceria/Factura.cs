﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Carniceria
{
    public class Factura
    {
        private string nombre;
        private int cantidad;
        private int precioUnitario;
        private decimal total;

        public static List<Factura> ListaFactura = new List<Factura>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Total { get => total; set => total = value; }
        public int PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }

        public Factura()
        {
            Nombre = string.Empty;
            Cantidad = 0;
            PrecioUnitario = 0;
            Total = 0;
        }

        public Factura(string nombre, int cantidad, decimal precio, int preU)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            Total = precio;
            PrecioUnitario = preU;
        }

        // Mostrar factura

    }
}
