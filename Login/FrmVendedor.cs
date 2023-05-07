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
            FrmHeladeraVendedor frmHeladeraVendedor = new FrmHeladeraVendedor();
            addForm(frmHeladeraVendedor);
        }
        #endregion

        #region METODOS
        public void addForm(Form form)
        {
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            form.Show();
        }
        #endregion

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }

}