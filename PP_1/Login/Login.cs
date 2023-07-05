using Biblioteca_Carniceria;
using FontAwesome.Sharp;
using Frm_Vendedor;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login
{
    public partial class Login : Form
    {
        private bool vision;
        private CN_Heladera _heladera = new CN_Heladera();

        #region FRM LOGIN CONSTRUTOR
        public Login()
        {
            InitializeComponent();
            vision = true;
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
            switch (txtUsuario.Text)
            {
                case "acottis2@toplist.cz":
                    if (txtPassword.Text == "jwAqIw0Alt5")
                    {
                        Vendedor vendedor = new Vendedor();
                        vendedor.Nombre = "Marcos";
                        vendedor.Apellido = "Cabrera";
                        vendedor.Email = "acottis2@toplist.cz";
                        vendedor.Password = "jwAqIw0Alt5";
                        Frm_User_Vendedor userVendedor = new Frm_User_Vendedor(vendedor);
                        userVendedor.Show(this);
                    }
                    break;
                case "djacquest0@unesco.org":
                    if (txtPassword.Text == "WqXtIk")
                    {
                        Cliente cliente = new Cliente();
                        cliente.Nombre = "Zoro";
                        cliente.Apellido = "Roronoa";
                        cliente.Saldo = 20000;
                        cliente.Email = "djacquest0@unesco.org";
                        cliente.Password = "WqXtIk";

                        Frm_User_Cliente userCliente = new Frm_User_Cliente(cliente);
                        userCliente.Show(this);
                    }
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
            if (vision)
            {
                txtPassword.PasswordChar = '*';
                ibtnHide.IconChar = IconChar.EyeSlash;
                vision = false;
            }
            else
            {
                txtPassword.PasswordChar = '\0';
                ibtnHide.IconChar = IconChar.Eye;
                vision = true;
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