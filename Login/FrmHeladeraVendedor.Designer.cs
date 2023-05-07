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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ibtnOrdenar = new FontAwesome.Sharp.IconButton();
            this.ibtnLista = new FontAwesome.Sharp.IconButton();
            this.ibtnAñadir = new FontAwesome.Sharp.IconButton();
            this.ibtnSeleccionar = new FontAwesome.Sharp.IconButton();
            this.ibtnReponer = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductos.ColumnHeadersHeight = 29;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(205)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.RowTemplate.Height = 29;
            this.dgvProductos.Size = new System.Drawing.Size(993, 500);
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
            this.cbOrdenar.Location = new System.Drawing.Point(727, 11);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(210, 28);
            this.cbOrdenar.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 500);
            this.panel1.TabIndex = 13;
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
            this.panel2.Size = new System.Drawing.Size(993, 51);
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
            this.ibtnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibtnOrdenar.Location = new System.Drawing.Point(933, 2);
            this.ibtnOrdenar.Name = "ibtnOrdenar";
            this.ibtnOrdenar.Size = new System.Drawing.Size(57, 50);
            this.ibtnOrdenar.TabIndex = 17;
            this.ibtnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ibtnLista.Location = new System.Drawing.Point(549, 2);
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
            this.ibtnAñadir.Location = new System.Drawing.Point(360, 2);
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
            this.ibtnSeleccionar.Location = new System.Drawing.Point(150, 2);
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
            this.ibtnReponer.Location = new System.Drawing.Point(12, 2);
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
            this.ClientSize = new System.Drawing.Size(993, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHeladeraVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHeladeraVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
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
    }
}