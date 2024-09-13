namespace PollosWeed.Forms
{
    partial class RegistrarVentaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVentaForm));
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtPesoUnitario = new System.Windows.Forms.TextBox();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.txtVrUnitario = new System.Windows.Forms.TextBox();
            this.txtVrTotal = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblPesoUnitario = new System.Windows.Forms.Label();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.lblVrUnitario = new System.Windows.Forms.Label();
            this.lblVrTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(117, 33);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(117, 71);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(76, 20);
            this.txtDetalle.TabIndex = 1;
            // 
            // txtPesoUnitario
            // 
            this.txtPesoUnitario.Location = new System.Drawing.Point(117, 104);
            this.txtPesoUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoUnitario.Name = "txtPesoUnitario";
            this.txtPesoUnitario.Size = new System.Drawing.Size(76, 20);
            this.txtPesoUnitario.TabIndex = 2;
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(117, 139);
            this.txtPesoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.ReadOnly = true;
            this.txtPesoTotal.Size = new System.Drawing.Size(76, 20);
            this.txtPesoTotal.TabIndex = 3;
            // 
            // txtVrUnitario
            // 
            this.txtVrUnitario.Location = new System.Drawing.Point(117, 176);
            this.txtVrUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrUnitario.Name = "txtVrUnitario";
            this.txtVrUnitario.Size = new System.Drawing.Size(76, 20);
            this.txtVrUnitario.TabIndex = 4;
            // 
            // txtVrTotal
            // 
            this.txtVrTotal.Location = new System.Drawing.Point(117, 218);
            this.txtVrTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrTotal.Name = "txtVrTotal";
            this.txtVrTotal.ReadOnly = true;
            this.txtVrTotal.Size = new System.Drawing.Size(76, 20);
            this.txtVrTotal.TabIndex = 5;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.Location = new System.Drawing.Point(64, 262);
            this.btnRegistrarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(75, 24);
            this.btnRegistrarVenta.TabIndex = 6;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(217, 12);
            this.dgvVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowHeadersWidth = 51;
            this.dgvVentas.RowTemplate.Height = 24;
            this.dgvVentas.Size = new System.Drawing.Size(727, 274);
            this.dgvVentas.TabIndex = 7;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(37, 36);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(47, 74);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(51, 13);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblPesoUnitario
            // 
            this.lblPesoUnitario.AutoSize = true;
            this.lblPesoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoUnitario.Location = new System.Drawing.Point(11, 111);
            this.lblPesoUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoUnitario.Name = "lblPesoUnitario";
            this.lblPesoUnitario.Size = new System.Drawing.Size(87, 13);
            this.lblPesoUnitario.TabIndex = 10;
            this.lblPesoUnitario.Text = "Peso Unitario:";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoTotal.Location = new System.Drawing.Point(24, 146);
            this.lblPesoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(72, 13);
            this.lblPesoTotal.TabIndex = 11;
            this.lblPesoTotal.Text = "Peso Total:";
            // 
            // lblVrUnitario
            // 
            this.lblVrUnitario.AutoSize = true;
            this.lblVrUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrUnitario.Location = new System.Drawing.Point(8, 183);
            this.lblVrUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrUnitario.Name = "lblVrUnitario";
            this.lblVrUnitario.Size = new System.Drawing.Size(88, 13);
            this.lblVrUnitario.TabIndex = 12;
            this.lblVrUnitario.Text = "Valor Unitario:";
            // 
            // lblVrTotal
            // 
            this.lblVrTotal.AutoSize = true;
            this.lblVrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrTotal.Location = new System.Drawing.Point(25, 218);
            this.lblVrTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrTotal.Name = "lblVrTotal";
            this.lblVrTotal.Size = new System.Drawing.Size(73, 13);
            this.lblVrTotal.TabIndex = 13;
            this.lblVrTotal.Text = "Valor Total:";
            // 
            // RegistrarVentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 309);
            this.Controls.Add(this.lblVrTotal);
            this.Controls.Add(this.lblVrUnitario);
            this.Controls.Add(this.lblPesoTotal);
            this.Controls.Add(this.lblPesoUnitario);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtVrTotal);
            this.Controls.Add(this.txtVrUnitario);
            this.Controls.Add(this.txtPesoTotal);
            this.Controls.Add(this.txtPesoUnitario);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtCantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarVentaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Venta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegistrarVentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtPesoUnitario;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.TextBox txtVrUnitario;
        private System.Windows.Forms.TextBox txtVrTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblPesoUnitario;
        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.Label lblVrUnitario;
        private System.Windows.Forms.Label lblVrTotal;
    }
}
