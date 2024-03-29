﻿namespace Login
{
    partial class Login
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
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            grb_SingUp = new GroupBox();
            panel12 = new Panel();
            panel11 = new Panel();
            txtNombre_SingUp = new TextBox();
            txtEmail_SingUp = new TextBox();
            panel14 = new Panel();
            txtPassword_SingUp = new TextBox();
            txtApellido_SingUp = new TextBox();
            panel19 = new Panel();
            btn_SingUp = new Button();
            ibtnCliente = new FontAwesome.Sharp.IconButton();
            ibtnVendedor = new FontAwesome.Sharp.IconButton();
            panel9 = new Panel();
            panel5 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            ibtnHide = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            panel7 = new Panel();
            panel3 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel4 = new Panel();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            grb_SingUp.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.BackColor = Color.FromArgb(119, 170, 161);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.FromArgb(252, 252, 246);
            txtUsuario.Location = new Point(43, 13);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Username / Email";
            txtUsuario.Size = new Size(308, 27);
            txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(119, 170, 161);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(252, 252, 246);
            txtPassword.Location = new Point(43, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(275, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.FlatAppearance.BorderColor = Color.FromArgb(252, 252, 246);
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(29, 311);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(127, 43);
            btnIngresar.TabIndex = 8;
            btnIngresar.Text = "Login";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 252, 246);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 379);
            panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(-222, -30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(783, 408);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(grb_SingUp);
            panel2.Controls.Add(btn_SingUp);
            panel2.Controls.Add(ibtnCliente);
            panel2.Controls.Add(ibtnVendedor);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(ibtnSalir);
            panel2.Controls.Add(btnIngresar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(345, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(427, 379);
            panel2.TabIndex = 13;
            panel2.Tag = "";
            // 
            // grb_SingUp
            // 
            grb_SingUp.Controls.Add(panel12);
            grb_SingUp.Controls.Add(panel11);
            grb_SingUp.Controls.Add(txtNombre_SingUp);
            grb_SingUp.Controls.Add(txtEmail_SingUp);
            grb_SingUp.Controls.Add(panel14);
            grb_SingUp.Controls.Add(txtPassword_SingUp);
            grb_SingUp.Controls.Add(txtApellido_SingUp);
            grb_SingUp.Controls.Add(panel19);
            grb_SingUp.Location = new Point(29, 72);
            grb_SingUp.Name = "grb_SingUp";
            grb_SingUp.Size = new Size(369, 218);
            grb_SingUp.TabIndex = 22;
            grb_SingUp.TabStop = false;
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.None;
            panel12.BackColor = Color.FromArgb(252, 252, 246);
            panel12.Location = new Point(9, 59);
            panel12.Name = "panel12";
            panel12.Size = new Size(160, 1);
            panel12.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.None;
            panel11.BackColor = Color.FromArgb(252, 252, 246);
            panel11.Location = new Point(183, 59);
            panel11.Name = "panel11";
            panel11.Size = new Size(160, 1);
            panel11.TabIndex = 14;
            // 
            // txtNombre_SingUp
            // 
            txtNombre_SingUp.Anchor = AnchorStyles.None;
            txtNombre_SingUp.BackColor = Color.FromArgb(119, 170, 161);
            txtNombre_SingUp.BorderStyle = BorderStyle.None;
            txtNombre_SingUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre_SingUp.ForeColor = Color.FromArgb(252, 252, 246);
            txtNombre_SingUp.Location = new Point(9, 27);
            txtNombre_SingUp.Name = "txtNombre_SingUp";
            txtNombre_SingUp.PlaceholderText = "Nombre";
            txtNombre_SingUp.Size = new Size(160, 27);
            txtNombre_SingUp.TabIndex = 19;
            // 
            // txtEmail_SingUp
            // 
            txtEmail_SingUp.Anchor = AnchorStyles.None;
            txtEmail_SingUp.BackColor = Color.FromArgb(119, 170, 161);
            txtEmail_SingUp.BorderStyle = BorderStyle.None;
            txtEmail_SingUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail_SingUp.ForeColor = Color.FromArgb(252, 252, 246);
            txtEmail_SingUp.Location = new Point(9, 82);
            txtEmail_SingUp.Name = "txtEmail_SingUp";
            txtEmail_SingUp.PlaceholderText = "Email";
            txtEmail_SingUp.Size = new Size(334, 27);
            txtEmail_SingUp.TabIndex = 4;
            // 
            // panel14
            // 
            panel14.Anchor = AnchorStyles.None;
            panel14.BackColor = Color.FromArgb(252, 252, 246);
            panel14.Location = new Point(9, 111);
            panel14.Name = "panel14";
            panel14.Size = new Size(334, 1);
            panel14.TabIndex = 13;
            // 
            // txtPassword_SingUp
            // 
            txtPassword_SingUp.Anchor = AnchorStyles.None;
            txtPassword_SingUp.BackColor = Color.FromArgb(119, 170, 161);
            txtPassword_SingUp.BorderStyle = BorderStyle.None;
            txtPassword_SingUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword_SingUp.ForeColor = Color.FromArgb(252, 252, 246);
            txtPassword_SingUp.Location = new Point(9, 136);
            txtPassword_SingUp.Name = "txtPassword_SingUp";
            txtPassword_SingUp.PlaceholderText = "Password";
            txtPassword_SingUp.Size = new Size(334, 27);
            txtPassword_SingUp.TabIndex = 4;
            // 
            // txtApellido_SingUp
            // 
            txtApellido_SingUp.Anchor = AnchorStyles.None;
            txtApellido_SingUp.BackColor = Color.FromArgb(119, 170, 161);
            txtApellido_SingUp.BorderStyle = BorderStyle.None;
            txtApellido_SingUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido_SingUp.ForeColor = Color.FromArgb(252, 252, 246);
            txtApellido_SingUp.Location = new Point(187, 27);
            txtApellido_SingUp.Name = "txtApellido_SingUp";
            txtApellido_SingUp.PlaceholderText = "Apellido";
            txtApellido_SingUp.Size = new Size(156, 27);
            txtApellido_SingUp.TabIndex = 18;
            // 
            // panel19
            // 
            panel19.Anchor = AnchorStyles.None;
            panel19.BackColor = Color.FromArgb(252, 252, 246);
            panel19.Location = new Point(9, 169);
            panel19.Name = "panel19";
            panel19.Size = new Size(334, 1);
            panel19.TabIndex = 13;
            // 
            // btn_SingUp
            // 
            btn_SingUp.FlatAppearance.BorderColor = Color.FromArgb(252, 252, 246);
            btn_SingUp.FlatStyle = FlatStyle.Flat;
            btn_SingUp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_SingUp.Location = new Point(271, 311);
            btn_SingUp.Name = "btn_SingUp";
            btn_SingUp.Size = new Size(127, 43);
            btn_SingUp.TabIndex = 21;
            btn_SingUp.Text = "Sing Up";
            btn_SingUp.UseVisualStyleBackColor = true;
            btn_SingUp.Click += btn_SingUp_Click;
            // 
            // ibtnCliente
            // 
            ibtnCliente.FlatAppearance.BorderColor = Color.FromArgb(119, 170, 161);
            ibtnCliente.FlatAppearance.BorderSize = 0;
            ibtnCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 205, 197);
            ibtnCliente.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 205, 197);
            ibtnCliente.FlatStyle = FlatStyle.Flat;
            ibtnCliente.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            ibtnCliente.IconColor = Color.White;
            ibtnCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnCliente.Location = new Point(85, 1);
            ibtnCliente.Name = "ibtnCliente";
            ibtnCliente.Size = new Size(48, 48);
            ibtnCliente.TabIndex = 20;
            ibtnCliente.UseVisualStyleBackColor = true;
            ibtnCliente.Click += ibtnCliente_Click;
            // 
            // ibtnVendedor
            // 
            ibtnVendedor.FlatAppearance.BorderColor = Color.FromArgb(119, 170, 161);
            ibtnVendedor.FlatAppearance.BorderSize = 0;
            ibtnVendedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(176, 205, 197);
            ibtnVendedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(176, 205, 197);
            ibtnVendedor.FlatStyle = FlatStyle.Flat;
            ibtnVendedor.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            ibtnVendedor.IconColor = Color.Snow;
            ibtnVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnVendedor.Location = new Point(29, 3);
            ibtnVendedor.Name = "ibtnVendedor";
            ibtnVendedor.Size = new Size(50, 43);
            ibtnVendedor.TabIndex = 19;
            ibtnVendedor.UseVisualStyleBackColor = true;
            ibtnVendedor.Click += ibtnVendedor_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel5);
            panel9.Location = new Point(29, 182);
            panel9.Name = "panel9";
            panel9.Size = new Size(369, 88);
            panel9.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(iconPictureBox2);
            panel5.Controls.Add(ibtnHide);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(txtPassword);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(369, 56);
            panel5.TabIndex = 14;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(119, 170, 161);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 28;
            iconPictureBox2.Location = new Point(11, 14);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(28, 29);
            iconPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox2.TabIndex = 18;
            iconPictureBox2.TabStop = false;
            // 
            // ibtnHide
            // 
            ibtnHide.Anchor = AnchorStyles.None;
            ibtnHide.FlatAppearance.BorderSize = 0;
            ibtnHide.FlatStyle = FlatStyle.Flat;
            ibtnHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ibtnHide.IconColor = Color.FromArgb(252, 252, 246);
            ibtnHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnHide.IconSize = 30;
            ibtnHide.Location = new Point(324, 12);
            ibtnHide.Name = "ibtnHide";
            ibtnHide.Size = new Size(40, 31);
            ibtnHide.TabIndex = 17;
            ibtnHide.UseVisualStyleBackColor = true;
            ibtnHide.MouseClick += ibtnHide_MouseClick;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.FromArgb(252, 252, 246);
            panel6.Location = new Point(17, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(334, 1);
            panel6.TabIndex = 13;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel3);
            panel7.Location = new Point(29, 88);
            panel7.Name = "panel7";
            panel7.Size = new Size(369, 88);
            panel7.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconPictureBox1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(txtUsuario);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(369, 56);
            panel3.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(119, 170, 161);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(11, 18);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(28, 27);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(252, 252, 246);
            panel4.Location = new Point(17, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 1);
            panel4.TabIndex = 13;
            // 
            // ibtnSalir
            // 
            ibtnSalir.FlatAppearance.BorderColor = Color.FromArgb(119, 170, 161);
            ibtnSalir.FlatAppearance.BorderSize = 0;
            ibtnSalir.FlatStyle = FlatStyle.Flat;
            ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            ibtnSalir.IconColor = Color.FromArgb(252, 252, 246);
            ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSalir.IconSize = 40;
            ibtnSalir.Location = new Point(372, 3);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(48, 43);
            ibtnSalir.TabIndex = 16;
            ibtnSalir.UseVisualStyleBackColor = true;
            ibtnSalir.Click += ibtnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(119, 170, 161);
            ClientSize = new Size(777, 389);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += FrmLogin_FormClosing;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            grb_SingUp.ResumeLayout(false);
            grb_SingUp.PerformLayout();
            panel9.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel7;
        private FontAwesome.Sharp.IconButton ibtnCliente;
        private FontAwesome.Sharp.IconButton ibtnVendedor;
        private Button btn_SingUp;
        private Panel panel19;
        private TextBox txtPassword_SingUp;
        private Panel panel14;
        private TextBox txtEmail_SingUp;
        private TextBox txtApellido_SingUp;
        private GroupBox grb_SingUp;
        private TextBox txtNombre_SingUp;
        private Panel panel12;
        private Panel panel11;
    }
}