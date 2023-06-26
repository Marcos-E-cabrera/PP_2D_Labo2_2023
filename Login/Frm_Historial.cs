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
    public partial class Frm_Historial : Form
    {
        #region CONSTRUCTOR
        public Frm_Historial()
        {
            InitializeComponent();
        }
        #endregion

        #region LOAD
        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            listHistorialFactura.DataSource = Historial.listFacturas;
            listHistorialFactura.Refresh();
            MostrarHistroial();
            Archivos.CrearArchivo_Historial(Historial.listFacturas);
        }
        #endregion

        #region MOSTRAR
        private void MostrarHistroial()
        {
            dgvHistorialVenta.AutoGenerateColumns = false;
            dgvHistorialVenta.Refresh();

            dgvHistorialVenta.Columns.AddRange(
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Producto",
                    DataPropertyName = "NombreProducto"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Cantidad",
                    DataPropertyName = "Cantidad"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Total",
                    DataPropertyName = "Total"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nombre",
                    DataPropertyName = "Nombre"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Apellido",
                    DataPropertyName = "Apellido"
                }
            );

            dgvHistorialVenta.DataSource = Vendedor.ListaHistorial;
            Archivos.CrearArchivo_HistorialCliente(Vendedor.ListaHistorial);
        }
        #endregion
    }
}
