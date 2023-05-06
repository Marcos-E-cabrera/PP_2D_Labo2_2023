using Biblioteca_Carniceria;
using FontAwesome.Sharp;
using Frm_Vendedor;
using System.Diagnostics;

namespace Login
{
    public partial class FrmLogin : Form
    {
        private bool hide;

        #region FRM LOGIN CONSTRUTOR
        public FrmLogin()
        {
            InitializeComponent();
            hide = true;
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
            panel8.Visible = false;
            panel10.Visible = false;

            switch ( txtUsuario.Text) 
            {
                case "acottis2@toplist.cz":
                    if (txtPassword.Text == "jwAqIw0Alt5")
                    {
                        FrmVendedor frmVendedor = new FrmVendedor();
                        frmVendedor.Show(this);
                    }
                    else
                    {
                        panel10.Visible = true;
                    }
                    break;
                case "djacquest0@unesco.org":
                    if (txtPassword.Text == "WqXtIk")
                    {
                        FrmCliente frmCliente = new FrmCliente();
                        frmCliente.Show(this);
                    }
                    else
                    {
                        panel10.Visible = true;
                    }
                    break;
                    break;
                default:
                    panel8.Visible = true;
                    panel10.Visible = true;
                    break;
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
            Cliente comprador = new Cliente("djacquest0@unesco.org", "WqXtIk","Dina", "Jacquest");

            txtUsuario.Text = comprador.Email;
            txtPassword.Text = comprador.Password;
        }
        #endregion

        #region OLCUTAR CONTRASEÑA
        /// <summary>
        /// Oculta la contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnHide_MouseClick(object sender, MouseEventArgs e)
        {
            if (hide)
            {
                txtPassword.PasswordChar = '*';
                ibtnHide.IconChar = IconChar.EyeSlash;
                hide = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                ibtnHide.IconChar = IconChar.Eye;
                hide = true;
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
       
        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        #endregion

        
    }
}