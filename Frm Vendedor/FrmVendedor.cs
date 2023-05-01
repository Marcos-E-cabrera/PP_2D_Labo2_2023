using Biblioteca;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class FrmVendedor : Form
    {
        List<Producto> listaProductos = new List<Producto>();

        public FrmVendedor()
        {
            InitializeComponent();

            // hardcodeo de productos
            listaProductos.Add(new Producto("Asado", eCortes.Asado, 10, "Corte vacuno"));
            listaProductos.Add(new Producto("Vacio", eCortes.Vacio, 12, "Corte vacuno"));
            listaProductos.Add(new Producto("Bife de Chorizo", eCortes.BifeDeChorizo, 15, "Corte vacuno"));
            listaProductos.Add(new Producto("Entraña", eCortes.Entraña, 13, "Corte vacuno"));
            listaProductos.Add(new Producto("Matambre", eCortes.Matambre, 16, "Corte vacuno"));
            listaProductos.Add(new Producto("Bondiola", eCortes.Bondiola, 8, "Cerdo"));
            listaProductos.Add(new Producto("Chuletas", eCortes.Chuletas, 9, "Cerdo"));
            listaProductos.Add(new Producto("Panceta", eCortes.Panceta, 7, "Cerdo"));
            listaProductos.Add(new Producto("Costillas", eCortes.Costillas, 8, "Cerdo"));
            listaProductos.Add(new Producto("Lomo", eCortes.Lomo, 20, "Cerdo"));
            listaProductos.Add(new Producto("Pechuga", eCortes.Pechuga, 6, "Pollo"));
            listaProductos.Add(new Producto("Muslos", eCortes.Muslos, 4, "Pollo"));
            listaProductos.Add(new Producto("Alas", eCortes.Alas, 3, "Pollo"));
            listaProductos.Add(new Producto("Pollo Entero", eCortes.PolloEntero, 5, "Pollo"));
            listaProductos.Add(new Producto("Pavo", eCortes.Pavo, 18, "Pavo"));
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
           Mostrar();
        }

        /// <summary>
        /// Muestra los productos de la listaProductos en el DataGridView
        /// </summary>
        private void Mostrar()
        {
            dataGridViewProductos.DataSource = listaProductos;
            dataGridViewProductos.AutoGenerateColumns = true;

            // Cambiar los nombres de las columnas generadas
            dataGridViewProductos.Columns[0].HeaderText = "Producto";
            dataGridViewProductos.Columns[1].HeaderText = "Precio x Kilo";
            dataGridViewProductos.Columns[2].HeaderText = "Stock";
            dataGridViewProductos.Columns[3].HeaderText = "Detalle";

            // Establecer el ancho de las columnas
            dataGridViewProductos.Columns[0].Width = 165;
            dataGridViewProductos.Columns[1].Width = 165;
            dataGridViewProductos.Columns[2].Width = 165;
            dataGridViewProductos.Columns[3].Width = 165;
        }
    }
}