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
            this.btnEfectivo = new FontAwesome.Sharp.IconButton();
            this.btnDevito = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cómo desea pagar?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEfectivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.btnEfectivo.FlatAppearance.BorderSize = 0;
            this.btnEfectivo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.btnEfectivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.btnEfectivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.btnEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEfectivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEfectivo.ForeColor = System.Drawing.Color.White;
            this.btnEfectivo.IconChar = FontAwesome.Sharp.IconChar.MoneyBillAlt;
            this.btnEfectivo.IconColor = System.Drawing.Color.White;
            this.btnEfectivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEfectivo.Location = new System.Drawing.Point(12, 71);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(120, 36);
            this.btnEfectivo.TabIndex = 28;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click_1);
            // 
            // btnDevito
            // 
            this.btnDevito.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevito.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.btnDevito.FlatAppearance.BorderSize = 0;
            this.btnDevito.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.btnDevito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.btnDevito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.btnDevito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDevito.ForeColor = System.Drawing.Color.White;
            this.btnDevito.IconChar = FontAwesome.Sharp.IconChar.CcMastercard;
            this.btnDevito.IconColor = System.Drawing.Color.White;
            this.btnDevito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDevito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevito.Location = new System.Drawing.Point(149, 71);
            this.btnDevito.Name = "btnDevito";
            this.btnDevito.Size = new System.Drawing.Size(120, 36);
            this.btnDevito.TabIndex = 29;
            this.btnDevito.Text = "Devito";
            this.btnDevito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevito.UseVisualStyleBackColor = true;
            this.btnDevito.Click += new System.EventHandler(this.btnDevito_Click_1);
            // 
            // FrmOpcionPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(281, 119);
            this.Controls.Add(this.btnDevito);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOpcionPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOpcionPago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton btnEfectivo;
        private FontAwesome.Sharp.IconButton btnDevito;
    }
}