using Biblioteca;
using Frm_Vendedor;
using System.Diagnostics;

namespace Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Manejador de evento para el clic en el botón "Ingresar".
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "acottis2@toplist.cz" && txtPassword.Text == "jwAqIw0Alt5")
            {
                FrmVendedor frmVendedor = new FrmVendedor();
                frmVendedor.Show(this);
            }
            else if (txtUsuario.Text == "djacquest0@unesco.org" && txtPassword.Text == "WqXtIk")
            {
                
            }
        }

        /// <summary>
        /// Manejador de evento para el clic en el botón "Vendedor".
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("acottis2@toplist.cz","jwAqIw0Alt5","Abagail","Cottis");
            txtUsuario.Text = vendedor.Email;
            txtPassword.Text = vendedor.Password;
        }

        /// <summary>
        /// Manejador de evento para el clic en el botón "Comprador".
        /// </summary>
        /// <param name="sender">El objeto que disparó el evento.</param>
        /// <param name="e">Los argumentos del evento.</param>
        private void btnComprador_Click(object sender, EventArgs e)
        {
            Comprador comprador = new Comprador("djacquest0@unesco.org", "WqXtIk", 12060, "Dina", "Jacquest");

            txtUsuario.Text = comprador.Email;
            txtPassword.Text = comprador.Password;
        }


        /// <summary>
        /// Manejador de evento para el clic en el botón "Ocultar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkbOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbOcultar.Checked)
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}