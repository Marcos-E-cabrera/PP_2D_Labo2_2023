using Biblioteca_Carniceria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Frm_User_Vendedor : Form
    {
        private Vendedor vendedor;
        public Frm_User_Vendedor()
        {
            InitializeComponent();

        }

        public Frm_User_Vendedor(Vendedor vendedor) : this()
        {
            this.vendedor = vendedor;
        }

        private void Frm_User_Vendedor_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Tipo: {vendedor.ObtenerUsuario()} || Usuario: {vendedor.Nombre} {vendedor.Apellido}";
        }


        private void menu_Heladera_Click(object sender, EventArgs e)
        {
            Frm_Heladera frm_Heladera = new Frm_Heladera();
            pictureBox1.Visible = false;
            addForm(frm_Heladera);
        }

        /// <summary>
        /// Agrega un formulario al panel principal del formulario actual, ajustando su tamaño
        /// para que llene todo el espacio disponible.
        /// </summary>
        /// <param name="form">El formulario que se quiere agregar al panel.</param>
        public void addForm(Form form)
        {
            // Establecer el formulario como no principal
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            this.panel2.Controls.Add(form);
            form.Show();
        }
    }
}
