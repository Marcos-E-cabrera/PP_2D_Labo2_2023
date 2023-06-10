using Biblioteca_Carniceria;
using FontAwesome.Sharp;
using Frm_Vendedor;
using System.Diagnostics;

namespace Login
{
    public partial class Login : Form
    {
        private bool hide;

        #region FRM LOGIN CONSTRUTOR
        public Login()
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

            switch (txtUsuario.Text)
            {
                case "acottis2@toplist.cz":
                    if (txtPassword.Text == "jwAqIw0Alt5")
                    {
                        Vendedor vendedor = new Vendedor();
                        vendedor.Nombre = "Marcos";
                        vendedor.Apellido = "Cabrera";

                        Frm_User_Vendedor userVendedor = new Frm_User_Vendedor(vendedor);
                        userVendedor.Show(this);
                    }
                    else
                    {
                        panel10.Visible = true;
                    }
                    break;
                case "djacquest0@unesco.org":
                    if (txtPassword.Text == "WqXtIk")
                    {
                        Cliente cliente = new Cliente();
                        cliente.Nombre = "Zoro";
                        cliente.Apellido = "Roronoa";
                        cliente.Saldo = 20000;

                        Frm_User_Cliente userCliente = new Frm_User_Cliente(cliente);
                        userCliente.Show(this);
                    }
                    else
                    {
                        panel10.Visible = true;
                    }
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
        private void ibtnVendedor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "acottis2@toplist.cz";
            txtPassword.Text = "jwAqIw0Alt5";
        }
        #endregion

        #region COMPRADOR
        /// <summary>
        /// Evento qe hardcodea el comprador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ibtnCliente_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "djacquest0@unesco.org";
            txtPassword.Text = "WqXtIk";
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