﻿using Biblioteca_Carniceria;
using Frm_Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FrmHeladeraVendedor : Form
    {
        #region CAMPOS CLIENTE
        private string nombre;
        private string apellido;
        private int saldo;
        private bool carrito;
        private bool cliente;
        private bool productoEnCarrito;
        private bool ValidarCarrito = false;
        private List<Producto> listaHeladera = new List<Producto>();
        private List<Producto> listaCarrito = new List<Producto>();
        #endregion

        #region PROPIEDADES CLIENTE
        public int Saldo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region FRM HELADERA VENDEDOR
        public FrmHeladeraVendedor()
        {
            InitializeComponent();
            Heladera heladera = new Heladera();
            listaHeladera = heladera.ListaProductos;
            carrito = false;
            cliente = false;
            productoEnCarrito = false;
            Saldo = 0;
        }
        #endregion

        #region LOAD
        private void FrmHeladeraVendedor_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
            MostrarProductos();
            cbOrdenar.Items.Add("Ordenar por Nombre");
            cbOrdenar.Items.Add("Ordenar por Precio");
            cbOrdenar.Items.Add("Ordenar por Stock");
            cbOrdenar.Items.Add("Ordenar por Detalle");
            cbOrdenar.SelectedIndex = 0;
        }
        #endregion

        #region REPONER PRODUCTO
        private void btnReponer_Click(object sender, EventArgs e)
        {
            int index;

            index = ObtenerPosicionFilaDGV();

            Producto stock = new Producto();
            stock = ObtenerProductoDGV(index, stock);

            FrmStock frmStock = new FrmStock(stock);
            if (frmStock.ShowDialog() == DialogResult.OK)
            {
                stock = frmStock.ModificarProducto;
                listaHeladera[index] = stock;
                CargarListaHeladera(listaHeladera);
            }
        }
        #endregion

        #region SELECCIONAR CLIENTE
        private void btnVender_Click(object sender, EventArgs e)
        {
            if ( cliente == false  ) // Si no se cargo un cliente
            {
                FrmVenta frmVenta = new FrmVenta();
                if ( frmVenta.ShowDialog() == DialogResult.OK  && frmVenta.Saldo > 0)
                {
                    Nombre = frmVenta.Nombre;
                    Apellido= frmVenta.Apellido;
                    Saldo = frmVenta.Saldo;
                    carrito = true;
                    cliente = true;
                }
                else
                {
                    MensajeDeError("El Cliente no tiene el saldo suficiente", "Error, saldo");
                }
            }
            else
            {
                MensajeDeError($"Cliente ya Seleccionado: {Nombre} {Apellido}", "Error, seleccion");
            }
        }
        #endregion

        #region AÑADIR AL CARRITO
        /// <summary>
        /// Se produce el evento que llama a "ANAÑADIR que deja añadir un producto a la lista "ListaCarrito""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (carrito)
            {
                int index;
                index = ObtenerPosicionFilaDGV();

                // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
                Producto productoSeleccionado = listaHeladera[index];
                ObtenerProductoDGV(index, productoSeleccionado);

                if ( productoSeleccionado.Stock > 0)
                {
                    if (Saldo > 0 && productoSeleccionado.Precio <= Saldo)
                    {

                        Saldo -= productoSeleccionado.Precio;   // Actualizar el saldo

                        foreach (Producto p in listaCarrito)
                        {
                            if (p.Nombre == productoSeleccionado.Nombre)
                            {
                                // Si el producto ya está en la lista de carrito, aumentar su cantidad
                                p.Stock++;
                                productoEnCarrito = true;
                                break;
                            }
                        }

                        if (!productoEnCarrito)
                        {
                            // Si el producto no está en la lista de carrito, agregarlo como un nuevo producto
                            Producto productoCarrito = new Producto();
                            productoCarrito.Nombre = productoSeleccionado.Nombre;
                            productoCarrito.Precio = productoSeleccionado.Precio;
                            productoCarrito.Stock = 1;
                            productoCarrito.Detalle = productoSeleccionado.Detalle;
                            listaCarrito.Add(productoCarrito);
                        }
                        productoEnCarrito = false;
                        ValidarCarrito = true;
                    }
                    else
                    {
                        MensajeDeError("El saldo no es suficiente para comprar el producto", "Error, Saldo no suficiente ");
                    }
                }
                else
                {
                    MensajeDeError("NO hay Stock!!", "Error, Stock no suficiente ");
                }
            }
            else
            {
                MensajeDeError("Ingresar primero el Cliente", "Error, Ingresar Cliente");
            }
        }
        #endregion

        #region LISTA DEL CARRITO
        private void btnCarrito_Click(object sender, EventArgs e)
        {
            if (ValidarCarrito == true)
            {
                FrmCarrito frmCarrito = new FrmCarrito(listaCarrito, Saldo);
                if (frmCarrito.ShowDialog() == DialogResult.OK)
                {
                    foreach ( Producto p in listaHeladera)
                    {
                        p.Stock--;
                        break;
                    }

                    CargarListaHeladera(listaHeladera);
                }
            }
            else
            {
                MensajeDeError("Primero Añadir productos al carrito", "Error, carrito");
            }
        }
        #endregion

        #region ORDENAR LISTA
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            switch(cbOrdenar.SelectedIndex) 
            {
                case 0:
                    listaHeladera = listaHeladera.OrderBy(p => p.Nombre).ToList();
                    break;
                case 1:
                    listaHeladera = listaHeladera.OrderBy(p => p.Precio).ToList();
                    break;

                case 2:
                    listaHeladera = listaHeladera.OrderBy(p => p.Stock).ToList();
                    break;
                case 3:
                    listaHeladera = listaHeladera.OrderBy(p => p.Detalle).ToList();
                    break;
            }
            CargarListaHeladera(listaHeladera);

        }
        #endregion
      
        #region METODOS
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int ObtenerPosicionFilaDGV()
        {
            int posicion;
            return posicion = dgvProductos.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public Producto ObtenerProductoDGV(int index, Producto p)
        {
            p.Nombre = dgvProductos[0, index].Value.ToString();
            p.Precio = Convert.ToInt32(dgvProductos[1, index].Value);
            p.Stock = Convert.ToInt32(dgvProductos[2, index].Value);
            p.Detalle = dgvProductos[3, index].Value.ToString();
            return p;
        }

        /// <summary>
        /// Carga al DataGridView la nueva "Lista Heladera"
        /// </summary>
        /// <param name="l"></param>
        public void CargarListaHeladera(List<Producto> l)
        {
            dgvProductos.Refresh();
            dgvProductos.DataSource = l;
            dgvProductos.Columns[1].HeaderText = "Precio x Kilo";
        }

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra los productos de la listaProductos en el DataGridView
        /// </summary>
        private void MostrarProductos()
        {
            dgvProductos.Refresh();
            dgvProductos.DataSource = listaHeladera;
            dgvProductos.Columns[1].HeaderText = "Precio x Kilo";
        }
        #endregion

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() == "0")
            {
                e.Value = "Sin Stock";
                e.FormattingApplied = true;
            }
        }
    }
}