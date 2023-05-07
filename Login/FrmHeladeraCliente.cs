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
    public partial class FrmHeladeraCliente : Form
    {
        #region CAMPOS CLIENTE
        private int saldo;
        private bool productoEnCarrito;
        private bool ValidarCarrito;
        private bool saldoIngresado;

        private List<Producto> listaHeladeraPrincipal = new List<Producto>();
        private List<Producto> listaHeladera = new List<Producto>();

        private List<Producto> listaCarrito = new List<Producto>();
        #endregion

        #region PROPIEDADES CLIENTE
        public int Saldo { get; set; }
        #endregion

        #region FRM HELADERA CLIENTE CONSTRUCTOR
        public FrmHeladeraCliente()
        {
            InitializeComponent();
            Heladera heladera = new Heladera();
            listaHeladeraPrincipal = heladera.ListaProductos;

            foreach (Producto producto in listaHeladeraPrincipal)
            {
                if (producto.Stock != 0)
                {
                    listaHeladera.Add(producto);
                }
            }

            CargarListaHeladera(listaHeladera);

            productoEnCarrito = false;
            ValidarCarrito = false;
            saldoIngresado = false;
        }
        #endregion

        #region LOAD
        private void FrmHeladeraCliente_Load(object sender, EventArgs e)
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

        #region AÑADIR SALDO
        private void ibtnSaldo_Click(object sender, EventArgs e)
        {
            int aux;
            if (int.TryParse(txtSaldo.Text, out aux))
            {
                Saldo = aux;
                saldoIngresado = true;
                MensajeDeOK($"Saldo ingresado correctamente: ${Saldo}","Saldo Ingresado");
            }
            else
            {
                MensajeDeError("El Monto debe ser un número entero", "Error de validación");
            }
        }
        #endregion

        #region ORDENAR LISTA
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

        #region AÑADIR AL CARRITO
            /// <summary>
        /// Se produce el evento que llama a "ANAÑADIR que deja añadir un producto a la lista "ListaCarrito""
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnAñadir_Click(object sender, EventArgs e)
        {
            if (saldoIngresado)
            {
                bool tope = false;
                int index;
                index = ObtenerPosicionFilaDGV();

                // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
                Producto productoSeleccionado = listaHeladera[index];
                productoSeleccionado = ObtenerProductoDGV(index, productoSeleccionado);

                if (Saldo > 0 && productoSeleccionado.Precio <= Saldo )
                {
                    Saldo -= productoSeleccionado.Precio;   // Actualizar el saldo

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
                                Saldo += productoSeleccionado.Precio;
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
                MensajeDeError("Ingresar primero el Monto", "Error, Ingresar Monto");
            }
        }
        #endregion

        #region LISTA DEL CARRITO
        private void ibtnLista_Click(object sender, EventArgs e)
        {
            if (ValidarCarrito == true)
            {
                FrmCarrito frmCarrito = new FrmCarrito(listaCarrito, Saldo);
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
                    txtSaldo.Text = $"{Saldo.ToString()}";
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
        /// Muestra un mensaje de OOK
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public void MensajeDeOK(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
