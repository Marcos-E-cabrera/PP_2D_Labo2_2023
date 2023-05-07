using Biblioteca_Carniceria;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class FrmStock : Form
    {
        #region CAMPOS
        private Producto modificarProducto;
        #endregion

        #region PROPIEDADES
        public Producto ModificarProducto { get { return  modificarProducto; } }
        #endregion

        #region FRM STOCK CONSTRUCTOR
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
        #endregion

        #region LOAD
        private void FrmStock_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            ControlBox = false;
        }
        #endregion

        #region ACEPTAR
        /// <summary>
        /// Evento de Aceptar que rimero Valida antes el Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int nuevoStock;
            if (int.TryParse(txtStockProducto.Text, out nuevoStock))
            {
                if (nuevoStock >= 0)
                {
                    // Actualizar el stock del producto
                    ModificarProducto.Stock = nuevoStock;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MensajeDeError("El stock no puede ser menor a 0", "Error de validación");
                }
            }
            else
            {
                MensajeDeError("El stock debe ser un número entero", "Error de validación");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int nuevoStock;
            if (int.TryParse(txtStockProducto.Text, out nuevoStock))
            {
                if (nuevoStock >= 0)
                {
                    // Actualizar el stock del producto
                    ModificarProducto.Stock = nuevoStock;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MensajeDeError("El stock no puede ser menor a 0", "Error de validación");
                }
            }
            else
            {
                MensajeDeError("El stock debe ser un número entero", "Error de validación");
            }
        }
        #endregion

        #region CANCELAR
        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }
        #endregion

        #region METODOS

        /// <summary>
        /// Muestra un mensaje de eror 
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="title"></param>
        public static void MensajeDeError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

       
    }
}
