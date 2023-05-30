using Biblioteca_Carniceria;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class Frm_Stock : Form
    {
        public Producto producto = new Producto();

        public Frm_Stock()
        {
            InitializeComponent();
        }

        public Frm_Stock(Producto p) : this()
        {
            // Le paso al producto aux el stock a reponer
            producto = p;
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
        }


        /// <summary>
        /// Evento de Aceptar que Valida antes el Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (Vendedor.Reponer(producto, txtStockProducto.Text))
            {
                case 0:
                    this.DialogResult = DialogResult.OK;
                    break;
                case 1:
                    MensajeDeError("El stock no puede ser menor a 0 y no puede bajar el stock", "Error [ 1 ]");
                    break;
                case 2:
                    MensajeDeError("El stock debe ser un número entero", "Error [ 2 ]");
                    break;
                default:
                    break;
            }
        }

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public static void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
