using Biblioteca_Carniceria;
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
        private Cliente clienteMain;
        private List<Producto> listaHeladera;
        private List<Producto> listaCarrito;
        
        private decimal Saldo { get; set; }
        private bool carrito;
        private bool cliente;
        private bool productoEnCarrito;
        private bool ValidarCarrito;
        #endregion

        #region FRM HELADERA VENDEDOR
        public FrmHeladeraVendedor()
        {
            InitializeComponent();
            clienteMain = new Cliente();

            listaHeladera = new List<Producto>();
            listaCarrito = new List<Producto>();

            Heladera heladera = new Heladera();
            
            listaHeladera = heladera.ListaProductos;
            carrito = false;
            cliente = false;
            productoEnCarrito = false;
            ValidarCarrito = false;
            clienteMain.Saldo = 0;
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
        /// <summary>
        /// Repone el stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnReponer_Click(object sender, EventArgs e)
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
        /// <summary>
        /// Selecciona un cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (cliente == false) // Si no se cargo un cliente
            {
                FrmVenta frmVenta = new FrmVenta();
                if (frmVenta.ShowDialog() == DialogResult.OK && frmVenta.cliente.Saldo > 0)
                {
                    clienteMain.Nombre = frmVenta.cliente.Nombre;
                    clienteMain.Apellido = frmVenta.cliente.Apellido;
                    clienteMain.Saldo = frmVenta.cliente.Saldo;
                    carrito = true;
                    cliente = true;
                    MensajeDeOK("Carga de Cliente Exitosa!!!", " Carga de Cliente");
                    label1.Text = $"$ {clienteMain.Saldo.ToString()}";
                }
                if (frmVenta.cliente.Saldo < 0)
                {
                    MensajeDeError("El Cliente no tiene el saldo suficiente", "Error, saldo");
                }
            }
            else
            {
                MensajeDeError($"Cliente ya Seleccionado: {clienteMain.Nombre} {clienteMain.Apellido}", "Error, seleccion");
            }
        }
        #endregion

        #region AÑADIR AL CARRITO
        /// <summary>
        /// Se produce el evento que llama a "AÑADIR que deja añadir un producto a la lista "ListaCarrito""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnAñadir_Click(object sender, EventArgs e)
        {
            if (carrito)
            {
                bool tope = false;
                int index;
                index = ObtenerPosicionFilaDGV();

                // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
                Producto productoSeleccionado = listaHeladera[index];
                productoSeleccionado = ObtenerProductoDGV(index, productoSeleccionado);

                if (productoSeleccionado.Stock > 0)
                {
                    if (clienteMain.Saldo > 0 && productoSeleccionado.Precio <= clienteMain.Saldo)
                    {

                        clienteMain.Saldo -= productoSeleccionado.Precio;   // Actualizar el saldo

                        foreach (Producto p in listaCarrito)
                        {
                            if (p.Nombre == productoSeleccionado.Nombre)
                            {
                                // Si el producto ya está en la lista de carrito, aumentar su cantidad
                                if (p.Stock < productoSeleccionado.Stock)
                                {
                                    p.Stock++;
                                    productoEnCarrito = true;
                                }
                                else
                                {
                                    MensajeDeError("Tpo de producto alcanzado", "Error, Tope producto ");
                                    clienteMain.Saldo += productoSeleccionado.Precio;
                                    tope = true;
                                }
                                break;
                            }
                        }

                        if (!productoEnCarrito && tope == false)
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
        /// <summary>
        /// lista el carrito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnLista_Click(object sender, EventArgs e)
        {
            if (ValidarCarrito == true)
            {
                FrmCarrito frmCarrito = new FrmCarrito(listaCarrito, Saldo, clienteMain.Nombre, clienteMain.Apellido);
                if (frmCarrito.ShowDialog() == DialogResult.OK)
                {

                    foreach (Producto productoCarrito in listaCarrito)
                    {
                        foreach (Producto productoHeladera in listaHeladera)
                        {
                            if (productoCarrito.Nombre == productoHeladera.Nombre)
                            {
                                productoHeladera.Stock -= productoCarrito.Stock;
                                break;
                            }
                        }
                    }
                    label1.Text = $"$ {clienteMain.Saldo.ToString()}";
                    listaCarrito.Clear();
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
        /// <summary>
        /// Ordena la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnOrdenar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            switch (cbOrdenar.SelectedIndex)
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
        /// Si el producto es 0 lo mostrara asi "Sin stock"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() == "0")
            {
                e.Value = "Sin Stock";
                e.FormattingApplied = true;
            }
        }

        /// <summary>
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


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
    }
}