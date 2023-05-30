namespace Login
{
    partial class Frm_Heladera
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvHeladera = new DataGridView();
            panel2 = new Panel();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnReponer = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(dgvHeladera);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 631);
            panel1.TabIndex = 0;
            // 
            // dgvHeladera
            // 
            dgvHeladera.AllowUserToResizeColumns = false;
            dgvHeladera.AllowUserToResizeRows = false;
            dgvHeladera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeladera.BackgroundColor = Color.White;
            dgvHeladera.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHeladera.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvHeladera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvHeladera.ColumnHeadersHeight = 29;
            dgvHeladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvHeladera.DefaultCellStyle = dataGridViewCellStyle5;
            dgvHeladera.Dock = DockStyle.Fill;
            dgvHeladera.EnableHeadersVisualStyles = false;
            dgvHeladera.GridColor = SystemColors.WindowText;
            dgvHeladera.Location = new Point(0, 0);
            dgvHeladera.Name = "dgvHeladera";
            dgvHeladera.ReadOnly = true;
            dgvHeladera.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHeladera.RowHeadersVisible = false;
            dgvHeladera.RowHeadersWidth = 51;
            dgvHeladera.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = Color.Gainsboro;
            dataGridViewCellStyle6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dgvHeladera.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvHeladera.RowTemplate.Height = 29;
            dgvHeladera.Size = new Size(870, 631);
            dgvHeladera.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnReponer);
            panel2.Controls.Add(btnModificar);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(870, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 631);
            panel2.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEliminar.Location = new Point(63, 442);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(52, 51);
            btnEliminar.TabIndex = 5;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnReponer
            // 
            btnReponer.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            btnReponer.IconColor = Color.Black;
            btnReponer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnReponer.Location = new Point(63, 124);
            btnReponer.Name = "btnReponer";
            btnReponer.Size = new Size(52, 47);
            btnReponer.TabIndex = 4;
            btnReponer.UseVisualStyleBackColor = true;
            btnReponer.Click += btnReponer_Click;
            // 
            // btnModificar
            // 
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnModificar.Location = new Point(63, 275);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(52, 46);
            btnModificar.TabIndex = 3;
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Frm_Heladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 631);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Heladera";
            Text = "Frm_Heladera";
            Load += Frm_Heladera_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvHeladera;
        private FontAwesome.Sharp.IconButton btnReponer;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}