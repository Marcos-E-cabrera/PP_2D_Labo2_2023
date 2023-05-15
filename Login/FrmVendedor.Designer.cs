namespace Frm_Vendedor
{
    partial class FrmVendedor
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
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Heladera = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ibtnVendedor = new FontAwesome.Sharp.IconButton();
            this.ibtnSalir = new FontAwesome.Sharp.IconButton();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Heladera
            // 
            this.Heladera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heladera.BackColor = System.Drawing.Color.White;
            this.Heladera.Location = new System.Drawing.Point(0, 48);
            this.Heladera.Name = "Heladera";
            this.Heladera.Size = new System.Drawing.Size(1222, 542);
            this.Heladera.TabIndex = 4;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.title.Controls.Add(this.label1);
            this.title.Controls.Add(this.ibtnVendedor);
            this.title.Controls.Add(this.ibtnSalir);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1222, 48);
            this.title.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "VENDEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ibtnVendedor.Location = new System.Drawing.Point(0, 6);
            this.ibtnVendedor.Name = "ibtnVendedor";
            this.ibtnVendedor.Size = new System.Drawing.Size(57, 45);
            this.ibtnVendedor.TabIndex = 20;
            this.ibtnVendedor.UseVisualStyleBackColor = true;
            // 
            // ibtnSalir
            // 
            this.ibtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.ibtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ibtnSalir.FlatAppearance.BorderSize = 0;
            this.ibtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibtnSalir.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(246)))));
            this.ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSalir.IconSize = 40;
            this.ibtnSalir.Location = new System.Drawing.Point(1175, 0);
            this.ibtnSalir.Name = "ibtnSalir";
            this.ibtnSalir.Size = new System.Drawing.Size(47, 48);
            this.ibtnSalir.TabIndex = 17;
            this.ibtnSalir.UseVisualStyleBackColor = true;
            this.ibtnSalir.Click += new System.EventHandler(this.ibtnSalir_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1222, 590);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Heladera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn Producto;
        private Panel Heladera;
        private Panel title;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private Label label1;
        private FontAwesome.Sharp.IconButton ibtnVendedor;
    }
}