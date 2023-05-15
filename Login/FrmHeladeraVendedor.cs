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
        private Cliente clienteMain;

        private List<Producto> listaHeladera = new List<Producto>();
        private List<Producto> listaCarrito = new List<Producto>();

        private bool clienteIngresado;
        private bool productoEnCarrito;
        private bool ValidarCarrito;

        #region FRM HELADERA VENDEDOR
        public FrmHeladeraVendedor()
        {
            InitializeComponent();

            listaHeladera = Producto.ListaProductos;

            clienteIngresado = false;
            productoEnCarrito = false;
            ValidarCarrito = false;
        }

        #endregion

        #region LOAD
        private void FrmHeladeraVendedor_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;

            // cargo la lista al datagridview;
            DGV_ActualizarDatos(listaHeladera);

            cbOrdenar.Items.Add("Ordenar por Nombre");
            cbOrdenar.Items.Add("Ordenar por Precio");
            cbOrdenar.Items.Add("Ordenar por Stock");
            cbOrdenar.Items.Add("Ordenar por Detalle");
            cbOrdenar.SelectedIndex = 0;
        }
        #endregion

        #region REPONER PRODUCTO
        /// <summary>
        /// Repone el stock del producto seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnReponer_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int index;
            // Devuelvo la posicion del dataGridView
            index = DGV_GetFila();

            // Devuelvo los productos en el index pasado
            producto = DGV_GetProducto(index, producto);

            // llamo al form-stock pasandole el producto a reponer
            FrmStock frmStock = new FrmStock(producto);

            if (frmStock.ShowDialog() == DialogResult.OK)
            {
                // Cambio el stock del producto original a el stock nuevo pasado por el auxiliar.
                producto = frmStock.Producto_Aux;
    
                // Lo cargo en la posicion del index pasado por el DGV_GetFila
                listaHeladera[index] = producto;
                // Lo cargo en la lista heladera que es estatica y se compartira con la lista del cliente para  que pueda comprar el producto
                DGV_ActualizarDatos(listaHeladera);
                
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
            if (clienteIngresado == false) // Si no se cargo un cliente
            {
                // Muestro la seleccion de clientes
                FrmVenta frmVenta = new FrmVenta();

                if (frmVenta.ShowDialog() == DialogResult.OK && frmVenta.cliente.Saldo > 0)
                {
                    // le paso los datos del cliente
                    clienteMain = frmVenta.cliente;
                    clienteIngresado = true;
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
            // valida si se 
            if (clienteIngresado)
            {
                Producto producto = new Producto();
                Carrito carrito = new Carrito();

                // Catidad maxima que se puede poer en el carrito
                bool stockMax = false; // stockMax del stock

                int index; 
                // obtengo la fila del producto
                index = DGV_GetFila();

                // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
                producto = DGV_GetProducto(index, producto);

                // el stock tiene q ser mayor que 0 para poder venderle
                if (producto.Stock > 0)
                {
                    // el saldo tiene q ser mayor a 0 y mayor al precio del producto
                    if (clienteMain.Saldo > 0 && producto.Precio <= clienteMain.Saldo)
                    {

                        clienteMain.Saldo -= producto.Precio;   // Actualizar el saldo

                        foreach (Producto aux in listaCarrito)
                        {
                            if (aux == producto) // sobrecarga de operadores
                            {
                                // Si el producto ya está en la lista de carrito, aumentar su cantidad
                                if (aux.Stock < producto.Stock)
                                {
                                    aux.Stock++;
                                    productoEnCarrito = true;
                                }
                                else
                                {
                                    MensajeDeError("stock de producto alcanzado", "Error, stockMax producto ");
                                    clienteMain.Saldo += producto.Precio;
                                    stockMax = true;
                                }
                                break;
                            }
                        }

                 
                        // Si el producto no está en la lista de carrito, agregarlo como un nuevo producto
                        if (!productoEnCarrito && !stockMax)
                        {
                            producto.Stock = 1; // el stock lo paso como cantidad de producto.
                            listaCarrito.Add(producto);
                        }

                        // se sumo un producto al carrito
                        productoEnCarrito = false;
                        // se puede listar el carrito
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
                FrmCarrito frmCarrito = new FrmCarrito(listaCarrito, clienteMain);
                if (frmCarrito.ShowDialog() == DialogResult.OK)
                {
                    // recorro es la lista de lcarrito
                    foreach (Producto carrito in listaCarrito)
                    {
                        // recorrto la lista de la heladera
                        foreach (Producto producto in listaHeladera)
                        {
                            // si los dos obj son iguales se le restara al stock princiapal ( a la lista heladera)
                            if (carrito == producto)
                            {
                                producto.Stock -= carrito.Stock;
                                break;
                            }
                        }
                    }
                    label1.Text = $"$ {clienteMain.Saldo.ToString()}";
                    listaCarrito.Clear();
                    DGV_ActualizarDatos(listaHeladera);
                }
            }
            else
            {
                MensajeDeError("Primero Añadir productos al carrito", "Error, carrito");
            }
        }
        #endregion

        #region ORDENAR LISTA
        private void ibtnOrdenar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            DGV_ActualizarDatos(producto.OrdenarProductos(cbOrdenar.SelectedIndex, listaHeladera));
        }

        #endregion

        #region METODOS
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
        {
            return  dgvProductos.CurrentRow.Index;
        }

        /// <summary>
        /// Obtengo el objeto Producto del indice dado del DataGridView.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="p"></param>
        /// <returns>Devuelve un obj Producto con los datos del DataGridView </returns>
        public Producto DGV_GetProducto(int index, Producto p)
        {
            p.Nombre = (eCortes)Convert.ToInt32(dgvProductos[0, index].Value);
            p.Precio = Convert.ToInt32(dgvProductos[1, index].Value);
            p.Stock = Convert.ToInt32(dgvProductos[2, index].Value);
            p.Detalle = dgvProductos[3, index].Value.ToString();
            return p;
        }

        /// <summary>
        /// Carga al DataGridView la nueva "Lista Heladera"
        /// </summary>
        /// <param name="l"></param>
        public void DGV_ActualizarDatos(List<Producto> l)
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
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        #endregion

        private void ibtnHistorial_Click(object sender, EventArgs e)
        {
            FrmHistorial frmHistorial = new FrmHistorial();
            frmHistorial.ShowDialog();
        }
    }
}