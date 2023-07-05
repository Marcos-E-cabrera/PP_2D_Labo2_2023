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
    public partial class Frm_Dinero : Form
    {
        public int dinero;

        public Frm_Dinero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dinero = int.Parse(txt_Dinero.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
