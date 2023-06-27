namespace Frm_Vendedor
{
    partial class Frm_Venta
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            grbClientes = new GroupBox();
            gpbCarrito = new GroupBox();
            dgvCarrito = new DataGridView();
            btnSeleccionarCliente = new Button();
            grbHeladera = new GroupBox();
            dgvHeladera = new DataGridView();
            label3 = new Label();
            btn_Comprar = new Button();
            btn_Factura = new Button();
            btnAgregar = new Button();
            checkEfectivo = new CheckBox();
            checkDebito = new CheckBox();
            label1 = new Label();
            label5 = new Label();
            cbxOrdenamiento = new ComboBox();
            lb_Dinero = new Label();
            label4 = new Label();
            lb_Vacio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grbClientes.SuspendLayout();
            gpbCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            grbHeladera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = SystemColors.WindowText;
            dgvClientes.Location = new Point(3, 23);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(477, 310);
            dgvClientes.TabIndex = 9;
            // 
            // grbClientes
            // 
            grbClientes.Controls.Add(dgvClientes);
            grbClientes.Location = new Point(12, 12);
            grbClientes.Name = "grbClientes";
            grbClientes.Size = new Size(483, 336);
            grbClientes.TabIndex = 13;
            grbClientes.TabStop = false;
            grbClientes.Text = "Clientes";
            // 
            // gpbCarrito
            // 
            gpbCarrito.Controls.Add(lb_Vacio);
            gpbCarrito.Controls.Add(dgvCarrito);
            gpbCarrito.Location = new Point(15, 401);
            gpbCarrito.Name = "gpbCarrito";
            gpbCarrito.Size = new Size(480, 221);
            gpbCarrito.TabIndex = 14;
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
            dgvCarrito.Size = new Size(474, 195);
            dgvCarrito.TabIndex = 7;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.ForeColor = Color.Black;
            btnSeleccionarCliente.Location = new Point(170, 354);
            btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            btnSeleccionarCliente.Size = new Size(154, 29);
            btnSeleccionarCliente.TabIndex = 23;
            btnSeleccionarCliente.Text = "Seleccionar";
            btnSeleccionarCliente.UseVisualStyleBackColor = true;
            btnSeleccionarCliente.Click += btnSeleccionarCliente_Click;
            // 
            // grbHeladera
            // 
            grbHeladera.Controls.Add(dgvHeladera);
            grbHeladera.Controls.Add(label3);
            grbHeladera.Location = new Point(515, 32);
            grbHeladera.Name = "grbHeladera";
            grbHeladera.Size = new Size(639, 590);
            grbHeladera.TabIndex = 24;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvHeladera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvHeladera.ColumnHeadersHeight = 29;
            dgvHeladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvHeladera.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.WindowText;
            dgvHeladera.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dgvHeladera.RowTemplate.Height = 29;
            dgvHeladera.Size = new Size(633, 564);
            dgvHeladera.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, -18);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 48;
            label3.Text = "Dinero:";
            // 
            // btn_Comprar
            // 
            btn_Comprar.ForeColor = Color.Black;
            btn_Comprar.Location = new Point(18, 639);
            btn_Comprar.Name = "btn_Comprar";
            btn_Comprar.Size = new Size(108, 29);
            btn_Comprar.TabIndex = 25;
            btn_Comprar.Text = "Comprar";
            btn_Comprar.UseVisualStyleBackColor = true;
            btn_Comprar.Click += btn_Comprar_Click;
            // 
            // btn_Factura
            // 
            btn_Factura.ForeColor = Color.Black;
            btn_Factura.Location = new Point(385, 639);
            btn_Factura.Name = "btn_Factura";
            btn_Factura.Size = new Size(107, 29);
            btn_Factura.TabIndex = 26;
            btn_Factura.Text = "Factura";
            btn_Factura.UseVisualStyleBackColor = true;
            btn_Factura.Click += btn_Factura_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(773, 639);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(165, 29);
            btnAgregar.TabIndex = 28;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // checkEfectivo
            // 
            checkEfectivo.AutoSize = true;
            checkEfectivo.Location = new Point(148, 644);
            checkEfectivo.Name = "checkEfectivo";
            checkEfectivo.Size = new Size(84, 24);
            checkEfectivo.TabIndex = 29;
            checkEfectivo.Text = "Efectivo";
            checkEfectivo.UseVisualStyleBackColor = true;
            checkEfectivo.CheckedChanged += checkEfectivo_CheckedChanged;
            // 
            // checkDebito
            // 
            checkDebito.AutoSize = true;
            checkDebito.Location = new Point(238, 644);
            checkDebito.Name = "checkDebito";
            checkDebito.Size = new Size(77, 24);
            checkDebito.TabIndex = 30;
            checkDebito.Text = "Debito";
            checkDebito.UseVisualStyleBackColor = true;
            checkDebito.CheckedChanged += checkDebito_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 622);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 31;
            label1.Text = "Forma de Pago";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1031, 621);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 34;
            label5.Text = "Ordenar por:";
            // 
            // cbxOrdenamiento
            // 
            cbxOrdenamiento.FormattingEnabled = true;
            cbxOrdenamiento.Location = new Point(1030, 644);
            cbxOrdenamiento.Name = "cbxOrdenamiento";
            cbxOrdenamiento.Size = new Size(112, 28);
            cbxOrdenamiento.TabIndex = 33;
            cbxOrdenamiento.SelectedIndexChanged += cbxOrdenamiento_SelectedIndexChanged;
            // 
            // lb_Dinero
            // 
            lb_Dinero.AutoSize = true;
            lb_Dinero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Dinero.Location = new Point(1062, 8);
            lb_Dinero.Name = "lb_Dinero";
            lb_Dinero.Size = new Size(0, 31);
            lb_Dinero.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1002, 12);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 48;
            label4.Text = "Dinero:";
            // 
            // lb_Vacio
            // 
            lb_Vacio.AutoSize = true;
            lb_Vacio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Vacio.Location = new Point(133, 112);
            lb_Vacio.Name = "lb_Vacio";
            lb_Vacio.Size = new Size(190, 31);
            lb_Vacio.TabIndex = 51;
            lb_Vacio.Text = "Carrito esta vacio";
            lb_Vacio.Visible = false;
            // 
            // Frm_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1173, 680);
            Controls.Add(lb_Dinero);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(cbxOrdenamiento);
            Controls.Add(label1);
            Controls.Add(checkDebito);
            Controls.Add(checkEfectivo);
            Controls.Add(btnAgregar);
            Controls.Add(btn_Factura);
            Controls.Add(btn_Comprar);
            Controls.Add(grbHeladera);
            Controls.Add(btnSeleccionarCliente);
            Controls.Add(gpbCarrito);
            Controls.Add(grbClientes);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Venta";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grbClientes.ResumeLayout(false);
            gpbCarrito.ResumeLayout(false);
            gpbCarrito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            grbHeladera.ResumeLayout(false);
            grbHeladera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvClientes;
        private GroupBox grbClientes;
        private GroupBox gpbCarrito;
        private DataGridView dgvCarrito;
        private Button btnSeleccionarCliente;
        private GroupBox grbHeladera;
        private Button btn_Comprar;
        private Button btn_Factura;
        private DataGridView dgvHeladera;
        private Button btnAgregar;
        private CheckBox checkEfectivo;
        private CheckBox checkDebito;
        private Label label1;
        private Label label5;
        private ComboBox cbxOrdenamiento;
        private Label label3;
        private Label lb_Dinero;
        private Label label4;
        private Label lb_Vacio;
    }
}