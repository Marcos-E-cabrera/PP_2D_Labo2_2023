using Biblioteca;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class FrmVendedor : Form
    {
        private List<Producto> listaHeladera;

        public List<Producto> ListaHeladera
        {
            get { return listaHeladera = new List<Producto>(); }
        }

        public FrmVendedor()
        {
            InitializeComponent();
            Heladera heladera = new Heladera();
            listaHeladera = heladera.ListaProductos;
        }

        /// <summary>
        /// Manejador de evento para el clic en el botón "Salir".
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Manejador de evento para el clic en el botón "Closing".
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void FrmVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            MostrarDataGridView();
        }

        /// <summary>
        /// Muestra los productos de la listaProductos en el DataGridView
        /// </summary>
        private void MostrarDataGridView()
        { 
            dGVProductos.DataSource = null; // para refrescar
            dGVProductos.DataSource = listaHeladera;
            dGVProductos.Columns[1].HeaderText = "Precio x Kilo";
        }

        private void btnReponer_Click(object sender, EventArgs e)
        {
            int posicion;

            Producto modificar = new Producto();
            posicion = dGVProductos.CurrentRow.Index;

            modificar.Stock = Convert.ToInt32(dGVProductos[2, posicion].Value);

            FrmStock frmStock = new FrmStock(modificar);

            // Si se hizo clic en "Aceptar" en el formulario FrmStock
            if (frmStock.ShowDialog() == DialogResult.OK)
            {
                // Se obtiene el objeto 'modificar' actualizado desde el formulario FrmStock
                modificar = frmStock.ModificarProducto;

                // Se actualizara el valor en el DataGridView
                dGVProductos[2, posicion].Value = modificar.Stock;
            }

        }

    }

}