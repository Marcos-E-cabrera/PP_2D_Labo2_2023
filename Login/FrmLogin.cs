using Biblioteca_Carniceria;
using Frm_Vendedor;
using System.Diagnostics;

namespace Login
{
    public partial class FrmLogin : Form
    {
        #region FRM LOGIN CONSTRUTOR
        public FrmLogin()
        {
            InitializeComponent();  
        }
        #endregion

        #region INGRESAR
        /// <summary>
        /// Evento de Click para ingresar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        #endregion

        #region VENDEDOR
        /// <summary>
        /// Evento qe hardcodea el vendedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor("acottis2@toplist.cz","jwAqIw0Alt5","Abagail","Cottis");
            txtUsuario.Text = vendedor.Email;
            txtPassword.Text = vendedor.Password;
        }
        #endregion

        #region COMPRADOR
        /// <summary>
        /// Evento qe hardcodea el comprador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprador_Click(object sender, EventArgs e)
        {
            Cliente comprador = new Cliente("djacquest0@unesco.org", "WqXtIk","Dina", "Jacquest",0);

            txtUsuario.Text = comprador.Email;
            txtPassword.Text = comprador.Password;
        }
        #endregion

        #region OLCUTAR CONTRASEÑA
        /// <summary>
        /// Evento para olcultar la contraseña 
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
        #endregion

        #region CLOSING
        /// <summary>
        /// Evento para el closing de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Estas seguro de salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}