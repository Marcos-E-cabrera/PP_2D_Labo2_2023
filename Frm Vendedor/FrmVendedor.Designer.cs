namespace Frm_Vendedor
{
    partial class FrmVendedor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReponer = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReponer
            // 
            this.btnReponer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReponer.Location = new System.Drawing.Point(783, 12);
            this.btnReponer.Name = "btnReponer";
            this.btnReponer.Size = new System.Drawing.Size(135, 40);
            this.btnReponer.TabIndex = 1;
            this.btnReponer.Text = "Reponer";
            this.btnReponer.UseVisualStyleBackColor = true;
            this.btnReponer.Click += new System.EventHandler(this.btnReponer_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.Location = new System.Drawing.Point(783, 342);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(135, 40);
            this.btnVender.TabIndex = 2;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(783, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // dGVProductos
            // 
            this.dGVProductos.AllowUserToResizeColumns = false;
            this.dGVProductos.AllowUserToResizeRows = false;
            this.dGVProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVProductos.BackgroundColor = System.Drawing.Color.White;
            this.dGVProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVProductos.ColumnHeadersHeight = 29;
            this.dGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVProductos.EnableHeadersVisualStyles = false;
            this.dGVProductos.GridColor = System.Drawing.SystemColors.WindowText;
            this.dGVProductos.Location = new System.Drawing.Point(10, 12);
            this.dGVProductos.Name = "dGVProductos";
            this.dGVProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVProductos.RowHeadersVisible = false;
            this.dGVProductos.RowHeadersWidth = 51;
            this.dGVProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dGVProductos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVProductos.RowTemplate.Height = 29;
            this.dGVProductos.Size = new System.Drawing.Size(736, 427);
            this.dGVProductos.TabIndex = 4;
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 451);
            this.Controls.Add(this.dGVProductos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnReponer);
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVendedor_FormClosing);
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnReponer;
        private Button btnVender;
        private Button btnSalir;
        private DataGridViewTextBoxColumn Producto;
        private DataGridView dGVProductos;
    }
}