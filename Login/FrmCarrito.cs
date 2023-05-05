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
    public partial class FrmCarrito : Form
    {
        #region CAMPOS
        private List<Producto> listaCarrito = new List<Producto>();
        private bool carrito = false;
        #endregion

        #region FRM CARRITO CONSTRUCTOR
        public FrmCarrito()
        {
            InitializeComponent();
        }

        public FrmCarrito(List<Producto> listaProductos)
        {
            InitializeComponent();
            listaCarrito = listaProductos;
        }
        #endregion

        #region LOAD
        private void FrmCarrito_Load(object sender, EventArgs e)
        {
           MostrarCarrito();
        }
        #endregion

        private void btnComprar_Click(object sender, EventArgs e)
        {

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            List<Factura> listaFactura = new List<Factura>();
            foreach (Producto producto in listaCarrito)
            {
                Factura factura = new Factura();
                factura.Descripcion = producto.Nombre;
                factura.Cantidad = producto.Stock;
                factura.PrecioUnitario = producto.Precio;
                factura.Total = factura.Cantidad * factura.PrecioUnitario;
                listaFactura.Add(factura);
            }

            FrmFactura frmFactura = new FrmFactura(listaFactura);
            frmFactura.ShowDialog();

        }

        #region METODOS
        private void MostrarCarrito()
        {
            dgvCarrito.Refresh();
            dgvCarrito.DataSource = listaCarrito;
            dgvCarrito.Columns[1].HeaderText = "Precio x Kilo";
            dgvCarrito.Columns[2].HeaderText = "Cantidad";
        }
        #endregion

        
    }
}
