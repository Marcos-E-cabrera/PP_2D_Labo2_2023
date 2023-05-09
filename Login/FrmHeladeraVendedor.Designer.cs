namespace Login
{
    partial class FrmHeladeraVendedor
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnOrdenar = new FontAwesome.Sharp.IconButton();
            this.ibtnLista = new FontAwesome.Sharp.IconButton();
            this.ibtnAñadir = new FontAwesome.Sharp.IconButton();
            this.ibtnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.ibtnReponer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvProductos.Size = new System.Drawing.Size(1004, 500);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
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
            this.cbOrdenar.Location = new System.Drawing.Point(739, 12);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(187, 28);
            this.cbOrdenar.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 500);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(861, 458);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(139, 35);
            this.panel3.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 31);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.panel2.Controls.Add(this.ibtnOrdenar);
            this.panel2.Controls.Add(this.ibtnLista);
            this.panel2.Controls.Add(this.ibtnAñadir);
            this.panel2.Controls.Add(this.ibtnSeleccionar);
            this.panel2.Controls.Add(this.ibtnReponer);
            this.panel2.Controls.Add(this.cbOrdenar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 51);
            this.panel2.TabIndex = 14;
            // 
            // ibtnOrdenar
            // 
            this.ibtnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnOrdenar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnOrdenar.FlatAppearance.BorderSize = 0;
            this.ibtnOrdenar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnOrdenar.ForeColor = System.Drawing.Color.White;
            this.ibtnOrdenar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.ibtnOrdenar.IconColor = System.Drawing.Color.White;
            this.ibtnOrdenar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnOrdenar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnOrdenar.Location = new System.Drawing.Point(937, -1);
            this.ibtnOrdenar.Name = "ibtnOrdenar";
            this.ibtnOrdenar.Size = new System.Drawing.Size(40, 50);
            this.ibtnOrdenar.TabIndex = 17;
            this.ibtnOrdenar.UseVisualStyleBackColor = true;
            this.ibtnOrdenar.Click += new System.EventHandler(this.ibtnOrdenar_Click);
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
            this.ibtnLista.Location = new System.Drawing.Point(559, 0);
            this.ibtnLista.Name = "ibtnLista";
            this.ibtnLista.Size = new System.Drawing.Size(136, 50);
            this.ibtnLista.TabIndex = 16;
            this.ibtnLista.Text = "Ver Carrito";
            this.ibtnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnLista.UseVisualStyleBackColor = true;
            this.ibtnLista.Click += new System.EventHandler(this.ibtnLista_Click);
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
            this.ibtnAñadir.Location = new System.Drawing.Point(370, 0);
            this.ibtnAñadir.Name = "ibtnAñadir";
            this.ibtnAñadir.Size = new System.Drawing.Size(165, 50);
            this.ibtnAñadir.TabIndex = 15;
            this.ibtnAñadir.Text = "Añadir Carrito";
            this.ibtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnAñadir.UseVisualStyleBackColor = true;
            this.ibtnAñadir.Click += new System.EventHandler(this.ibtnAñadir_Click);
            // 
            // ibtnSeleccionar
            // 
            this.ibtnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnSeleccionar.FlatAppearance.BorderSize = 0;
            this.ibtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.ibtnSeleccionar.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.ibtnSeleccionar.IconColor = System.Drawing.Color.White;
            this.ibtnSeleccionar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnSeleccionar.Location = new System.Drawing.Point(160, 0);
            this.ibtnSeleccionar.Name = "ibtnSeleccionar";
            this.ibtnSeleccionar.Size = new System.Drawing.Size(195, 50);
            this.ibtnSeleccionar.TabIndex = 14;
            this.ibtnSeleccionar.Text = "Seleccionar Cliente";
            this.ibtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnSeleccionar.UseVisualStyleBackColor = true;
            this.ibtnSeleccionar.Click += new System.EventHandler(this.ibtnSeleccionar_Click);
            // 
            // ibtnReponer
            // 
            this.ibtnReponer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ibtnReponer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnReponer.FlatAppearance.BorderSize = 0;
            this.ibtnReponer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            this.ibtnReponer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnReponer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ibtnReponer.ForeColor = System.Drawing.Color.White;
            this.ibtnReponer.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnReponer.IconColor = System.Drawing.Color.White;
            this.ibtnReponer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnReponer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnReponer.Location = new System.Drawing.Point(22, 0);
            this.ibtnReponer.Name = "ibtnReponer";
            this.ibtnReponer.Size = new System.Drawing.Size(118, 50);
            this.ibtnReponer.TabIndex = 13;
            this.ibtnReponer.Text = "Reponer";
            this.ibtnReponer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ibtnReponer.UseVisualStyleBackColor = true;
            this.ibtnReponer.Click += new System.EventHandler(this.ibtnReponer_Click);
            // 
            // FrmHeladeraVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            this.ClientSize = new System.Drawing.Size(1004, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "FrmHeladeraVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHeladeraVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvProductos;
        private ComboBox cbOrdenar;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton ibtnReponer;
        private FontAwesome.Sharp.IconButton ibtnSeleccionar;
        private FontAwesome.Sharp.IconButton ibtnAñadir;
        private FontAwesome.Sharp.IconButton ibtnLista;
        private FontAwesome.Sharp.IconButton ibtnOrdenar;
        private Panel panel3;
        private Label label1;
    }
}