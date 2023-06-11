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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeladera = new Panel();
            dgvHeladera = new DataGridView();
            btnReponer = new Button();
            label1 = new Label();
            txtStock = new TextBox();
            grbReponer = new GroupBox();
            label5 = new Label();
            cbxOrdenamiento = new ComboBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            cbxTipo = new ComboBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panelHeladera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).BeginInit();
            grbReponer.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeladera
            // 
            panelHeladera.BackColor = SystemColors.ControlDark;
            panelHeladera.Controls.Add(dgvHeladera);
            panelHeladera.Dock = DockStyle.Top;
            panelHeladera.Location = new Point(0, 0);
            panelHeladera.Name = "panelHeladera";
            panelHeladera.Size = new Size(1200, 579);
            panelHeladera.TabIndex = 0;
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
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHeladera.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(176, 205, 197);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dgvHeladera.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvHeladera.RowTemplate.Height = 29;
            dgvHeladera.Size = new Size(1200, 579);
            dgvHeladera.TabIndex = 7;
            dgvHeladera.CellClick += dgvHeladera_CellClick;
            // 
            // btnReponer
            // 
            btnReponer.Location = new Point(108, 42);
            btnReponer.Name = "btnReponer";
            btnReponer.Size = new Size(76, 29);
            btnReponer.TabIndex = 8;
            btnReponer.Text = "Reponer";
            btnReponer.UseVisualStyleBackColor = true;
            btnReponer.Click += btnReponer_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1076, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 7;
            label1.Text = "Tipo";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(951, 44);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(108, 27);
            txtStock.TabIndex = 6;
            // 
            // grbReponer
            // 
            grbReponer.BackColor = Color.LightGreen;
            grbReponer.Controls.Add(label5);
            grbReponer.Controls.Add(cbxOrdenamiento);
            grbReponer.Controls.Add(btnLimpiar);
            grbReponer.Controls.Add(btnEliminar);
            grbReponer.Controls.Add(btnAgregar);
            grbReponer.Controls.Add(cbxTipo);
            grbReponer.Controls.Add(btnReponer);
            grbReponer.Controls.Add(txtStock);
            grbReponer.Controls.Add(label4);
            grbReponer.Controls.Add(txtPrecio);
            grbReponer.Controls.Add(txtNombre);
            grbReponer.Controls.Add(label1);
            grbReponer.Controls.Add(label3);
            grbReponer.Controls.Add(label2);
            grbReponer.Dock = DockStyle.Fill;
            grbReponer.Location = new Point(0, 579);
            grbReponer.Name = "grbReponer";
            grbReponer.Size = new Size(1200, 117);
            grbReponer.TabIndex = 3;
            grbReponer.TabStop = false;
            grbReponer.Text = "Mantenimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 21);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 22;
            label5.Text = "Ordenar por:";
            // 
            // cbxOrdenamiento
            // 
            cbxOrdenamiento.FormattingEnabled = true;
            cbxOrdenamiento.Location = new Point(490, 44);
            cbxOrdenamiento.Name = "cbxOrdenamiento";
            cbxOrdenamiento.Size = new Size(112, 28);
            cbxOrdenamiento.TabIndex = 21;
            cbxOrdenamiento.SelectedIndexChanged += cbxOrdenamiento_SelectedIndexChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(294, 42);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(76, 29);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(199, 42);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(76, 29);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 42);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(76, 29);
            btnAgregar.TabIndex = 17;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbxTipo
            // 
            cbxTipo.FormattingEnabled = true;
            cbxTipo.Location = new Point(1076, 44);
            cbxTipo.Name = "cbxTipo";
            cbxTipo.Size = new Size(112, 28);
            cbxTipo.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(819, 21);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(819, 44);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(108, 27);
            txtPrecio.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(690, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(108, 27);
            txtNombre.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(951, 21);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 14;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(690, 21);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // Frm_Heladera
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 696);
            Controls.Add(grbReponer);
            Controls.Add(panelHeladera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Heladera";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Heladera";
            Load += Frm_Heladera_Load;
            panelHeladera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHeladera).EndInit();
            grbReponer.ResumeLayout(false);
            grbReponer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeladera;
        private DataGridView dgvHeladera;

        private Button btnReponer;
        private Label label1;
        private TextBox txtStock;
        private GroupBox grbReponer;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private Button btnEliminar;
        private Button btnAgregar;
        private ComboBox cbxTipo;
        private Button btnLimpiar;
        private Label label5;
        private ComboBox cbxOrdenamiento;
    }
}