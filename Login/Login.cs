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
        private bool _SingUp = false;
        public CN_Heladera _heladera;

        private static List<Cliente> usuarios_Clientes = new List<Cliente>();  
        
        private List<Vendedor> listVendedor = new List<Vendedor>()
        {
            new Vendedor("Marcos", "Cabrera", "acottis2@toplist.cz", "jwAqIw0Alt5")
        };


        #region FRM LOGIN CONSTRUTOR
        public Login()
        {
            InitializeComponent();
            usuarios_Clientes = CD_Cliente.CreacionListaUsuario();

            _heladera = new CN_Heladera();            
            grb_SingUp.Visible = false;
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
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            bool isCliente;
            bool isVendedor;

            if (isCliente = usuarios_Clientes.Exists(i => (i.Nombre == usuario || i.Email == usuario) && i.Password == password))
            {

                Cliente cliente = usuarios_Clientes.Find(i => (i.Email == usuario || i.Nombre == usuario));
                if (cliente == null)
                {
                    throw new Exception();
                }
                else
                {
                    Frm_User_Cliente tipoCliente = new Frm_User_Cliente(cliente);
                    tipoCliente.Show(this);
                }
            }
            if (isVendedor = listVendedor.Exists(i => (i.Nombre == usuario || i.Email == usuario) && i.Password == password))
            {

                Vendedor vendedor = listVendedor.Find(i => i.Email == usuario);

                Frm_User_Vendedor tipoVendedor = new Frm_User_Vendedor(vendedor);
                tipoVendedor.Show(this);
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

        private void btn_SingUp_Click(object sender, EventArgs e)
        {
            int errores = 0;
            int codigoError = 0;
            
            if (!_SingUp)
            {
                grb_SingUp.Visible = true;
                _SingUp = true;
            }
            else
            {
                if (string.IsNullOrEmpty(txtNombre_SingUp.Text) || !txtNombre_SingUp.Text.All(char.IsLetter))
                {
                    errores = 1;
                    codigoError = 101; // Código de error para el campo de nombre
                }
                else if (string.IsNullOrEmpty(txtApellido_SingUp.Text) || !txtApellido_SingUp.Text.All(char.IsLetter))
                {
                    errores = 2;
                    codigoError = 102; // Código de error para el campo de apellido
                }
                else if (string.IsNullOrEmpty(txtEmail_SingUp.Text) || !txtEmail_SingUp.Text.Contains("@"))
                {
                    errores = 3;
                    codigoError = 103; // Código de error para el campo de email
                }
                else if (string.IsNullOrEmpty(txtPassword_SingUp.Text))
                {
                    errores = 4;
                }
                else
                {
                    errores = 0;
                }

                // Realiza alguna acción según el valor de la variable "errores" y "codigoError"

                switch (codigoError)
                {
                    case 101:
                        MessageBox.Show("Error en el campo Nombre");
                        grb_SingUp.Visible = false;
                        _SingUp = false;
                        break;
                    case 102:
                        MessageBox.Show("Error en el campo Apellido");
                        break;
                    case 103:
                        MessageBox.Show("Error en el campo Email");
                        break;
                }

                switch (errores)
                {
                    case 0:
                        CD_Cliente.Created(txtNombre_SingUp.Text, txtApellido_SingUp.Text, txtEmail_SingUp.Text, txtPassword_SingUp.Text);
                        CD_Cliente.Read();
                        grb_SingUp.Visible = false;
                        break;
                    case 1:
                        MessageBox.Show("Falta ingresar Nombre");
                        break;
                    case 2:
                        MessageBox.Show("Falta ingresar Apellido");
                        break;
                    case 3:
                        MessageBox.Show("Falta ingresar Email");
                        break;
                    case 4:
                        MessageBox.Show("Falta ingresar Password");
                        break;
                }
            }
        }



    }
}