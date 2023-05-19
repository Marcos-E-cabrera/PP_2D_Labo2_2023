using Biblioteca_Carniceria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class HeladeraCliente : Form
    {
        // Objeto
        private Biblioteca_Carniceria.Cliente clienteMain = new Biblioteca_Carniceria.Cliente();

        // Lista
        private List<Producto> listaHeladera = new List<Producto>();
        private List<Producto> listaCarrito = new List<Producto>();
        
        // Validaciones
        private bool productoEnCarrito;
        private bool ValidarCarrito;
        private bool saldoIngresado;


        public HeladeraCliente()
        {
            InitializeComponent();
            clienteMain.Nombre = "Marcos";
            clienteMain.Apellido = "Cabrera";
            // Lista heladera sera cargada por la lista correspondiente para cliente
            //listaHeladera = Producto.HeladeraCliente();

            productoEnCarrito = false;
            ValidarCarrito = false;
            saldoIngresado = false;
        }

        #region LOAD
        private void FrmHeladeraCliente_Load(object sender, EventArgs e)
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

        #region AÑADIR SALDO
        private void ibtnSaldo_Click_1(object sender, EventArgs e)
        {
            decimal aux;
            if (decimal.TryParse(txtSaldo.Text, out aux) && aux > 0)
            {
                clienteMain.Saldo = aux;
                saldoIngresado = true;
                MensajeDeOK($"Saldo ingresado correctamente: ${clienteMain.Saldo}", "Saldo Ingresado");
            }
            else
            {
                MensajeDeError("El Monto debe ser un número entero", "Error de validación");
            }
        }
        #endregion

        private void ibtnOrdenar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            //DGV_ActualizarDatos(producto.OrdenarProductos(cbOrdenar.SelectedIndex, listaHeladera));
        }

        #region AÑADIR AL CARRITO
        /// <summary>
        /// Se produce el evento que llama a "ANAÑADIR que deja añadir un producto a la lista "ListaCarrito""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnAñadir_Click_1(object sender, EventArgs e)
        {
            if (saldoIngresado)
            {
                Producto producto = new Producto();
                Biblioteca_Carniceria.Carrito carrito = new Biblioteca_Carniceria.Carrito();

                // Catidad maxima que se puede poer en el carrito
                bool stockMax = false; // stockMax del stock

                int index;
                // obtengo la fila del producto
                index = DGV_GetFila();

                // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
                producto = DGV_GetProducto(index, producto);

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
                MensajeDeError("Ingresar primero el Monto", "Error, Ingresar Monto");
            }
        }
        #endregion

        #region LISTA DEL CARRITO
        private void ibtnLista_Click_1(object sender, EventArgs e)
        {
            if (ValidarCarrito == true)
            {
                Carrito frmCarrito = new Carrito(listaCarrito, clienteMain);
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
                    txtSaldo.Text = $"{clienteMain.Saldo.ToString()}";
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

        #region METODOS
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
        {
            return dgvProductos.CurrentRow.Index;
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

    }
}
