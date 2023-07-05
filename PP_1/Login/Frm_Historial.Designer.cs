namespace Login
{
    partial class Frm_Historial
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            gbHistorialVenta = new GroupBox();
            dgvHistorialVenta = new DataGridView();
            gbHistorialFactura = new GroupBox();
            listHistorialFactura = new ListBox();
            panel1.SuspendLayout();
            gbHistorialVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVenta).BeginInit();
            gbHistorialFactura.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(gbHistorialVenta);
            panel1.Controls.Add(gbHistorialFactura);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 694);
            panel1.TabIndex = 0;
            // 
            // gbHistorialVenta
            // 
            gbHistorialVenta.BackColor = Color.LightGreen;
            gbHistorialVenta.Controls.Add(dgvHistorialVenta);
            gbHistorialVenta.Dock = DockStyle.Fill;
            gbHistorialVenta.Location = new Point(470, 0);
            gbHistorialVenta.Name = "gbHistorialVenta";
            gbHistorialVenta.Size = new Size(728, 694);
            gbHistorialVenta.TabIndex = 8;
            gbHistorialVenta.TabStop = false;
            gbHistorialVenta.Text = "Historial Venta";
            // 
            // dgvHistorialVenta
            // 
            dgvHistorialVenta.AllowUserToResizeColumns = false;
            dgvHistorialVenta.AllowUserToResizeRows = false;
            dgvHistorialVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialVenta.BackgroundColor = Color.White;
            dgvHistorialVenta.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistorialVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHistorialVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistorialVenta.ColumnHeadersHeight = 29;
            dgvHistorialVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHistorialVenta.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHistorialVenta.Dock = DockStyle.Fill;
            dgvHistorialVenta.EnableHeadersVisualStyles = false;
            dgvHistorialVenta.GridColor = SystemColors.WindowText;
            dgvHistorialVenta.Location = new Point(3, 23);
            dgvHistorialVenta.Name = "dgvHistorialVenta";
            dgvHistorialVenta.ReadOnly = true;
            dgvHistorialVenta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHistorialVenta.RowHeadersVisible = false;
            dgvHistorialVenta.RowHeadersWidth = 51;
            dgvHistorialVenta.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dgvHistorialVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHistorialVenta.RowTemplate.Height = 29;
            dgvHistorialVenta.Size = new Size(722, 668);
            dgvHistorialVenta.TabIndex = 6;
            // 
            // gbHistorialFactura
            // 
            gbHistorialFactura.BackColor = Color.LightGreen;
            gbHistorialFactura.Controls.Add(listHistorialFactura);
            gbHistorialFactura.Dock = DockStyle.Left;
            gbHistorialFactura.Location = new Point(0, 0);
            gbHistorialFactura.Name = "gbHistorialFactura";
            gbHistorialFactura.Size = new Size(470, 694);
            gbHistorialFactura.TabIndex = 7;
            gbHistorialFactura.TabStop = false;
            gbHistorialFactura.Text = "Historial Factura";
            // 
            // listHistorialFactura
            // 
            listHistorialFactura.Dock = DockStyle.Fill;
            listHistorialFactura.FormattingEnabled = true;
            listHistorialFactura.ItemHeight = 20;
            listHistorialFactura.Location = new Point(3, 23);
            listHistorialFactura.Name = "listHistorialFactura";
            listHistorialFactura.Size = new Size(464, 668);
            listHistorialFactura.TabIndex = 0;
            // 
            // Frm_Historial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 694);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Historial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            panel1.ResumeLayout(false);
            gbHistorialVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorialVenta).EndInit();
            gbHistorialFactura.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvHistorialVenta;
        private GroupBox gbHistorialVenta;
        private GroupBox gbHistorialFactura;
        private ListBox listHistorialFactura;
    }
}