﻿using System;
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
    public partial class FrmOpcionPago : Form
    {
        public FrmOpcionPago()
        {
            InitializeComponent();
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void btnDevito_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.No;
        }
    }
}