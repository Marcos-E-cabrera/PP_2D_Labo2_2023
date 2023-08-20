namespace Login
{
    partial class Frm_User_Vendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblUser = new Label();
            panelMid = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            menuStrip2 = new MenuStrip();
            menu_Heladera = new ToolStripMenuItem();
            menu_AñadirCliente = new ToolStripMenuItem();
            menu_Ventas = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 722);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 19);
            panel1.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 20);
            lblUser.TabIndex = 0;
            // 
            // panelMid
            // 
            panelMid.BackColor = Color.CadetBlue;
            panelMid.Controls.Add(pictureBox1);
            panelMid.Dock = DockStyle.Bottom;
            panelMid.ImeMode = ImeMode.Disable;
            panelMid.Location = new Point(0, 40);
            panelMid.Name = "panelMid";
            panelMid.Size = new Size(1173, 682);
            panelMid.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1173, 682);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGoldenrod;
            panel3.Controls.Add(menuStrip2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1173, 37);
            panel3.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.LightGreen;
            menuStrip2.Dock = DockStyle.Fill;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menu_Heladera, menu_AñadirCliente, menu_Ventas });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1173, 37);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // menu_Heladera
            // 
            menu_Heladera.Name = "menu_Heladera";
            menu_Heladera.Size = new Size(84, 33);
            menu_Heladera.Text = "Heladera";
            menu_Heladera.Click += menu_Heladera_Click;
            // 
            // menu_AñadirCliente
            // 
            menu_AñadirCliente.Name = "menu_AñadirCliente";
            menu_AñadirCliente.Size = new Size(117, 33);
            menu_AñadirCliente.Text = "Añadir Cliente";
            menu_AñadirCliente.Click += menu_AñadirCliente_Click;
            // 
            // menu_Ventas
            // 
            menu_Ventas.Name = "menu_Ventas";
            menu_Ventas.Size = new Size(83, 33);
            menu_Ventas.Text = "Historial ";
            menu_Ventas.Click += menu_Ventas_Click;
            // 
            // Frm_User_Vendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 741);
            Controls.Add(panel3);
            Controls.Add(panelMid);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ImeMode = ImeMode.Disable;
            Name = "Frm_User_Vendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LA CABRERA";
            Load += Frm_User_Vendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lblUser;
        private Panel panelMid;
        private Panel panel3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menu_Heladera;
        private ToolStripMenuItem menu_AñadirCliente;
        private ToolStripMenuItem menu_Ventas;
        private PictureBox pictureBox1;
    }
}