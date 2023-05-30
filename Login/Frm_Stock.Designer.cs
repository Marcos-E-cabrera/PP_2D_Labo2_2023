namespace Frm_Vendedor
{
    partial class Frm_Stock
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
            txtStockProducto = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            ibtnSalir = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel3 = new Panel();
            btnOK = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtStockProducto
            // 
            txtStockProducto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStockProducto.Location = new Point(12, 27);
            txtStockProducto.Name = "txtStockProducto";
            txtStockProducto.Size = new Size(229, 27);
            txtStockProducto.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(0, 2);
            label3.Name = "label3";
            label3.Size = new Size(212, 38);
            label3.TabIndex = 6;
            label3.Text = "Agregar STOCK";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(176, 205, 197);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(ibtnSalir);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 48);
            panel1.TabIndex = 10;
            // 
            // ibtnSalir
            // 
            ibtnSalir.FlatAppearance.BorderColor = Color.FromArgb(176, 205, 197);
            ibtnSalir.FlatAppearance.BorderSize = 0;
            ibtnSalir.FlatStyle = FlatStyle.Flat;
            ibtnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            ibtnSalir.IconColor = Color.FromArgb(252, 252, 246);
            ibtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtnSalir.IconSize = 40;
            ibtnSalir.Location = new Point(205, 2);
            ibtnSalir.Name = "ibtnSalir";
            ibtnSalir.Size = new Size(48, 43);
            ibtnSalir.TabIndex = 17;
            ibtnSalir.UseVisualStyleBackColor = true;
            ibtnSalir.Click += ibtnSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(119, 170, 161);
            panel2.Controls.Add(txtStockProducto);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 133);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(176, 205, 197);
            panel3.Controls.Add(btnOK);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(253, 56);
            panel3.TabIndex = 0;
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderColor = Color.FromArgb(176, 205, 197);
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.IconChar = FontAwesome.Sharp.IconChar.Check;
            btnOK.IconColor = Color.FromArgb(252, 252, 246);
            btnOK.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnOK.IconSize = 60;
            btnOK.ImageAlign = ContentAlignment.MiddleLeft;
            btnOK.Location = new Point(98, 7);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(65, 49);
            btnOK.TabIndex = 18;
            btnOK.TextAlign = ContentAlignment.MiddleRight;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // Frm_Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 181);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Stock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmStock";
            Load += FrmStock_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtDetalleProducto;
        private TextBox txtStockProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton ibtnSalir;
        private FontAwesome.Sharp.IconButton btnOK;
    }
}