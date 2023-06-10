﻿using Biblioteca_Carniceria;
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

        public Frm_Historial()
        {
            InitializeComponent();        
        }

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
            listHistorialFactura.DataSource = Historial.listFacturas;
            listHistorialFactura.Refresh();
            MostrarHistroial();
        }

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
        }
    }
}
