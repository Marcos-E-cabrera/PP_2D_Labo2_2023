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
        // Onjeto
        private Producto producto = new Producto();
        
        // Lista
        private List<Producto> listaHeladera = new List<Producto>();
        private List<Producto> listaCarrito = new List<Producto>();
        
        // Validaciones
        private bool productoEnCarrito;
        private bool ValidarCarrito;
        private bool saldoIngresado;


        public FrmHeladeraCliente()
        {
            InitializeComponent();
             
            // Lista heladera sera cargada por la lista correspondiente para cliente
            listaHeladera = producto.HeladeraCliente();

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

        //#region AÑADIR SALDO
        //private void ibtnSaldo_Click(object sender, EventArgs e)
        //{
        //    int aux;
        //    if (int.TryParse(txtSaldo.Text, out aux) && aux > 0)
        //    {
        //        clienteMain.Saldo = aux;
        //        saldoIngresado = true;
        //        MensajeDeOK($"Saldo ingresado correctamente: ${clienteMain.Saldo}","Saldo Ingresado");
        //    }
        //    else
        //    {
        //        MensajeDeError("El Monto debe ser un número entero", "Error de validación");
        //    }
        //}
        //#endregion

        private void ibtnOrdenar_Click(object sender, EventArgs e)
        {
            DGV_ActualizarDatos(producto.OrdenarProductos(cbOrdenar.SelectedIndex, listaHeladera));
        }

        //#region AÑADIR AL CARRITO
        //    /// <summary>
        ///// Se produce el evento que llama a "ANAÑADIR que deja añadir un producto a la lista "ListaCarrito""
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void ibtnAñadir_Click(object sender, EventArgs e)
        //{
        //    //if (saldoIngresado)
        //    //{
        //    //    bool tope = false;
        //    //    int index;
        //    //    index = ObtenerPosicionFilaDGV();

        //    //    // Obtener el objeto Producto correspondiente a la fila seleccionada de la lista
        //    //    Producto productoSeleccionado = listaHeladera[index];
        //    //    productoSeleccionado = ObtenerProductoDGV(index, productoSeleccionado);

        //    //    if (clienteMain.Saldo > 0 && productoSeleccionado.Precio <= clienteMain.Saldo )
        //    //    {
        //    //        clienteMain.Saldo -= productoSeleccionado.Precio;   // Actualizar el saldo

        //    //        foreach (Producto p in listaCarrito)
        //    //        {
        //    //            if (p.Nombre == productoSeleccionado.Nombre)
        //    //            {
        //    //                // Si el producto ya está en la lista de carrito, aumentar su cantidad
        //    //                if (p.Stock < productoSeleccionado.Stock)
        //    //                {
        //    //                    p.Stock++;
        //    //                    productoEnCarrito = true;
        //    //                }
        //    //                else
        //    //                {
        //    //                    MensajeDeError("Tpo de producto alcanzado", "Error, Tope producto ");
        //    //                    clienteMain.Saldo += productoSeleccionado.Precio;
        //    //                    tope = true;
        //    //                }
        //    //                break;
        //    //            }
        //    //        }

        //    //        if (!productoEnCarrito && tope == false)
        //    //        {
        //    //            // Si el producto no está en la lista de carrito, agregarlo como un nuevo producto
        //    //            Producto productoCarrito = new Producto();
        //    //            productoCarrito.Nombre = productoSeleccionado.Nombre;
        //    //            productoCarrito.Precio = productoSeleccionado.Precio;
        //    //            productoCarrito.Stock = 1;
        //    //            productoCarrito.Detalle = productoSeleccionado.Detalle;
        //    //            listaCarrito.Add(productoCarrito);
        //    //        }


        //    //        productoEnCarrito = false;
        //    //        ValidarCarrito = true;
        //    //    }
        //    //    else
        //    //    {
        //    //        MensajeDeError("El saldo no es suficiente para comprar el producto", "Error, Saldo no suficiente ");
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    MensajeDeError("Ingresar primero el Monto", "Error, Ingresar Monto");
        //    //}
        //}
        //#endregion

        //#region LISTA DEL CARRITO
        //private void ibtnLista_Click(object sender, EventArgs e)
        //{
        //    if (ValidarCarrito == true)
        //    {
        //        FrmCarrito frmCarrito = new FrmCarrito(listaCarrito, clienteMain.Saldo, clienteMain.Nombre, clienteMain.Apellido);
        //        if (frmCarrito.ShowDialog() == DialogResult.OK)
        //        {

        //            foreach (Producto productoCarrito in listaCarrito)
        //            {
        //                foreach (Producto productoHeladera in listaHeladera)
        //                {
        //                    if (productoCarrito.Nombre == productoHeladera.Nombre)
        //                    {
        //                        productoHeladera.Stock -= productoCarrito.Stock;
        //                        break;
        //                    }
        //                }
        //            }
        //            txtSaldo.Text = $"{clienteMain.Saldo.ToString()}";
        //            listaCarrito.Clear();
        //            CargarListaHeladera(listaHeladera);
        //        }
        //    }
        //    else
        //    {
        //        MensajeDeError("Primero Añadir productos al carrito", "Error, carrito");
        //    }
        //}
        //#endregion

        #region METODOS
        /// <summary>
        /// Obtengo la FILA del DataGridView que se encuentra el cursor
        /// </summary>
        /// <returns></returns>
        public int DGV_GetFila()
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
        public Producto DGV_GetProducto(int index, Producto p)
        {
            p.Nombre = (eCortes)Convert.ToInt32(dgvProductos[1, index].Value);
            p.Precio = Convert.ToInt32(dgvProductos[2, index].Value);
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
