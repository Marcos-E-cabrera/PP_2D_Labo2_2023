namespace Login
{
    partial class Frm_Factura
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
            list_Factura = new ListBox();
            SuspendLayout();
            // 
            // list_Factura
            // 
            list_Factura.Dock = DockStyle.Fill;
            list_Factura.FormattingEnabled = true;
            list_Factura.ItemHeight = 20;
            list_Factura.Location = new Point(0, 0);
            list_Factura.Name = "list_Factura";
            list_Factura.Size = new Size(462, 413);
            list_Factura.TabIndex = 0;
            // 
            // Frm_Factura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 205, 197);
            ClientSize = new Size(462, 413);
            Controls.Add(list_Factura);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Frm_Factura";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmFactura_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox list_Factura;
    }
}