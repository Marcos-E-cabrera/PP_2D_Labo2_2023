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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            grbClientes = new GroupBox();
            gpbCarrito = new GroupBox();
            dgvCarrito = new DataGridView();
            btnSeleccionarCliente = new Button();
            grbHeladera = new GroupBox();
            dgvHeladera = new DataGridView();
            btn_Comprar = new Button();
            btn_Factura = new Button();
            btnAgregar = new Button();
            checkEfectivo = new CheckBox();
            checkDebito = new CheckBox();
            label1 = new Label();
            txtDinero = new TextBox();
            label2 = new Label();
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
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle10.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dgvClientes.ColumnHeadersHeight = 29;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.BackColor = Color.Gainsboro;
            dataGridViewCellStyle12.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.WindowText;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle13.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dgvCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dgvCarrito.ColumnHeadersHeight = 29;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dgvCarrito.DefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.BackColor = Color.Gainsboro;
            dataGridViewCellStyle15.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.WindowText;
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgvCarrito.RowTemplate.Height = 29;
            dgvCarrito.Size = new Size(474, 195);
            dgvCarrito.TabIndex = 7;
            // 
            // btnSeleccionarCliente
            // 
            btnSeleccionarCliente.ForeColor = Color.Black;
            btnSeleccionarCliente.Location = new Point(109, 354);
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
            grbHeladera.Location = new Point(515, 32);
            grbHeladera.Name = "grbHeladera";
            grbHeladera.Size = new Size(665, 590);
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.FromArgb(119, 170, 161);
            dataGridViewCellStyle16.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            dgvHeladera.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            dgvHeladera.ColumnHeadersHeight = 29;
            dgvHeladera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.False;
            dgvHeladera.DefaultCellStyle = dataGridViewCellStyle17;
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
            dataGridViewCellStyle18.BackColor = Color.Gainsboro;
            dataGridViewCellStyle18.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.WindowText;
            dgvHeladera.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dgvHeladera.RowTemplate.Height = 29;
            dgvHeladera.Size = new Size(659, 564);
            dgvHeladera.TabIndex = 8;
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
            btnAgregar.Location = new Point(783, 639);
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
            // txtDinero
            // 
            txtDinero.Location = new Point(1055, 7);
            txtDinero.Name = "txtDinero";
            txtDinero.Size = new Size(125, 27);
            txtDinero.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(995, 12);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 32;
            label2.Text = "Dinero";
            // 
            // Frm_Venta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1195, 680);
            Controls.Add(label2);
            Controls.Add(txtDinero);
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
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            grbHeladera.ResumeLayout(false);
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
        private TextBox txtDinero;
        private Label label2;
    }
}