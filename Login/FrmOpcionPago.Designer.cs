namespace Login
{
    partial class FrmOpcionPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.btnDevito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cómo desea pagar?";
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEfectivo.Location = new System.Drawing.Point(16, 62);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(105, 36);
            this.btnEfectivo.TabIndex = 1;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // btnDevito
            // 
            this.btnDevito.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDevito.Location = new System.Drawing.Point(148, 62);
            this.btnDevito.Name = "btnDevito";
            this.btnDevito.Size = new System.Drawing.Size(105, 36);
            this.btnDevito.TabIndex = 2;
            this.btnDevito.Text = "Devito";
            this.btnDevito.UseVisualStyleBackColor = true;
            this.btnDevito.Click += new System.EventHandler(this.btnDevito_Click);
            // 
            // FrmOpcionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 119);
            this.Controls.Add(this.btnDevito);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.label1);
            this.Name = "FrmOpcionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpcionPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnEfectivo;
        private Button btnDevito;
    }
}