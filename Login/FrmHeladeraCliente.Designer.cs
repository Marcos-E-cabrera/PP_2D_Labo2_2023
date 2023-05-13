namespace Login
{
    partial class FrmHeladeraCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ibtnSaldo = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnOrdenar = new FontAwesome.Sharp.IconButton();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.ibtnLista = new FontAwesome.Sharp.IconButton();
            this.ibtnAñadir = new FontAwesome.Sharp.IconButton();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 591);
            this.panel1.TabIndex = 20;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.Location = new System.Drawing.Point(0, 0);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.Size = new System.Drawing.Size(993, 591);
            this.dgvProductos.TabIndex = 6;
            // 
            // ibtnSaldo
            // 
            this.ibtnSaldo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSaldo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnSaldo.FlatAppearance.BorderSize = 0;
            this.ibtnSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSaldo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnSaldo.ForeColor = System.Drawing.Color.White;
            this.ibtnSaldo.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.ibtnSaldo.IconColor = System.Drawing.Color.White;
            this.ibtnSaldo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSaldo.Location = new System.Drawing.Point(30, 6);
            this.ibtnSaldo.Name = "ibtnSaldo";
            this.ibtnSaldo.Size = new System.Drawing.Size(147, 50);
            this.ibtnSaldo.TabIndex = 27;
            this.ibtnSaldo.Text = "Añadir Saldo";
            this.ibtnSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSaldo.UseVisualStyleBackColor = true;
            //this.ibtnSaldo.Click += new System.EventHandler(this.ibtnSaldo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.ibtnSaldo);
            this.panel2.Controls.Add(this.ibtnOrdenar);
            this.panel2.Controls.Add(this.txtSaldo);
            this.panel2.Controls.Add(this.ibtnLista);
            this.panel2.Controls.Add(this.ibtnAñadir);
            this.panel2.Controls.Add(this.cbOrdenar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 61);
            this.panel2.TabIndex = 21;
            // 
            // ibtnOrdenar
            // 
            this.ibtnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnOrdenar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnOrdenar.FlatAppearance.BorderSize = 0;
            this.ibtnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrdenar.ForeColor = System.Drawing.Color.White;
            this.ibtnOrdenar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.ibtnOrdenar.IconColor = System.Drawing.Color.White;
            this.ibtnOrdenar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrdenar.Location = new System.Drawing.Point(932, 8);
            this.ibtnOrdenar.Name = "ibtnOrdenar";
            this.ibtnOrdenar.Size = new System.Drawing.Size(57, 50);
            this.ibtnOrdenar.TabIndex = 25;
            this.ibtnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnOrdenar.UseVisualStyleBackColor = true;
            this.ibtnOrdenar.Click += new System.EventHandler(this.ibtnOrdenar_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSaldo.Location = new System.Drawing.Point(183, 18);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(147, 27);
            this.txtSaldo.TabIndex = 19;
            // 
            // ibtnLista
            // 
            this.ibtnLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnLista.FlatAppearance.BorderSize = 0;
            this.ibtnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLista.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnLista.ForeColor = System.Drawing.Color.White;
            this.ibtnLista.IconChar = FontAwesome.Sharp.IconChar.CartArrowDown;
            this.ibtnLista.IconColor = System.Drawing.Color.White;
            this.ibtnLista.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnLista.Location = new System.Drawing.Point(548, 8);
            this.ibtnLista.Name = "ibtnLista";
            this.ibtnLista.Size = new System.Drawing.Size(136, 50);
            this.ibtnLista.TabIndex = 24;
            this.ibtnLista.Text = "Ver Carrito";
            this.ibtnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLista.UseVisualStyleBackColor = true;
            //this.ibtnLista.Click += new System.EventHandler(this.ibtnLista_Click);
            // 
            // ibtnAñadir
            // 
            this.ibtnAñadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnAñadir.FlatAppearance.BorderSize = 0;
            this.ibtnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnAñadir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnAñadir.ForeColor = System.Drawing.Color.White;
            this.ibtnAñadir.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.ibtnAñadir.IconColor = System.Drawing.Color.White;
            this.ibtnAñadir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnAñadir.Location = new System.Drawing.Point(359, 8);
            this.ibtnAñadir.Name = "ibtnAñadir";
            this.ibtnAñadir.Size = new System.Drawing.Size(165, 50);
            this.ibtnAñadir.TabIndex = 23;
            this.ibtnAñadir.Text = "Añadir Carrito";
            this.ibtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAñadir.UseVisualStyleBackColor = true;
            //this.ibtnAñadir.Click += new System.EventHandler(this.ibtnAñadir_Click);
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.cbOrdenar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbOrdenar.ForeColor = System.Drawing.Color.White;
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Location = new System.Drawing.Point(726, 17);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(210, 28);
            this.cbOrdenar.TabIndex = 22;
            // 
            // FrmHeladeraCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(993, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHeladeraCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmHeladeraCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvProductos;
        private TextBox txtSaldo;
        private FontAwesome.Sharp.IconButton ibtnOrdenar;
        private FontAwesome.Sharp.IconButton ibtnLista;
        private FontAwesome.Sharp.IconButton ibtnAñadir;
        private ComboBox cbOrdenar;
        private FontAwesome.Sharp.IconButton ibtnSaldo;
    }
}