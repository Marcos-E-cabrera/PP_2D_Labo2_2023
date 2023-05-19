using Biblioteca_Carniceria;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class Stock : Form
    {

        private Producto producto_Aux;
        
        public Producto Producto_Aux { get => producto_Aux; }

        public Stock()
        {
            InitializeComponent();
        }

        public Stock(Producto producto_Reponer) : this() 
        {
            // Le paso al producto aux el stock a reponer
            producto_Aux = producto_Reponer;
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            int error = 0;

            //error = Producto_Aux.ReponerStock(Producto_Aux, txtStockProducto.Text);

            switch(error)
            {
                case 1:
                    MensajeDeError("El stock debe ser un número entero", "Error de validación");
                    break;
                case 2:
                    MensajeDeError("El stock no puede ser menor a 0 y no puede bajar el stock", "Error de validación");
                    break;
                default:
                    this.DialogResult = DialogResult.OK;
                    // devuelvo el valor del stock parseado a int
                    Producto_Aux.Stock = int.Parse(txtStockProducto.Text);
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
