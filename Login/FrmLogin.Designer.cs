namespace Login
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnCliente = new FontAwesome.Sharp.IconButton();
            this.ibtnVendedor = new FontAwesome.Sharp.IconButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ibtnHide = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.txtUsuario.Location = new System.Drawing.Point(43, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Username";
            this.txtUsuario.Size = new System.Drawing.Size(308, 27);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.txtPassword.Location = new System.Drawing.Point(43, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(275, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresar.Location = new System.Drawing.Point(149, 287);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(127, 43);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Login";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 379);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-222, -30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ibtnCliente);
            this.panel2.Controls.Add(this.ibtnVendedor);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.ibtnSalir);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(345, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 379);
            this.panel2.TabIndex = 13;
            this.panel2.Tag = "";
            // 
            // ibtnCliente
            // 
            this.ibtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ibtnCliente.FlatAppearance.BorderSize = 0;
            this.ibtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnCliente.IconColor = System.Drawing.Color.White;
            this.ibtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnCliente.Location = new System.Drawing.Point(59, 4);
            this.ibtnCliente.Name = "ibtnCliente";
            this.ibtnCliente.Size = new System.Drawing.Size(48, 44);
            this.ibtnCliente.TabIndex = 20;
            this.ibtnCliente.UseVisualStyleBackColor = true;
            this.ibtnCliente.Click += new System.EventHandler(this.ibtnCliente_Click);
            // 
            // ibtnVendedor
            // 
            this.ibtnVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ibtnVendedor.FlatAppearance.BorderSize = 0;
            this.ibtnVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVendedor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ibtnVendedor.IconColor = System.Drawing.Color.White;
            this.ibtnVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVendedor.Location = new System.Drawing.Point(3, 4);
            this.ibtnVendedor.Name = "ibtnVendedor";
            this.ibtnVendedor.Size = new System.Drawing.Size(50, 42);
            this.ibtnVendedor.TabIndex = 19;
            this.ibtnVendedor.UseVisualStyleBackColor = true;
            this.ibtnVendedor.Click += new System.EventHandler(this.ibtnVendedor_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Location = new System.Drawing.Point(29, 182);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(369, 88);
            this.panel9.TabIndex = 18;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label2);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 56);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(369, 23);
            this.panel10.TabIndex = 15;
            this.panel10.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = " Invalid Password";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Controls.Add(this.ibtnHide);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.txtPassword);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 56);
            this.panel5.TabIndex = 14;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 28;
            this.iconPictureBox2.Location = new System.Drawing.Point(11, 14);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(28, 29);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox2.TabIndex = 18;
            this.iconPictureBox2.TabStop = false;
            // 
            // ibtnHide
            // 
            this.ibtnHide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnHide.FlatAppearance.BorderSize = 0;
            this.ibtnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibtnHide.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ibtnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnHide.IconSize = 30;
            this.ibtnHide.Location = new System.Drawing.Point(324, 12);
            this.ibtnHide.Name = "ibtnHide";
            this.ibtnHide.Size = new System.Drawing.Size(40, 31);
            this.ibtnHide.TabIndex = 17;
            this.ibtnHide.UseVisualStyleBackColor = true;
            this.ibtnHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibtnHide_MouseClick);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.panel6.Location = new System.Drawing.Point(17, 45);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(334, 1);
            this.panel6.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Location = new System.Drawing.Point(29, 88);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(369, 88);
            this.panel7.TabIndex = 17;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 56);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(369, 24);
            this.panel8.TabIndex = 13;
            this.panel8.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = " Invalid User Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 56);
            this.panel3.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 27;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(28, 27);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 17;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.panel4.Location = new System.Drawing.Point(17, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(334, 1);
            this.panel4.TabIndex = 13;
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ibtnSalir.FlatAppearance.BorderSize = 0;
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 40;
            this.ibtnSalir.Location = new System.Drawing.Point(372, 3);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(48, 43);
            this.ibtnSalir.TabIndex = 16;
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(773, 389);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel6;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ibtnHide;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel9;
        private Panel panel10;
        private Label label2;
        private Panel panel7;
        private Panel panel8;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnCliente;
        private FontAwesome.Sharp.IconButton ibtnVendedor;
    }
}