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
        public Heladera _heladera;
        private ConexionSql conexionSql;

        private static List<Cliente> usuarios_Clientes = new List<Cliente>();  
        
        private List<Vendedor> listVendedor = new List<Vendedor>()
        {
            new Vendedor("Marcos", "Cabrera", "acottis2@toplist.cz", "jwAqIw0Alt5")
        };


        #region FRM LOGIN CONSTRUTOR
        public Login()
        {
            InitializeComponent();
            Read_Clientes();

            _heladera = new Heladera();            
            grb_SingUp.Visible = false;
            vision = true;
        }
        #endregion

        #region CRUD
        // READ
        private static void Read_Clientes()
        {
            try
            {
                ConexionSql.command.CommandText = "SELECT * FROM Usuario_Cliente";
                ConexionSql.connection.Open();
                ConexionSql.reader = ConexionSql.command.ExecuteReader();

                while (ConexionSql.reader.Read())
                {
                    usuarios_Clientes.Add(new Cliente(ConexionSql.reader["Nombre"].ToString(),
                                                 ConexionSql.reader["Apellido"].ToString(), 0,
                                                 ConexionSql.reader["Email"].ToString(),
                                                 ConexionSql.reader["Password"].ToString()));

                }

            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                ConexionSql.connection.Close();
                ConexionSql.reader.Close();
            }

        }

        // CREATED
        private static void Create_Cliente(string nombre, string apellido, string email, string password)
        {
            try
            {

                ConexionSql.command.CommandText = "INSERT INTO Usuario_Cliente " +
                                        "VALUES (@nombre, @apellido, @email, @password)";

                // Configurar los parámetros del comando
                ConexionSql.command.Parameters.AddWithValue("@nombre", nombre);
                ConexionSql.command.Parameters.AddWithValue("@apellido", apellido);
                ConexionSql.command.Parameters.AddWithValue("@email", email);
                ConexionSql.command.Parameters.AddWithValue("@password", password);

                ConexionSql.connection.Open();

                // Ejecutar el comando SQL
                ConexionSql.command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexión a la base de datos: " + ex.Message);
            }
            finally
            {
                ConexionSql.connection.Close();
            }
        }

        private static void Read_ultimoUsuario()
        {
            try
            {
                ConexionSql.command.CommandText = "SELECT TOP 1 * FROM Usuario_Cliente ORDER BY id DESC";
                ConexionSql.connection.Open();
                ConexionSql.reader = ConexionSql.command.ExecuteReader();

                while (ConexionSql.reader.Read())
                {
                    usuarios_Clientes.Add(new Cliente(ConexionSql.reader["Nombre"].ToString(),
                                                 ConexionSql.reader["Apellido"].ToString(), 0,
                                                 ConexionSql.reader["Email"].ToString(),
                                                 ConexionSql.reader["Password"].ToString()));

                }
            }
            catch (Exception)
            {
                throw new Exception("Error de conexión a la base de datos");
            }
            finally
            {
                ConexionSql.connection.Close();
                ConexionSql.reader.Close();
            }
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
                        Create_Cliente(txtNombre_SingUp.Text, txtApellido_SingUp.Text, txtEmail_SingUp.Text, txtPassword_SingUp.Text);
                        Read_ultimoUsuario();
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