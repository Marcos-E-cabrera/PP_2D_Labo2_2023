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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            menuStrip2 = new MenuStrip();
            menu_Heladera = new ToolStripMenuItem();
            menu_AñadirCliente = new ToolStripMenuItem();
            menu_Carrito = new ToolStripMenuItem();
            menu_Ventas = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lblUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 637);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 23);
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
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.ImeMode = ImeMode.Disable;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1182, 597);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-7, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1194, 627);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
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
            panel3.Size = new Size(1182, 37);
            panel3.TabIndex = 3;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Fill;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { menu_Heladera, menu_AñadirCliente, menu_Carrito, menu_Ventas });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1182, 37);
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
            // 
            // menu_Carrito
            // 
            menu_Carrito.Name = "menu_Carrito";
            menu_Carrito.Size = new Size(68, 33);
            menu_Carrito.Text = "Carrito";
            // 
            // menu_Ventas
            // 
            menu_Ventas.Name = "menu_Ventas";
            menu_Ventas.Size = new Size(66, 33);
            menu_Ventas.Text = "Ventas";
            // 
            // Frm_User_Vendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 660);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            ImeMode = ImeMode.Disable;
            Name = "Frm_User_Vendedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LA CABRERA";
            Load += Frm_User_Vendedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Panel panel3;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem menu_Heladera;
        private ToolStripMenuItem menu_AñadirCliente;
        private ToolStripMenuItem menu_Carrito;
        private ToolStripMenuItem menu_Ventas;
        private PictureBox pictureBox1;
    }
}