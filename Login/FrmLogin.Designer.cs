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
            this.btnVendedor = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnComprador = new System.Windows.Forms.Button();
            this.chkbOcultar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(25, 67);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(140, 43);
            this.btnVendedor.TabIndex = 0;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(246, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Usuario";
            this.txtUsuario.Size = new System.Drawing.Size(250, 27);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(246, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(250, 27);
            this.txtPassword.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(356, 205);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(140, 43);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnComprador
            // 
            this.btnComprador.Location = new System.Drawing.Point(25, 132);
            this.btnComprador.Name = "btnComprador";
            this.btnComprador.Size = new System.Drawing.Size(140, 42);
            this.btnComprador.TabIndex = 9;
            this.btnComprador.Text = "Comprador";
            this.btnComprador.UseVisualStyleBackColor = true;
            this.btnComprador.Click += new System.EventHandler(this.btnComprador_Click);
            // 
            // chkbOcultar
            // 
            this.chkbOcultar.AutoSize = true;
            this.chkbOcultar.Location = new System.Drawing.Point(246, 162);
            this.chkbOcultar.Name = "chkbOcultar";
            this.chkbOcultar.Size = new System.Drawing.Size(79, 24);
            this.chkbOcultar.TabIndex = 10;
            this.chkbOcultar.Text = "Ocultar";
            this.chkbOcultar.UseVisualStyleBackColor = true;
            this.chkbOcultar.CheckedChanged += new System.EventHandler(this.chkbOcultar_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 281);
            this.Controls.Add(this.chkbOcultar);
            this.Controls.Add(this.btnComprador);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnVendedor);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVendedor;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Button btnIngresar;
        private Button btnComprador;
        private CheckBox chkbOcultar;
    }
}