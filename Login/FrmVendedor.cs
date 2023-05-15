using Biblioteca_Carniceria;
using Login;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Frm_Vendedor
{
    public partial class FrmVendedor : Form
    {
        #region FRM VENDEDOR CONSTRUCTOR
        public FrmVendedor()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD
        private void FrmVendedor_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            Vendedor vendedor = new Vendedor("Marcos", "Cabrera");
            MessageBox.Show(vendedor.SaludarUsuario());
            FrmHeladeraVendedor frmHeladeraVendedor = new FrmHeladeraVendedor();
            addForm(frmHeladeraVendedor);
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Agrega un formulario al panel principal del formulario actual, ajustando su tamaño
        /// para que llene todo el espacio disponible.
        /// </summary>
        /// <param name="form">El formulario que se quiere agregar al panel.</param>
        public void addForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Heladera.Controls.Add(form);             
            form.Show();
        }
        #endregion

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}