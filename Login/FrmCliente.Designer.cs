﻿namespace Login
{
    partial class FrmCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnVendedor = new FontAwesome.Sharp.IconButton();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ibtnVendedor);
            this.panel2.Controls.Add(this.ibtnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 45);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(436, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ibtnVendedor
            // 
            this.ibtnVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ibtnVendedor.FlatAppearance.BorderSize = 0;
            this.ibtnVendedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnVendedor.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ibtnVendedor.IconColor = System.Drawing.Color.White;
            this.ibtnVendedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnVendedor.Location = new System.Drawing.Point(381, 2);
            this.ibtnVendedor.Name = "ibtnVendedor";
            this.ibtnVendedor.Size = new System.Drawing.Size(49, 40);
            this.ibtnVendedor.TabIndex = 20;
            this.ibtnVendedor.UseVisualStyleBackColor = true;
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
            this.ibtnSalir.Location = new System.Drawing.Point(944, 7);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(47, 33);
            this.ibtnSalir.TabIndex = 17;
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 597);
            this.panel1.TabIndex = 7;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnVendedor;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Panel panel1;
    }
}