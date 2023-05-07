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
    public partial class FrmCliente : Form
    {
        #region FRM CLIENTE CONSTRUCTOR
        public FrmCliente()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            FrmHeladeraCliente frmHeladeraVendedor = new FrmHeladeraCliente();
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
            // Establecer el formulario como no principal
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            this.panel1.Controls.Add(form);
            form.Show();
        }

        #endregion

        private void ibtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
