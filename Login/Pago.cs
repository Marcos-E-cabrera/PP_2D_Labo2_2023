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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void btnEfectivo_Click_1(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
        }

        private void btnDevito_Click_1(object sender, EventArgs e)
        {
            DialogResult= DialogResult.No;
        }
    }
}