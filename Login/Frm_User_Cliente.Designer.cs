namespace Login
{
    partial class Frm_User_Cliente
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label5 = new Label();
            cbxOrdenamiento = new ComboBox();
            label2 = new Label();
            txtDinero = new TextBox();
            label1 = new Label();
            checkDebito = new CheckBox();
            checkEfectivo = new CheckBox();
            btnAgregar = new Button();
            btn_Factura = new Button();
            btn_Comprar = new Button();
            grbHeladera = new GroupBox();
            dgvHeladera = new DataGridView();
            gpbCarrito = new GroupBox();
            dgvCarrito = new DataGridView();
            panel1 = new Panel();
            lblUser = new Label();
            grbHeladera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).BeginInit();
            gpbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(878, 622);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 48;
            label5.Text = "Ordenar por:";
            // 
            // cbxOrdenamiento
            // 
            cbxOrdenamiento.FormattingEnabled = true;
            cbxOrdenamiento.Location = new Point(977, 618);
            cbxOrdenamiento.Name = "cbxOrdenamiento";
            cbxOrdenamiento.Size = new Size(112, 28);
            cbxOrdenamiento.TabIndex = 47;
            cbxOrdenamiento.SelectedIndexChanged += cbxOrdenamiento_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(515, 622);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 46;
            label2.Text = "Dinero";
            // 
            // txtDinero
            // 
            txtDinero.Location = new Point(575, 617);
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new Size(125, 27);
            txtDinero.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 533);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 45;
            label1.Text = "Forma de Pago";
            // 
            // checkDebito
            // 
            checkDebito.AutoSize = true;
            checkDebito.Location = new Point(102, 555);
            checkDebito.Name = "checkDebito";
            checkDebito.Size = new Size(77, 24);
            checkDebito.TabIndex = 44;
            checkDebito.Text = "Debito";
            checkDebito.UseVisualStyleBackColor = true;
            checkDebito.CheckedChanged += checkDebito_CheckedChanged;
            // 
            // checkEfectivo
            // 
            checkEfectivo.AutoSize = true;
            checkEfectivo.Location = new Point(12, 555);
            checkEfectivo.Name = "checkEfectivo";
            checkEfectivo.Size = new Size(84, 24);
            checkEfectivo.TabIndex = 43;
            checkEfectivo.Text = "Efectivo";
            checkEfectivo.UseVisualStyleBackColor = true;
            checkEfectivo.CheckedChanged += checkEfectivo_CheckedChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(270, 617);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(114, 29);
            btnAgregar.TabIndex = 42;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btn_Factura
            // 
            btn_Factura.ForeColor = Color.Black;
            btn_Factura.Location = new Point(139, 617);
            btn_Factura.Name = "btn_Factura";
            btn_Factura.Size = new Size(107, 29);
            btn_Factura.TabIndex = 41;
            btn_Factura.Text = "Factura";
            btn_Factura.UseVisualStyleBackColor = true;
            btn_Factura.Click += btn_Factura_Click;
            // 
            // btn_Comprar
            // 
            btn_Comprar.ForeColor = Color.Black;
            btn_Comprar.Location = new Point(10, 617);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(108, 29);
            btn_Comprar.TabIndex = 40;
            btn_Comprar.Text = "Comprar";
            btn_Comprar.UseVisualStyleBackColor = true;
            btn_Comprar.Click += btn_Comprar_Click;
            // 
            // grbHeladera
            // 
            grbHeladera.Controls.Add(dgvHeladera);
            grbHeladera.Location = new Point(509, 12);
            grbHeladera.Name = "grbHeladera";
            grbHeladera.Size = new Size(665, 567);
            grbHeladera.TabIndex = 39;
            grbHeladera.TabStop = false;
            grbHeladera.Text = "Heladera";
            // 
            // dgvHeladera
            // 
            dgvHeladera.AllowUserToResizeColumns = false;
            dgvHeladera.AllowUserToResizeRows = false;
            dgvHeladera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeladera.BackgroundColor = Color.White;
            dgvHeladera.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHeladera.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHeladera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHeladera.ColumnHeadersHeight = 29;
            dgvHeladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHeladera.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHeladera.Dock = DockStyle.Fill;
            dgvHeladera.EnableHeadersVisualStyles = false;
            dgvHeladera.GridColor = SystemColors.WindowText;
            dgvHeladera.Location = new Point(3, 23);
            dgvHeladera.Name = "dgvHeladera";
            dgvHeladera.ReadOnly = true;
            dgvHeladera.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHeladera.RowHeadersVisible = false;
            dgvHeladera.RowHeadersWidth = 51;
            dgvHeladera.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dgvHeladera.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHeladera.RowTemplate.Height = 29;
            dgvHeladera.Size = new Size(659, 541);
            dgvHeladera.TabIndex = 8;
            // 
            // gpbCarrito
            // 
            gpbCarrito.Controls.Add(dgvCarrito);
            gpbCarrito.Location = new Point(9, 12);
            gpbCarrito.Name = "gpbCarrito";
            gpbCarrito.Size = new Size(480, 515);
            gpbCarrito.TabIndex = 37;
            gpbCarrito.TabStop = false;
            gpbCarrito.Text = "Carrito";
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToResizeColumns = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarrito.ColumnHeadersHeight = 29;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle5;
            dgvCarrito.Dock = DockStyle.Fill;
            dgvCarrito.EnableHeadersVisualStyles = false;
            dgvCarrito.GridColor = SystemColors.WindowText;
            dgvCarrito.Location = new Point(3, 23);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = Color.Gainsboro;
            dataGridViewCellStyle6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.WindowText;
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvCarrito.RowTemplate.Height = 29;
            dgvCarrito.Size = new Size(474, 489);
            dgvCarrito.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(lblUser);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 701);
            panel1.Name = "panel1";
            panel1.Size = new Size(1181, 19);
            panel1.TabIndex = 49;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 20);
            lblUser.TabIndex = 0;
            // 
            // Frm_User_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 720);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(cbxOrdenamiento);
            Controls.Add(label2);
            Controls.Add(txtDinero);
            Controls.Add(label1);
            Controls.Add(checkDebito);
            Controls.Add(checkEfectivo);
            Controls.Add(btnAgregar);
            Controls.Add(btn_Factura);
            Controls.Add(btn_Comprar);
            Controls.Add(grbHeladera);
            Controls.Add(gpbCarrito);
            Name = "Frm_User_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LA CABRERA";
            Load += Frm_User_Cliente_Load;
            grbHeladera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).EndInit();
            gpbCarrito.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox cbxOrdenamiento;
        private Label label2;
        private TextBox txtDinero;
        private Label label1;
        private CheckBox checkDebito;
        private CheckBox checkEfectivo;
        private Button btnAgregar;
        private Button btn_Factura;
        private Button btn_Comprar;
        private GroupBox grbHeladera;
        private DataGridView dgvHeladera;
        private GroupBox gpbCarrito;
        private DataGridView dgvCarrito;
        private Panel panel1;
        private Label lblUser;
    }
}