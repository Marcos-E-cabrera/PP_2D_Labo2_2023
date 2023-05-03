using Biblioteca_Carniceria;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class FrmStock : Form
    {
        private Producto modificarProducto;
        public Producto ModificarProducto { get { return modificarProducto; } }


        public FrmStock()
        {
            InitializeComponent();
        }

        public FrmStock(Producto producto)
        {
            InitializeComponent();

            txtStockProducto.Text = producto.Stock.ToString();
            modificarProducto = producto;
        }


        private void FrmStock_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int nuevoStock;
            if (int.TryParse(txtStockProducto.Text, out nuevoStock))
            {
                if (nuevoStock >= 0)
                {
                    // Actualizar el stock del producto
                    modificarProducto.Stock = nuevoStock;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("El stock no puede ser menor a 0", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El stock debe ser un número entero", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
