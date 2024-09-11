namespace PollosWeed
{
    partial class InsumosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtVrUnitario;
        private System.Windows.Forms.TextBox txtVrTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblVrUnitario;
        private System.Windows.Forms.Label lblVrTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;

        /// <summary>
        /// Limpiar recursos utilizados.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para el soporte del Diseñador. 
        /// No modifique el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsumosForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtVrUnitario = new System.Windows.Forms.TextBox();
            this.txtVrTotal = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblVrUnitario = new System.Windows.Forms.Label();
            this.lblVrTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(243, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(114, 29);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(114, 20);
            this.txtCantidad.TabIndex = 1;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(114, 64);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(114, 20);
            this.txtDetalle.TabIndex = 2;
            // 
            // txtVrUnitario
            // 
            this.txtVrUnitario.Location = new System.Drawing.Point(114, 109);
            this.txtVrUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrUnitario.Name = "txtVrUnitario";
            this.txtVrUnitario.Size = new System.Drawing.Size(114, 20);
            this.txtVrUnitario.TabIndex = 3;
            // 
            // txtVrTotal
            // 
            this.txtVrTotal.Location = new System.Drawing.Point(114, 153);
            this.txtVrTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtVrTotal.Name = "txtVrTotal";
            this.txtVrTotal.Size = new System.Drawing.Size(114, 20);
            this.txtVrTotal.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(11, 32);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 13);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(11, 67);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(51, 13);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblVrUnitario
            // 
            this.lblVrUnitario.AutoSize = true;
            this.lblVrUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrUnitario.Location = new System.Drawing.Point(11, 112);
            this.lblVrUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrUnitario.Name = "lblVrUnitario";
            this.lblVrUnitario.Size = new System.Drawing.Size(88, 13);
            this.lblVrUnitario.TabIndex = 7;
            this.lblVrUnitario.Text = "Valor Unitario:";
            // 
            // lblVrTotal
            // 
            this.lblVrTotal.AutoSize = true;
            this.lblVrTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrTotal.Location = new System.Drawing.Point(11, 160);
            this.lblVrTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVrTotal.Name = "lblVrTotal";
            this.lblVrTotal.Size = new System.Drawing.Size(73, 13);
            this.lblVrTotal.TabIndex = 8;
            this.lblVrTotal.Text = "Valor Total:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(14, 224);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 24);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(125, 224);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 24);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // InsumosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblVrTotal);
            this.Controls.Add(this.lblVrUnitario);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtVrTotal);
            this.Controls.Add(this.txtVrUnitario);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InsumosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insumos";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
