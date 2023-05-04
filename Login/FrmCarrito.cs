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
        private List<Producto> listaCarrito;
        private bool carrito = false;
        #endregion

        #region PROPIEDADES
        public List<Producto> ListaCarrito { get; }
        #endregion

        #region FRM CARRITO CONSTRUCTOR
        public FrmCarrito()
        {
            InitializeComponent();
        }

        public FrmCarrito(List<Producto> listaProductos)
        {
            InitializeComponent();
            this.ListaCarrito = listaProductos;
        }
        #endregion

        #region LOAD
        private void FrmCarrito_Load(object sender, EventArgs e)
        {
           MostrarCarrito();
        }
        #endregion

        #region METODOS
        private void MostrarCarrito()
        {
            dgvCarrito.Refresh();
            dgvCarrito.DataSource = ListaCarrito;
            dgvCarrito.Columns[1].HeaderText = "Precio x Kilo";
            dgvCarrito.Columns[2].HeaderText = "Cantidad";
        }
        #endregion
    }
}
